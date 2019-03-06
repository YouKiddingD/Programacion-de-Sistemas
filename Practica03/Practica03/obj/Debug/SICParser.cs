//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\Mildred Sifuentes\Downloads\U\Programacion de Sistemas\Practicas\Programacion-de-Sistemas\Practica03\Practica03\SIC.g4 by ANTLR 4.6.6

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace Practica03 {
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using System.Collections.Generic;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public partial class SICParser : Parser {
	public const int
		INIT=1, ACABA=2, DIRBYTE=3, OPERANDBYTE=4, DIRECTIVA=5, EXEP=6, INSTRUCCION=7, 
		OPERANDO=8, ETIQUETA=9, ENTER=10, QUOTE=11, WS=12;
	public const int
		RULE_go = 0, RULE_inicio = 1, RULE_fin = 2, RULE_expr = 3, RULE_checarOpbyte = 4, 
		RULE_checarByte = 5, RULE_checarRsub = 6, RULE_checarOp = 7, RULE_checarDirec = 8, 
		RULE_checarEtiq = 9, RULE_checarInstru = 10, RULE_compileUnit = 11, RULE_updateCPInst = 12, 
		RULE_updateCPByte = 13;
	public static readonly string[] ruleNames = {
		"go", "inicio", "fin", "expr", "checarOpbyte", "checarByte", "checarRsub", 
		"checarOp", "checarDirec", "checarEtiq", "checarInstru", "compileUnit", 
		"updateCPInst", "updateCPByte"
	};

	private static readonly string[] _LiteralNames = {
		null, null, null, null, null, null, null, null, null, null, "'\n'", "'''"
	};
	private static readonly string[] _SymbolicNames = {
		null, "INIT", "ACABA", "DIRBYTE", "OPERANDBYTE", "DIRECTIVA", "EXEP", 
		"INSTRUCCION", "OPERANDO", "ETIQUETA", "ENTER", "QUOTE", "WS"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[System.Obsolete("Use Vocabulary instead.")]
	public static readonly string[] tokenNames = GenerateTokenNames(DefaultVocabulary, _SymbolicNames.Length);

	private static string[] GenerateTokenNames(IVocabulary vocabulary, int length) {
		string[] tokenNames = new string[length];
		for (int i = 0; i < tokenNames.Length; i++) {
			tokenNames[i] = vocabulary.GetLiteralName(i);
			if (tokenNames[i] == null) {
				tokenNames[i] = vocabulary.GetSymbolicName(i);
			}

			if (tokenNames[i] == null) {
				tokenNames[i] = "<INVALID>";
			}
		}

		return tokenNames;
	}

	[System.Obsolete("Use IRecognizer.Vocabulary instead.")]
	public override string[] TokenNames
	{
		get
		{
			return tokenNames;
		}
	}

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "SIC.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string SerializedAtn { get { return _serializedATN; } }


		int i=1;
		string ruta = "";
		int CP;
		
	public SICParser(ITokenStream input)
		: base(input)
	{
		_interp = new ParserATNSimulator(this,_ATN);
	}
	public partial class GoContext : ParserRuleContext {
		public string val;
		public int dirIni;
		public InicioContext inicio() {
			return GetRuleContext<InicioContext>(0);
		}
		public FinContext fin() {
			return GetRuleContext<FinContext>(0);
		}
		public ExprContext[] expr() {
			return GetRuleContexts<ExprContext>();
		}
		public ExprContext expr(int i) {
			return GetRuleContext<ExprContext>(i);
		}
		public GoContext(ParserRuleContext parent, int invokingState) : base(parent, invokingState) { }
		public GoContext(ParserRuleContext parent, int invokingState, string val, int dirIni)
			: base(parent, invokingState)
		{
			this.val = val;
			this.dirIni = dirIni;
		}
		public override int RuleIndex { get { return RULE_go; } }
		public override void EnterRule(IParseTreeListener listener) {
			ISICListener typedListener = listener as ISICListener;
			if (typedListener != null) typedListener.EnterGo(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ISICListener typedListener = listener as ISICListener;
			if (typedListener != null) typedListener.ExitGo(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ISICVisitor<TResult> typedVisitor = visitor as ISICVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitGo(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public GoContext go(string val, int dirIni) {
		GoContext _localctx = new GoContext(_ctx, State, val, dirIni);
		EnterRule(_localctx, 0, RULE_go);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			ruta=val; CP=dirIni;
			State = 29; inicio();
			State = 33;
			_errHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(_input,0,_ctx);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.InvalidAltNumber ) {
				if ( _alt==1 ) {
					{
					{
					State = 30; expr();
					}
					} 
				}
				State = 35;
				_errHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(_input,0,_ctx);
			}
			State = 36; fin();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class InicioContext : ParserRuleContext {
		public ChecarEtiqContext checarEtiq() {
			return GetRuleContext<ChecarEtiqContext>(0);
		}
		public ITerminalNode INIT() { return GetToken(SICParser.INIT, 0); }
		public ChecarOpContext checarOp() {
			return GetRuleContext<ChecarOpContext>(0);
		}
		public ITerminalNode ENTER() { return GetToken(SICParser.ENTER, 0); }
		public InicioContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_inicio; } }
		public override void EnterRule(IParseTreeListener listener) {
			ISICListener typedListener = listener as ISICListener;
			if (typedListener != null) typedListener.EnterInicio(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ISICListener typedListener = listener as ISICListener;
			if (typedListener != null) typedListener.ExitInicio(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ISICVisitor<TResult> typedVisitor = visitor as ISICVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitInicio(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public InicioContext inicio() {
		InicioContext _localctx = new InicioContext(_ctx, State);
		EnterRule(_localctx, 2, RULE_inicio);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 38; checarEtiq();
			State = 39; Match(INIT);
			State = 40; checarOp();
			State = 41; Match(ENTER);
			i++;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class FinContext : ParserRuleContext {
		public ChecarEtiqContext checarEtiq() {
			return GetRuleContext<ChecarEtiqContext>(0);
		}
		public ITerminalNode ACABA() { return GetToken(SICParser.ACABA, 0); }
		public ChecarOpContext checarOp() {
			return GetRuleContext<ChecarOpContext>(0);
		}
		public ITerminalNode ENTER() { return GetToken(SICParser.ENTER, 0); }
		public FinContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_fin; } }
		public override void EnterRule(IParseTreeListener listener) {
			ISICListener typedListener = listener as ISICListener;
			if (typedListener != null) typedListener.EnterFin(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ISICListener typedListener = listener as ISICListener;
			if (typedListener != null) typedListener.ExitFin(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ISICVisitor<TResult> typedVisitor = visitor as ISICVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitFin(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public FinContext fin() {
		FinContext _localctx = new FinContext(_ctx, State);
		EnterRule(_localctx, 4, RULE_fin);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 44; checarEtiq();
			State = 45; Match(ACABA);
			State = 46; checarOp();
			State = 47; Match(ENTER);
			i++;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ExprContext : ParserRuleContext {
		public ChecarEtiqContext checarEtiq() {
			return GetRuleContext<ChecarEtiqContext>(0);
		}
		public ChecarInstruContext checarInstru() {
			return GetRuleContext<ChecarInstruContext>(0);
		}
		public ChecarOpContext checarOp() {
			return GetRuleContext<ChecarOpContext>(0);
		}
		public UpdateCPInstContext updateCPInst() {
			return GetRuleContext<UpdateCPInstContext>(0);
		}
		public ITerminalNode ENTER() { return GetToken(SICParser.ENTER, 0); }
		public ChecarRsubContext checarRsub() {
			return GetRuleContext<ChecarRsubContext>(0);
		}
		public ChecarDirecContext checarDirec() {
			return GetRuleContext<ChecarDirecContext>(0);
		}
		public ChecarByteContext checarByte() {
			return GetRuleContext<ChecarByteContext>(0);
		}
		public ChecarOpbyteContext checarOpbyte() {
			return GetRuleContext<ChecarOpbyteContext>(0);
		}
		public UpdateCPByteContext updateCPByte() {
			return GetRuleContext<UpdateCPByteContext>(0);
		}
		public ExprContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_expr; } }
		public override void EnterRule(IParseTreeListener listener) {
			ISICListener typedListener = listener as ISICListener;
			if (typedListener != null) typedListener.EnterExpr(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ISICListener typedListener = listener as ISICListener;
			if (typedListener != null) typedListener.ExitExpr(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ISICVisitor<TResult> typedVisitor = visitor as ISICVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitExpr(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ExprContext expr() {
		ExprContext _localctx = new ExprContext(_ctx, State);
		EnterRule(_localctx, 6, RULE_expr);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 72;
			_errHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(_input,1,_ctx) ) {
			case 1:
				{
				State = 50; checarEtiq();
				State = 51; checarInstru();
				State = 52; checarOp();
				State = 53; updateCPInst();
				State = 54; Match(ENTER);
				}
				break;

			case 2:
				{
				State = 56; checarEtiq();
				State = 57; checarRsub();
				State = 58; updateCPInst();
				State = 59; Match(ENTER);
				}
				break;

			case 3:
				{
				State = 61; checarEtiq();
				State = 62; checarDirec();
				State = 63; checarOp();
				State = 64; Match(ENTER);
				}
				break;

			case 4:
				{
				State = 66; checarEtiq();
				State = 67; checarByte();
				State = 68; checarOpbyte();
				State = 69; updateCPByte();
				State = 70; Match(ENTER);
				}
				break;
			}
			i++;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ChecarOpbyteContext : ParserRuleContext {
		public ITerminalNode OPERANDBYTE() { return GetToken(SICParser.OPERANDBYTE, 0); }
		public ChecarOpbyteContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_checarOpbyte; } }
		public override void EnterRule(IParseTreeListener listener) {
			ISICListener typedListener = listener as ISICListener;
			if (typedListener != null) typedListener.EnterChecarOpbyte(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ISICListener typedListener = listener as ISICListener;
			if (typedListener != null) typedListener.ExitChecarOpbyte(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ISICVisitor<TResult> typedVisitor = visitor as ISICVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitChecarOpbyte(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ChecarOpbyteContext checarOpbyte() {
		ChecarOpbyteContext _localctx = new ChecarOpbyteContext(_ctx, State);
		EnterRule(_localctx, 8, RULE_checarOpbyte);
		int _la;
		try {
			State = 79;
			_errHandler.Sync(this);
			switch (_input.La(1)) {
			case INIT:
			case ACABA:
			case DIRBYTE:
			case DIRECTIVA:
			case EXEP:
			case INSTRUCCION:
			case OPERANDO:
			case ETIQUETA:
			case ENTER:
			case QUOTE:
			case WS:
				EnterOuterAlt(_localctx, 1);
				{
				State = 76;
				_la = _input.La(1);
				if ( _la <= 0 || (_la==OPERANDBYTE) ) {
				_errHandler.RecoverInline(this);
				} else {
					if (_input.La(1) == TokenConstants.Eof) {
						matchedEOF = true;
					}

					_errHandler.ReportMatch(this);
					Consume();
				}
				using (System.IO.StreamWriter file = new System.IO.StreamWriter(@ruta, true)){ file.WriteLine("Error OPBYTE en la linea: " + i);}
				}
				break;
			case OPERANDBYTE:
				EnterOuterAlt(_localctx, 2);
				{
				State = 78; Match(OPERANDBYTE);
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ChecarByteContext : ParserRuleContext {
		public ITerminalNode DIRBYTE() { return GetToken(SICParser.DIRBYTE, 0); }
		public ChecarByteContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_checarByte; } }
		public override void EnterRule(IParseTreeListener listener) {
			ISICListener typedListener = listener as ISICListener;
			if (typedListener != null) typedListener.EnterChecarByte(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ISICListener typedListener = listener as ISICListener;
			if (typedListener != null) typedListener.ExitChecarByte(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ISICVisitor<TResult> typedVisitor = visitor as ISICVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitChecarByte(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ChecarByteContext checarByte() {
		ChecarByteContext _localctx = new ChecarByteContext(_ctx, State);
		EnterRule(_localctx, 10, RULE_checarByte);
		int _la;
		try {
			State = 84;
			_errHandler.Sync(this);
			switch (_input.La(1)) {
			case INIT:
			case ACABA:
			case OPERANDBYTE:
			case DIRECTIVA:
			case EXEP:
			case INSTRUCCION:
			case OPERANDO:
			case ETIQUETA:
			case ENTER:
			case QUOTE:
			case WS:
				EnterOuterAlt(_localctx, 1);
				{
				State = 81;
				_la = _input.La(1);
				if ( _la <= 0 || (_la==DIRBYTE) ) {
				_errHandler.RecoverInline(this);
				} else {
					if (_input.La(1) == TokenConstants.Eof) {
						matchedEOF = true;
					}

					_errHandler.ReportMatch(this);
					Consume();
				}
				using (System.IO.StreamWriter file = new System.IO.StreamWriter(@ruta, true)){ file.WriteLine("Error BYTE en la linea: " + i);}
				}
				break;
			case DIRBYTE:
				EnterOuterAlt(_localctx, 2);
				{
				State = 83; Match(DIRBYTE);
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ChecarRsubContext : ParserRuleContext {
		public ITerminalNode EXEP() { return GetToken(SICParser.EXEP, 0); }
		public ChecarRsubContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_checarRsub; } }
		public override void EnterRule(IParseTreeListener listener) {
			ISICListener typedListener = listener as ISICListener;
			if (typedListener != null) typedListener.EnterChecarRsub(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ISICListener typedListener = listener as ISICListener;
			if (typedListener != null) typedListener.ExitChecarRsub(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ISICVisitor<TResult> typedVisitor = visitor as ISICVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitChecarRsub(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ChecarRsubContext checarRsub() {
		ChecarRsubContext _localctx = new ChecarRsubContext(_ctx, State);
		EnterRule(_localctx, 12, RULE_checarRsub);
		int _la;
		try {
			State = 89;
			_errHandler.Sync(this);
			switch (_input.La(1)) {
			case INIT:
			case ACABA:
			case DIRBYTE:
			case OPERANDBYTE:
			case DIRECTIVA:
			case INSTRUCCION:
			case OPERANDO:
			case ETIQUETA:
			case ENTER:
			case QUOTE:
			case WS:
				EnterOuterAlt(_localctx, 1);
				{
				State = 86;
				_la = _input.La(1);
				if ( _la <= 0 || (_la==EXEP) ) {
				_errHandler.RecoverInline(this);
				} else {
					if (_input.La(1) == TokenConstants.Eof) {
						matchedEOF = true;
					}

					_errHandler.ReportMatch(this);
					Consume();
				}
				using (System.IO.StreamWriter file = new System.IO.StreamWriter(@ruta, true)){ file.WriteLine("Error RSUB en la linea: " + i);}
				}
				break;
			case EXEP:
				EnterOuterAlt(_localctx, 2);
				{
				State = 88; Match(EXEP);
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ChecarOpContext : ParserRuleContext {
		public ITerminalNode OPERANDO() { return GetToken(SICParser.OPERANDO, 0); }
		public ChecarEtiqContext checarEtiq() {
			return GetRuleContext<ChecarEtiqContext>(0);
		}
		public ChecarOpContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_checarOp; } }
		public override void EnterRule(IParseTreeListener listener) {
			ISICListener typedListener = listener as ISICListener;
			if (typedListener != null) typedListener.EnterChecarOp(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ISICListener typedListener = listener as ISICListener;
			if (typedListener != null) typedListener.ExitChecarOp(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ISICVisitor<TResult> typedVisitor = visitor as ISICVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitChecarOp(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ChecarOpContext checarOp() {
		ChecarOpContext _localctx = new ChecarOpContext(_ctx, State);
		EnterRule(_localctx, 14, RULE_checarOp);
		int _la;
		try {
			State = 94;
			_errHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(_input,5,_ctx) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 91;
				_la = _input.La(1);
				if ( _la <= 0 || (_la==OPERANDO) ) {
				_errHandler.RecoverInline(this);
				} else {
					if (_input.La(1) == TokenConstants.Eof) {
						matchedEOF = true;
					}

					_errHandler.ReportMatch(this);
					Consume();
				}
				}
				break;

			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 92; Match(OPERANDO);
				}
				break;

			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 93; checarEtiq();
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ChecarDirecContext : ParserRuleContext {
		public ChecarByteContext checarByte() {
			return GetRuleContext<ChecarByteContext>(0);
		}
		public ITerminalNode DIRECTIVA() { return GetToken(SICParser.DIRECTIVA, 0); }
		public ChecarDirecContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_checarDirec; } }
		public override void EnterRule(IParseTreeListener listener) {
			ISICListener typedListener = listener as ISICListener;
			if (typedListener != null) typedListener.EnterChecarDirec(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ISICListener typedListener = listener as ISICListener;
			if (typedListener != null) typedListener.ExitChecarDirec(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ISICVisitor<TResult> typedVisitor = visitor as ISICVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitChecarDirec(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ChecarDirecContext checarDirec() {
		ChecarDirecContext _localctx = new ChecarDirecContext(_ctx, State);
		EnterRule(_localctx, 16, RULE_checarDirec);
		int _la;
		try {
			State = 99;
			_errHandler.Sync(this);
			switch (_input.La(1)) {
			case INIT:
			case ACABA:
			case DIRBYTE:
			case OPERANDBYTE:
			case EXEP:
			case INSTRUCCION:
			case OPERANDO:
			case ETIQUETA:
			case ENTER:
			case QUOTE:
			case WS:
				EnterOuterAlt(_localctx, 1);
				{
				State = 96;
				_la = _input.La(1);
				if ( _la <= 0 || (_la==DIRECTIVA) ) {
				_errHandler.RecoverInline(this);
				} else {
					if (_input.La(1) == TokenConstants.Eof) {
						matchedEOF = true;
					}

					_errHandler.ReportMatch(this);
					Consume();
				}
				State = 97; checarByte();
				}
				break;
			case DIRECTIVA:
				EnterOuterAlt(_localctx, 2);
				{
				State = 98; Match(DIRECTIVA);
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ChecarEtiqContext : ParserRuleContext {
		public ITerminalNode ETIQUETA() { return GetToken(SICParser.ETIQUETA, 0); }
		public ChecarEtiqContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_checarEtiq; } }
		public override void EnterRule(IParseTreeListener listener) {
			ISICListener typedListener = listener as ISICListener;
			if (typedListener != null) typedListener.EnterChecarEtiq(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ISICListener typedListener = listener as ISICListener;
			if (typedListener != null) typedListener.ExitChecarEtiq(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ISICVisitor<TResult> typedVisitor = visitor as ISICVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitChecarEtiq(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ChecarEtiqContext checarEtiq() {
		ChecarEtiqContext _localctx = new ChecarEtiqContext(_ctx, State);
		EnterRule(_localctx, 18, RULE_checarEtiq);
		int _la;
		try {
			State = 104;
			_errHandler.Sync(this);
			switch (_input.La(1)) {
			case INIT:
			case ACABA:
			case DIRBYTE:
			case OPERANDBYTE:
			case DIRECTIVA:
			case EXEP:
			case INSTRUCCION:
			case OPERANDO:
			case ENTER:
			case QUOTE:
			case WS:
				EnterOuterAlt(_localctx, 1);
				{
				State = 101;
				_la = _input.La(1);
				if ( _la <= 0 || (_la==ETIQUETA) ) {
				_errHandler.RecoverInline(this);
				} else {
					if (_input.La(1) == TokenConstants.Eof) {
						matchedEOF = true;
					}

					_errHandler.ReportMatch(this);
					Consume();
				}
				using (System.IO.StreamWriter file = new System.IO.StreamWriter(@ruta, true)){ file.WriteLine("Error ETIQUETA en la linea: " + i);}
				}
				break;
			case ETIQUETA:
				EnterOuterAlt(_localctx, 2);
				{
				State = 103; Match(ETIQUETA);
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ChecarInstruContext : ParserRuleContext {
		public ChecarDirecContext checarDirec() {
			return GetRuleContext<ChecarDirecContext>(0);
		}
		public ITerminalNode INSTRUCCION() { return GetToken(SICParser.INSTRUCCION, 0); }
		public ChecarInstruContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_checarInstru; } }
		public override void EnterRule(IParseTreeListener listener) {
			ISICListener typedListener = listener as ISICListener;
			if (typedListener != null) typedListener.EnterChecarInstru(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ISICListener typedListener = listener as ISICListener;
			if (typedListener != null) typedListener.ExitChecarInstru(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ISICVisitor<TResult> typedVisitor = visitor as ISICVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitChecarInstru(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ChecarInstruContext checarInstru() {
		ChecarInstruContext _localctx = new ChecarInstruContext(_ctx, State);
		EnterRule(_localctx, 20, RULE_checarInstru);
		int _la;
		try {
			State = 109;
			_errHandler.Sync(this);
			switch (_input.La(1)) {
			case INIT:
			case ACABA:
			case DIRBYTE:
			case OPERANDBYTE:
			case DIRECTIVA:
			case EXEP:
			case OPERANDO:
			case ETIQUETA:
			case ENTER:
			case QUOTE:
			case WS:
				EnterOuterAlt(_localctx, 1);
				{
				State = 106;
				_la = _input.La(1);
				if ( _la <= 0 || (_la==INSTRUCCION) ) {
				_errHandler.RecoverInline(this);
				} else {
					if (_input.La(1) == TokenConstants.Eof) {
						matchedEOF = true;
					}

					_errHandler.ReportMatch(this);
					Consume();
				}
				State = 107; checarDirec();
				}
				break;
			case INSTRUCCION:
				EnterOuterAlt(_localctx, 2);
				{
				State = 108; Match(INSTRUCCION);
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class CompileUnitContext : ParserRuleContext {
		public ExprContext expr() {
			return GetRuleContext<ExprContext>(0);
		}
		public ITerminalNode Eof() { return GetToken(SICParser.Eof, 0); }
		public CompileUnitContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_compileUnit; } }
		public override void EnterRule(IParseTreeListener listener) {
			ISICListener typedListener = listener as ISICListener;
			if (typedListener != null) typedListener.EnterCompileUnit(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ISICListener typedListener = listener as ISICListener;
			if (typedListener != null) typedListener.ExitCompileUnit(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ISICVisitor<TResult> typedVisitor = visitor as ISICVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitCompileUnit(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public CompileUnitContext compileUnit() {
		CompileUnitContext _localctx = new CompileUnitContext(_ctx, State);
		EnterRule(_localctx, 22, RULE_compileUnit);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 111; expr();
			State = 112; Match(Eof);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class UpdateCPInstContext : ParserRuleContext {
		public UpdateCPInstContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_updateCPInst; } }
		public override void EnterRule(IParseTreeListener listener) {
			ISICListener typedListener = listener as ISICListener;
			if (typedListener != null) typedListener.EnterUpdateCPInst(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ISICListener typedListener = listener as ISICListener;
			if (typedListener != null) typedListener.ExitUpdateCPInst(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ISICVisitor<TResult> typedVisitor = visitor as ISICVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitUpdateCPInst(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public UpdateCPInstContext updateCPInst() {
		UpdateCPInstContext _localctx = new UpdateCPInstContext(_ctx, State);
		EnterRule(_localctx, 24, RULE_updateCPInst);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			CP+=3;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class UpdateCPByteContext : ParserRuleContext {
		public UpdateCPByteContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_updateCPByte; } }
		public override void EnterRule(IParseTreeListener listener) {
			ISICListener typedListener = listener as ISICListener;
			if (typedListener != null) typedListener.EnterUpdateCPByte(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ISICListener typedListener = listener as ISICListener;
			if (typedListener != null) typedListener.ExitUpdateCPByte(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ISICVisitor<TResult> typedVisitor = visitor as ISICVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitUpdateCPByte(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public UpdateCPByteContext updateCPByte() {
		UpdateCPByteContext _localctx = new UpdateCPByteContext(_ctx, State);
		EnterRule(_localctx, 26, RULE_updateCPByte);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public static readonly string _serializedATN =
		"\x3\xAF6F\x8320\x479D\xB75C\x4880\x1605\x191C\xAB37\x3\xEy\x4\x2\t\x2"+
		"\x4\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x4\x6\t\x6\x4\a\t\a\x4\b\t\b\x4\t\t"+
		"\t\x4\n\t\n\x4\v\t\v\x4\f\t\f\x4\r\t\r\x4\xE\t\xE\x4\xF\t\xF\x3\x2\x3"+
		"\x2\x3\x2\a\x2\"\n\x2\f\x2\xE\x2%\v\x2\x3\x2\x3\x2\x3\x3\x3\x3\x3\x3\x3"+
		"\x3\x3\x3\x3\x3\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x5\x3\x5\x3\x5"+
		"\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3"+
		"\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x5\x5K\n\x5\x3\x5\x3\x5"+
		"\x3\x6\x3\x6\x3\x6\x5\x6R\n\x6\x3\a\x3\a\x3\a\x5\aW\n\a\x3\b\x3\b\x3\b"+
		"\x5\b\\\n\b\x3\t\x3\t\x3\t\x5\t\x61\n\t\x3\n\x3\n\x3\n\x5\n\x66\n\n\x3"+
		"\v\x3\v\x3\v\x5\vk\n\v\x3\f\x3\f\x3\f\x5\fp\n\f\x3\r\x3\r\x3\r\x3\xE\x3"+
		"\xE\x3\xF\x3\xF\x3\xF\x2\x2\x2\x10\x2\x2\x4\x2\x6\x2\b\x2\n\x2\f\x2\xE"+
		"\x2\x10\x2\x12\x2\x14\x2\x16\x2\x18\x2\x1A\x2\x1C\x2\x2\t\x3\x2\x6\x6"+
		"\x3\x2\x5\x5\x3\x2\b\b\x3\x2\n\n\x3\x2\a\a\x3\x2\v\v\x3\x2\t\tv\x2\x1E"+
		"\x3\x2\x2\x2\x4(\x3\x2\x2\x2\x6.\x3\x2\x2\x2\bJ\x3\x2\x2\x2\nQ\x3\x2\x2"+
		"\x2\fV\x3\x2\x2\x2\xE[\x3\x2\x2\x2\x10`\x3\x2\x2\x2\x12\x65\x3\x2\x2\x2"+
		"\x14j\x3\x2\x2\x2\x16o\x3\x2\x2\x2\x18q\x3\x2\x2\x2\x1At\x3\x2\x2\x2\x1C"+
		"v\x3\x2\x2\x2\x1E\x1F\b\x2\x1\x2\x1F#\x5\x4\x3\x2 \"\x5\b\x5\x2! \x3\x2"+
		"\x2\x2\"%\x3\x2\x2\x2#!\x3\x2\x2\x2#$\x3\x2\x2\x2$&\x3\x2\x2\x2%#\x3\x2"+
		"\x2\x2&\'\x5\x6\x4\x2\'\x3\x3\x2\x2\x2()\x5\x14\v\x2)*\a\x3\x2\x2*+\x5"+
		"\x10\t\x2+,\a\f\x2\x2,-\b\x3\x1\x2-\x5\x3\x2\x2\x2./\x5\x14\v\x2/\x30"+
		"\a\x4\x2\x2\x30\x31\x5\x10\t\x2\x31\x32\a\f\x2\x2\x32\x33\b\x4\x1\x2\x33"+
		"\a\x3\x2\x2\x2\x34\x35\x5\x14\v\x2\x35\x36\x5\x16\f\x2\x36\x37\x5\x10"+
		"\t\x2\x37\x38\x5\x1A\xE\x2\x38\x39\a\f\x2\x2\x39K\x3\x2\x2\x2:;\x5\x14"+
		"\v\x2;<\x5\xE\b\x2<=\x5\x1A\xE\x2=>\a\f\x2\x2>K\x3\x2\x2\x2?@\x5\x14\v"+
		"\x2@\x41\x5\x12\n\x2\x41\x42\x5\x10\t\x2\x42\x43\a\f\x2\x2\x43K\x3\x2"+
		"\x2\x2\x44\x45\x5\x14\v\x2\x45\x46\x5\f\a\x2\x46G\x5\n\x6\x2GH\x5\x1C"+
		"\xF\x2HI\a\f\x2\x2IK\x3\x2\x2\x2J\x34\x3\x2\x2\x2J:\x3\x2\x2\x2J?\x3\x2"+
		"\x2\x2J\x44\x3\x2\x2\x2KL\x3\x2\x2\x2LM\b\x5\x1\x2M\t\x3\x2\x2\x2NO\n"+
		"\x2\x2\x2OR\b\x6\x1\x2PR\a\x6\x2\x2QN\x3\x2\x2\x2QP\x3\x2\x2\x2R\v\x3"+
		"\x2\x2\x2ST\n\x3\x2\x2TW\b\a\x1\x2UW\a\x5\x2\x2VS\x3\x2\x2\x2VU\x3\x2"+
		"\x2\x2W\r\x3\x2\x2\x2XY\n\x4\x2\x2Y\\\b\b\x1\x2Z\\\a\b\x2\x2[X\x3\x2\x2"+
		"\x2[Z\x3\x2\x2\x2\\\xF\x3\x2\x2\x2]\x61\n\x5\x2\x2^\x61\a\n\x2\x2_\x61"+
		"\x5\x14\v\x2`]\x3\x2\x2\x2`^\x3\x2\x2\x2`_\x3\x2\x2\x2\x61\x11\x3\x2\x2"+
		"\x2\x62\x63\n\x6\x2\x2\x63\x66\x5\f\a\x2\x64\x66\a\a\x2\x2\x65\x62\x3"+
		"\x2\x2\x2\x65\x64\x3\x2\x2\x2\x66\x13\x3\x2\x2\x2gh\n\a\x2\x2hk\b\v\x1"+
		"\x2ik\a\v\x2\x2jg\x3\x2\x2\x2ji\x3\x2\x2\x2k\x15\x3\x2\x2\x2lm\n\b\x2"+
		"\x2mp\x5\x12\n\x2np\a\t\x2\x2ol\x3\x2\x2\x2on\x3\x2\x2\x2p\x17\x3\x2\x2"+
		"\x2qr\x5\b\x5\x2rs\a\x2\x2\x3s\x19\x3\x2\x2\x2tu\b\xE\x1\x2u\x1B\x3\x2"+
		"\x2\x2vw\b\xF\x1\x2w\x1D\x3\x2\x2\x2\v#JQV[`\x65jo";
	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}
} // namespace Practica03
