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
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="SICParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public interface ISICListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="SICParser.go"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGo([NotNull] SICParser.GoContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SICParser.go"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGo([NotNull] SICParser.GoContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SICParser.inicio"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInicio([NotNull] SICParser.InicioContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SICParser.inicio"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInicio([NotNull] SICParser.InicioContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SICParser.fin"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFin([NotNull] SICParser.FinContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SICParser.fin"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFin([NotNull] SICParser.FinContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SICParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpr([NotNull] SICParser.ExprContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SICParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpr([NotNull] SICParser.ExprContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SICParser.checarINIT"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterChecarINIT([NotNull] SICParser.ChecarINITContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SICParser.checarINIT"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitChecarINIT([NotNull] SICParser.ChecarINITContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SICParser.checarACABA"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterChecarACABA([NotNull] SICParser.ChecarACABAContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SICParser.checarACABA"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitChecarACABA([NotNull] SICParser.ChecarACABAContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SICParser.checarOpbyte"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterChecarOpbyte([NotNull] SICParser.ChecarOpbyteContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SICParser.checarOpbyte"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitChecarOpbyte([NotNull] SICParser.ChecarOpbyteContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SICParser.checarByte"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterChecarByte([NotNull] SICParser.ChecarByteContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SICParser.checarByte"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitChecarByte([NotNull] SICParser.ChecarByteContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SICParser.checarRsub"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterChecarRsub([NotNull] SICParser.ChecarRsubContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SICParser.checarRsub"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitChecarRsub([NotNull] SICParser.ChecarRsubContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SICParser.checarOpSTART"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterChecarOpSTART([NotNull] SICParser.ChecarOpSTARTContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SICParser.checarOpSTART"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitChecarOpSTART([NotNull] SICParser.ChecarOpSTARTContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SICParser.checarOp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterChecarOp([NotNull] SICParser.ChecarOpContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SICParser.checarOp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitChecarOp([NotNull] SICParser.ChecarOpContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SICParser.checarOpEND"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterChecarOpEND([NotNull] SICParser.ChecarOpENDContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SICParser.checarOpEND"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitChecarOpEND([NotNull] SICParser.ChecarOpENDContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SICParser.checarDirec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterChecarDirec([NotNull] SICParser.ChecarDirecContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SICParser.checarDirec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitChecarDirec([NotNull] SICParser.ChecarDirecContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SICParser.casoDirec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCasoDirec([NotNull] SICParser.CasoDirecContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SICParser.casoDirec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCasoDirec([NotNull] SICParser.CasoDirecContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SICParser.checarEtiq"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterChecarEtiq([NotNull] SICParser.ChecarEtiqContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SICParser.checarEtiq"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitChecarEtiq([NotNull] SICParser.ChecarEtiqContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SICParser.checarInstru"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterChecarInstru([NotNull] SICParser.ChecarInstruContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SICParser.checarInstru"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitChecarInstru([NotNull] SICParser.ChecarInstruContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SICParser.compileUnit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCompileUnit([NotNull] SICParser.CompileUnitContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SICParser.compileUnit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCompileUnit([NotNull] SICParser.CompileUnitContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SICParser.updateCPInst"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUpdateCPInst([NotNull] SICParser.UpdateCPInstContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SICParser.updateCPInst"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUpdateCPInst([NotNull] SICParser.UpdateCPInstContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SICParser.updateLine"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUpdateLine([NotNull] SICParser.UpdateLineContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SICParser.updateLine"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUpdateLine([NotNull] SICParser.UpdateLineContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SICParser.updateCPByte"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUpdateCPByte([NotNull] SICParser.UpdateCPByteContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SICParser.updateCPByte"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUpdateCPByte([NotNull] SICParser.UpdateCPByteContext context);
}
} // namespace Practica03
