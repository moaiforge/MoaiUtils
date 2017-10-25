using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using MoaiUtils.Common;
using MoaiUtils.MoaiParsing;

namespace MoaiUtils.DocLint {
    class Program {
        private static int Main(string[] args) {
            return Bootstrapper.Start<Configuration>(args, Main);
        }

        private static void Main(Configuration configuration) {
            IList<WarningType> ignoreTypes = new List<WarningType>();

            if (configuration.Filter != null )
            {
                ignoreTypes = configuration.Filter
                    .Select(f => Enum.TryParse<WarningType>(f, ignoreCase: true, result: out var warning)
                        ? warning
                        : (WarningType?) null).Where(x => x.HasValue).Select(x => x.Value).ToList();

                if (ignoreTypes.Count != configuration.Filter.Count)
                {
                    var validEnumValues = String.Join("\n\t", Enum.GetNames(typeof(WarningType)));
                    Console.WriteLine($"There were invalid warning types specified\nValid values are: {validEnumValues}");
                    return;
                }
                Console.WriteLine("Ignoring Warning Types: "+String.Join(",",ignoreTypes));
            }

            // Parse Moai code
            var parser = new MoaiParser(statusCallback: s => Console.WriteLine("[] {0}", s));
            parser.Parse(new DirectoryInfo(configuration.InputDirectory));

            // Show warnings
            Console.WriteLine();
            var orderedWarnings = parser.Warnings.Where(x => !ignoreTypes.Contains(x.Type))
                .OrderBy(warning => warning.Position.FileInfo.FullName).ToList();
            foreach (var warning in orderedWarnings) {
                Console.WriteLine("[{0}]\t{1}\t[{2}]", warning.Position.ToString(configuration.PathsAsUri), warning.Message, warning.Type);
            }
            Console.WriteLine("\n{0} warnings.", orderedWarnings.Count);
        }
    }
}
