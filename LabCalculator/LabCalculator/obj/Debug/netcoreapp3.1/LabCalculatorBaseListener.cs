﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\Klan\source\repos\LabCalculator\LabCalculator\LabCalculator.g4 by ANTLR 4.6.6

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace LabCalculator {

using Antlr4.Runtime.Misc;
using IErrorNode = Antlr4.Runtime.Tree.IErrorNode;
using ITerminalNode = Antlr4.Runtime.Tree.ITerminalNode;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="ILabCalculatorListener"/>,
/// which can be extended to create a listener which only needs to handle a subset
/// of the available methods.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public partial class LabCalculatorBaseListener : ILabCalculatorListener {
	/// <summary>
	/// Enter a parse tree produced by the <c>ParenthesizedExpr</c>
	/// labeled alternative in <see cref="LabCalculatorParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterParenthesizedExpr([NotNull] LabCalculatorParser.ParenthesizedExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ParenthesizedExpr</c>
	/// labeled alternative in <see cref="LabCalculatorParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitParenthesizedExpr([NotNull] LabCalculatorParser.ParenthesizedExprContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>ExponentialExpr</c>
	/// labeled alternative in <see cref="LabCalculatorParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExponentialExpr([NotNull] LabCalculatorParser.ExponentialExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ExponentialExpr</c>
	/// labeled alternative in <see cref="LabCalculatorParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExponentialExpr([NotNull] LabCalculatorParser.ExponentialExprContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>MultiplicativeExpr</c>
	/// labeled alternative in <see cref="LabCalculatorParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMultiplicativeExpr([NotNull] LabCalculatorParser.MultiplicativeExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>MultiplicativeExpr</c>
	/// labeled alternative in <see cref="LabCalculatorParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMultiplicativeExpr([NotNull] LabCalculatorParser.MultiplicativeExprContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>AdditiveExpr</c>
	/// labeled alternative in <see cref="LabCalculatorParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAdditiveExpr([NotNull] LabCalculatorParser.AdditiveExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>AdditiveExpr</c>
	/// labeled alternative in <see cref="LabCalculatorParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAdditiveExpr([NotNull] LabCalculatorParser.AdditiveExprContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>ModDivExpr</c>
	/// labeled alternative in <see cref="LabCalculatorParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterModDivExpr([NotNull] LabCalculatorParser.ModDivExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ModDivExpr</c>
	/// labeled alternative in <see cref="LabCalculatorParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitModDivExpr([NotNull] LabCalculatorParser.ModDivExprContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>NumberExpr</c>
	/// labeled alternative in <see cref="LabCalculatorParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNumberExpr([NotNull] LabCalculatorParser.NumberExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>NumberExpr</c>
	/// labeled alternative in <see cref="LabCalculatorParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNumberExpr([NotNull] LabCalculatorParser.NumberExprContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>IdentifierExpr</c>
	/// labeled alternative in <see cref="LabCalculatorParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIdentifierExpr([NotNull] LabCalculatorParser.IdentifierExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>IdentifierExpr</c>
	/// labeled alternative in <see cref="LabCalculatorParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIdentifierExpr([NotNull] LabCalculatorParser.IdentifierExprContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="LabCalculatorParser.compileUnit"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCompileUnit([NotNull] LabCalculatorParser.CompileUnitContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="LabCalculatorParser.compileUnit"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCompileUnit([NotNull] LabCalculatorParser.CompileUnitContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="LabCalculatorParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExpression([NotNull] LabCalculatorParser.ExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="LabCalculatorParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExpression([NotNull] LabCalculatorParser.ExpressionContext context) { }

	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void EnterEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void ExitEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitTerminal([NotNull] ITerminalNode node) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitErrorNode([NotNull] IErrorNode node) { }
}
} // namespace LabCalculator
