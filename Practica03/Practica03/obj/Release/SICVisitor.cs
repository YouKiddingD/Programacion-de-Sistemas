//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\DELL\Documents\Lap Work\U\Programacion de Sistemas\Practicas\Programacion-de-Sistemas\Practica03\Practica03\SIC.g4 by ANTLR 4.6.6

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace Practica03 {
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="SICParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public interface ISICVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="SICParser.go"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitGo([NotNull] SICParser.GoContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SICParser.inicio"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitInicio([NotNull] SICParser.InicioContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SICParser.fin"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFin([NotNull] SICParser.FinContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SICParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExpr([NotNull] SICParser.ExprContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SICParser.checarInstruExt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitChecarInstruExt([NotNull] SICParser.ChecarInstruExtContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SICParser.checarOPF2"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitChecarOPF2([NotNull] SICParser.ChecarOPF2Context context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SICParser.checarINIT"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitChecarINIT([NotNull] SICParser.ChecarINITContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SICParser.checarACABA"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitChecarACABA([NotNull] SICParser.ChecarACABAContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SICParser.checarOpbyte"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitChecarOpbyte([NotNull] SICParser.ChecarOpbyteContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SICParser.checarByte"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitChecarByte([NotNull] SICParser.ChecarByteContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SICParser.checarRsub"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitChecarRsub([NotNull] SICParser.ChecarRsubContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SICParser.checarOpSTART"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitChecarOpSTART([NotNull] SICParser.ChecarOpSTARTContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SICParser.checarOp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitChecarOp([NotNull] SICParser.ChecarOpContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SICParser.checarOpEND"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitChecarOpEND([NotNull] SICParser.ChecarOpENDContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SICParser.checarDirec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitChecarDirec([NotNull] SICParser.ChecarDirecContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SICParser.casoDirec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCasoDirec([NotNull] SICParser.CasoDirecContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SICParser.checarEtiq"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitChecarEtiq([NotNull] SICParser.ChecarEtiqContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SICParser.checarInstru"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitChecarInstru([NotNull] SICParser.ChecarInstruContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SICParser.checarOPExt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitChecarOPExt([NotNull] SICParser.ChecarOPExtContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SICParser.checarOPF3"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitChecarOPF3([NotNull] SICParser.ChecarOPF3Context context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SICParser.compileUnit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCompileUnit([NotNull] SICParser.CompileUnitContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SICParser.updateCPInst"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitUpdateCPInst([NotNull] SICParser.UpdateCPInstContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SICParser.updateLine"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitUpdateLine([NotNull] SICParser.UpdateLineContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="SICParser.updateCPByte"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitUpdateCPByte([NotNull] SICParser.UpdateCPByteContext context);
}
} // namespace Practica03
