﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using MoaiUtils.Common;
using MoaiUtils.MoaiParsing.Checks;
using MoaiUtils.MoaiParsing.CodeGraph;
using MoaiUtils.MoaiParsing.CodeGraph.Types;
using MoaiUtils.MoaiParsing.Parsing;
using MoaiUtils.Tools;

namespace MoaiUtils.MoaiParsing {
    public class MoaiParser {
        private readonly Action<string> statusCallback;
        private TypeCollection types;

        public MoaiParser(Action<string> statusCallback) {
            this.statusCallback = statusCallback;
        }

        public WarningList Warnings { get; private set; }
        public MoaiVersionInfo MoaiVersionInfo { get; private set; }

        public void Parse(DirectoryInfo moaiDirectory) {
            // Check that the input directory looks like the Moai main directory
            if (!moaiDirectory.GetDirectoryInfo(@"src\moai-core").Exists) {
                throw new PlainTextException(string.Format("Path '{0}' does not appear to be the base directory of a Moai source copy.", moaiDirectory));
            }

            // Initialize warning list
            Warnings = new WarningList();

            // Get Moai version
            MoaiVersionInfo = new MoaiVersionInfo(moaiDirectory);
            statusCallback(string.Format("Found {0}.", MoaiVersionInfo));

            // Initialize type list with primitive types
            types = new TypeCollection(includePrimitives: true, includeVariant: true);

            // Parse Moai classes and store them by class name
            statusCallback("Parsing Moai classes.");
            ParseMoaiCodeFiles(moaiDirectory);

       
          

            // Mark registered classes as scriptable
            statusCallback("Checking which classes are registered to be scriptable from Lua.");
            MarkScriptableClasses(moaiDirectory);


            // MOAILuaObject is not documented, probably because it would mess up
            // the Doxygen-generated documentation. Use dummy code instead.
            statusCallback("Adding hard-coded documentation for MOAILuaObject base class.");
            FilePosition dummyFilePosition = new FilePosition(new FileInfo("MOAILuaObject dummy code"));
            FileParser.ParseMoaiCodeFile(MOAILuaObject.DummyCode, dummyFilePosition, types, Warnings);

            // Make sure every class directly or indirectly inherits from MOAILuaObject
            MoaiClass luaObjectClass = (MoaiClass)types.GetOrCreate("MOAILuaObject", null);
            foreach (MoaiClass moaiClass in types.OfType<MoaiClass>().Where(x => x.IsScriptable))
            {
                if (!(moaiClass.AncestorClasses.Contains(luaObjectClass)) && moaiClass != luaObjectClass)
                {
                    moaiClass.BaseClasses.Add(luaObjectClass);
                }
                // Make sure every class has a new
                if (moaiClass.Members.FirstOrDefault(x => x.Name == "new") == null && moaiClass.ClassPosition != null)
                {
                    moaiClass.Members.Add(
                        new Method()
                        {
                            OutParameterSignature = new MoaiParsing.Parameter() { Name = "object", Type = moaiClass.Name },
                            Name = "new",
                            Description = "Create new instance of " + moaiClass.Name,
                            OwningClass = moaiClass,
                            Body = "",
                            MethodPosition = new MethodPosition(moaiClass.ClassPosition, "_new"),
                            Overloads = { new MethodOverload()
                            {
                                InParameters = { },
                                IsStatic = true,
                                OutParameters = { new OutParameter() { Description = "Result" , Name = "object", Type = moaiClass} }
                            }}
                        }
                    );
                }
            }

            // Perform additional checks that do not alter the code graph
            var checks = GetChecks();
            statusCallback(string.Format("Performing {0} additional code checks.", checks.Length));
            PerformChecks(checks, moaiDirectory);
        }

        private CheckBase[] GetChecks() {
            // Find all classes derived from CheckBase
            return GetType().Assembly.GetTypes()
                .Where(type => typeof (CheckBase).IsAssignableFrom(type))
                .Where(type => !type.IsAbstract)
                .Select(type => (CheckBase) Activator.CreateInstance(type))
                .ToArray();
        }

        private void PerformChecks(IEnumerable<CheckBase> checks, DirectoryInfo moaiDirectory) {
            GetChecks();
            foreach (CheckBase check in checks) {
                check.MoaiDirectory = moaiDirectory;
                check.Types = types;
                check.Warnings = Warnings;

                check.Run();
            }
        }

        public IEnumerable<MoaiClass> DocumentedClasses {
            get {
                return types
                    .OfType<MoaiClass>()
                    .Where(moaiClass => moaiClass.HasDocumentation);
            }
        }

        private void ParseMoaiCodeFiles(DirectoryInfo moaiDirectory) {
            // Parse .cpp and .h files in src
            DirectoryInfo srcDirectory = moaiDirectory.GetDirectoryInfo("src");
            IEnumerable<FileInfo> codeFiles = srcDirectory.GetFilesRecursively(".cpp", ".h");

            foreach (var codeFile in codeFiles) {
                FileParser.ParseMoaiCodeFile(codeFile, new FilePosition(codeFile), types, Warnings);
            }
        }

        private static readonly Regex classRegistrationInLuaRegex = new Regex(
           @"\.extend\s*\(\s*['""](?<className>[A-Za-z0-9_]+)['""]\s*,",
           RegexOptions.ExplicitCapture | RegexOptions.Compiled);

        private static readonly Regex classRegistrationInCPlusPlusRegex = new Regex(
            @"(?<!//\s*)REGISTER_LUA_CLASS\s*\(\s*(?<className>[A-Za-z0-9_]+)\s*\)",
            RegexOptions.ExplicitCapture | RegexOptions.Compiled);

        private void MarkScriptableClasses(DirectoryInfo moaiDirectory) {
            IEnumerable<string> fileNames = Directory.EnumerateFiles(moaiDirectory.FullName, "*.*", SearchOption.AllDirectories);
            foreach (string fileName in fileNames) {
                // Determine file type
                Regex registrationRegex;
                if (fileName.EndsWith(".cpp") || fileName.EndsWith(".h") || fileName.EndsWith(".mm")) {
                    registrationRegex = classRegistrationInCPlusPlusRegex;
                } else if (fileName.EndsWith(".lua")) {
                    registrationRegex = classRegistrationInLuaRegex;
                } else {
                    continue;
                }

                // Search file for class registrations
                var matches = registrationRegex.Matches(File.ReadAllText(fileName));
                foreach (Match match in matches) {
                    string className = match.Groups["className"].Value;
                    MoaiClass moaiClass = types.GetOrCreate(className, new FilePosition(new FileInfo(fileName))) as MoaiClass;
                    if (moaiClass != null) {
                        moaiClass.IsScriptable = true;
                    }
                }
            }
        }

    }
}