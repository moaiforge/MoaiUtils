//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.5
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from MoaiCppParser.g4 by ANTLR 4.5

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591

namespace CppParser {
using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="MoaiCppParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.5")]
[System.CLSCompliant(false)]
public interface IMoaiCppParserListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="MoaiCppParser.file"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFile([NotNull] MoaiCppParser.FileContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MoaiCppParser.file"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFile([NotNull] MoaiCppParser.FileContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MoaiCppParser.topLevelStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTopLevelStatement([NotNull] MoaiCppParser.TopLevelStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MoaiCppParser.topLevelStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTopLevelStatement([NotNull] MoaiCppParser.TopLevelStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MoaiCppParser.declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDeclaration([NotNull] MoaiCppParser.DeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MoaiCppParser.declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDeclaration([NotNull] MoaiCppParser.DeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MoaiCppParser.typeDef"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTypeDef([NotNull] MoaiCppParser.TypeDefContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MoaiCppParser.typeDef"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTypeDef([NotNull] MoaiCppParser.TypeDefContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MoaiCppParser.usingDirective"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUsingDirective([NotNull] MoaiCppParser.UsingDirectiveContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MoaiCppParser.usingDirective"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUsingDirective([NotNull] MoaiCppParser.UsingDirectiveContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MoaiCppParser.functionDefinition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunctionDefinition([NotNull] MoaiCppParser.FunctionDefinitionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MoaiCppParser.functionDefinition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunctionDefinition([NotNull] MoaiCppParser.FunctionDefinitionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MoaiCppParser.classDefinition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterClassDefinition([NotNull] MoaiCppParser.ClassDefinitionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MoaiCppParser.classDefinition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitClassDefinition([NotNull] MoaiCppParser.ClassDefinitionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MoaiCppParser.baseClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBaseClause([NotNull] MoaiCppParser.BaseClauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MoaiCppParser.baseClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBaseClause([NotNull] MoaiCppParser.BaseClauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MoaiCppParser.constructorDefinition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConstructorDefinition([NotNull] MoaiCppParser.ConstructorDefinitionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MoaiCppParser.constructorDefinition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConstructorDefinition([NotNull] MoaiCppParser.ConstructorDefinitionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MoaiCppParser.destructorDefinition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDestructorDefinition([NotNull] MoaiCppParser.DestructorDefinitionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MoaiCppParser.destructorDefinition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDestructorDefinition([NotNull] MoaiCppParser.DestructorDefinitionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MoaiCppParser.memberInitializerList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMemberInitializerList([NotNull] MoaiCppParser.MemberInitializerListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MoaiCppParser.memberInitializerList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMemberInitializerList([NotNull] MoaiCppParser.MemberInitializerListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MoaiCppParser.memberInitializer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMemberInitializer([NotNull] MoaiCppParser.MemberInitializerContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MoaiCppParser.memberInitializer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMemberInitializer([NotNull] MoaiCppParser.MemberInitializerContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>Array</c>
	/// labeled alternative in <see cref="MoaiCppParser.declarator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterArray([NotNull] MoaiCppParser.ArrayContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Array</c>
	/// labeled alternative in <see cref="MoaiCppParser.declarator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitArray([NotNull] MoaiCppParser.ArrayContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>Group</c>
	/// labeled alternative in <see cref="MoaiCppParser.declarator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGroup([NotNull] MoaiCppParser.GroupContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Group</c>
	/// labeled alternative in <see cref="MoaiCppParser.declarator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGroup([NotNull] MoaiCppParser.GroupContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>Function</c>
	/// labeled alternative in <see cref="MoaiCppParser.declarator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunction([NotNull] MoaiCppParser.FunctionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Function</c>
	/// labeled alternative in <see cref="MoaiCppParser.declarator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunction([NotNull] MoaiCppParser.FunctionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>Reference</c>
	/// labeled alternative in <see cref="MoaiCppParser.declarator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterReference([NotNull] MoaiCppParser.ReferenceContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Reference</c>
	/// labeled alternative in <see cref="MoaiCppParser.declarator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitReference([NotNull] MoaiCppParser.ReferenceContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>Pointer</c>
	/// labeled alternative in <see cref="MoaiCppParser.declarator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPointer([NotNull] MoaiCppParser.PointerContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Pointer</c>
	/// labeled alternative in <see cref="MoaiCppParser.declarator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPointer([NotNull] MoaiCppParser.PointerContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>Name</c>
	/// labeled alternative in <see cref="MoaiCppParser.declarator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterName([NotNull] MoaiCppParser.NameContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Name</c>
	/// labeled alternative in <see cref="MoaiCppParser.declarator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitName([NotNull] MoaiCppParser.NameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MoaiCppParser.type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterType([NotNull] MoaiCppParser.TypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MoaiCppParser.type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitType([NotNull] MoaiCppParser.TypeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MoaiCppParser.typeSpecifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTypeSpecifier([NotNull] MoaiCppParser.TypeSpecifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MoaiCppParser.typeSpecifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTypeSpecifier([NotNull] MoaiCppParser.TypeSpecifierContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MoaiCppParser.templateParamsBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTemplateParamsBlock([NotNull] MoaiCppParser.TemplateParamsBlockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MoaiCppParser.templateParamsBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTemplateParamsBlock([NotNull] MoaiCppParser.TemplateParamsBlockContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MoaiCppParser.templateParam"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTemplateParam([NotNull] MoaiCppParser.TemplateParamContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MoaiCppParser.templateParam"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTemplateParam([NotNull] MoaiCppParser.TemplateParamContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MoaiCppParser.templateArgsBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTemplateArgsBlock([NotNull] MoaiCppParser.TemplateArgsBlockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MoaiCppParser.templateArgsBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTemplateArgsBlock([NotNull] MoaiCppParser.TemplateArgsBlockContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MoaiCppParser.templateArg"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTemplateArg([NotNull] MoaiCppParser.TemplateArgContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MoaiCppParser.templateArg"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTemplateArg([NotNull] MoaiCppParser.TemplateArgContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MoaiCppParser.nestedNameSpecifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNestedNameSpecifier([NotNull] MoaiCppParser.NestedNameSpecifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MoaiCppParser.nestedNameSpecifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNestedNameSpecifier([NotNull] MoaiCppParser.NestedNameSpecifierContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MoaiCppParser.bracesBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBracesBlock([NotNull] MoaiCppParser.BracesBlockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MoaiCppParser.bracesBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBracesBlock([NotNull] MoaiCppParser.BracesBlockContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MoaiCppParser.bracketsBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBracketsBlock([NotNull] MoaiCppParser.BracketsBlockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MoaiCppParser.bracketsBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBracketsBlock([NotNull] MoaiCppParser.BracketsBlockContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MoaiCppParser.parensBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParensBlock([NotNull] MoaiCppParser.ParensBlockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MoaiCppParser.parensBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParensBlock([NotNull] MoaiCppParser.ParensBlockContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MoaiCppParser.blockContent"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBlockContent([NotNull] MoaiCppParser.BlockContentContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MoaiCppParser.blockContent"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBlockContent([NotNull] MoaiCppParser.BlockContentContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MoaiCppParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpression([NotNull] MoaiCppParser.ExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MoaiCppParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpression([NotNull] MoaiCppParser.ExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MoaiCppParser.expressionWithoutAngleBrackets"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpressionWithoutAngleBrackets([NotNull] MoaiCppParser.ExpressionWithoutAngleBracketsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MoaiCppParser.expressionWithoutAngleBrackets"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpressionWithoutAngleBrackets([NotNull] MoaiCppParser.ExpressionWithoutAngleBracketsContext context);
}
} // namespace CppParser