//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\Mildred Sifuentes\Downloads\U\Programacion de Sistemas\Practicas\Programacion-de-Sistemas\Practica02\Practica02\SIC.g4 by ANTLR 4.6.6

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace Practica02 {
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public partial class SICLexer : Lexer {
	public const int
		INIT=1, ACABA=2, DIRBYTE=3, OPERANDBYTE=4, DIRECTIVA=5, EXEP=6, INSTRUCCION=7, 
		OPERANDO=8, ETIQUETA=9, ENTER=10, QUOTE=11, WS=12;
	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"INIT", "ACABA", "DIRBYTE", "OPERANDBYTE", "DIRECTIVA", "EXEP", "INSTRUCCION", 
		"OPERANDO", "ETIQUETA", "ENTER", "QUOTE", "WS"
	};


	public SICLexer(ICharStream input)
		: base(input)
	{
		_interp = new LexerATNSimulator(this,_ATN);
	}

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

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return _serializedATN; } }

	public static readonly string _serializedATN =
		"\x3\xAF6F\x8320\x479D\xB75C\x4880\x1605\x191C\xAB37\x2\xE\x102\b\x1\x4"+
		"\x2\t\x2\x4\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x4\x6\t\x6\x4\a\t\a\x4\b\t\b"+
		"\x4\t\t\t\x4\n\t\n\x4\v\t\v\x4\f\t\f\x4\r\t\r\x3\x2\x3\x2\x3\x2\x3\x2"+
		"\x3\x2\x3\x2\x3\x2\x5\x2#\n\x2\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x5\x3*\n"+
		"\x3\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x5\x4\x32\n\x4\x3\x5\x3\x5\x3"+
		"\x5\a\x5\x37\n\x5\f\x5\xE\x5:\v\x5\x3\x5\a\x5=\n\x5\f\x5\xE\x5@\v\x5\x3"+
		"\x5\x3\x5\x3\x5\x3\x5\x3\x5\a\x5G\n\x5\f\x5\xE\x5J\v\x5\x3\x5\a\x5M\n"+
		"\x5\f\x5\xE\x5P\v\x5\x3\x5\x3\x5\x5\x5T\n\x5\x3\x6\x3\x6\x3\x6\x3\x6\x3"+
		"\x6\x3\x6\x3\x6\x3\x6\x3\x6\x3\x6\x3\x6\x3\x6\x5\x6\x62\n\x6\x3\x6\x5"+
		"\x6\x65\n\x6\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a\x5\am\n\a\x3\b\x3\b\x3\b\x3"+
		"\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3"+
		"\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3"+
		"\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3"+
		"\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3"+
		"\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3"+
		"\b\x5\b\xB9\n\b\x3\b\x5\b\xBC\n\b\x3\t\x6\t\xBF\n\t\r\t\xE\t\xC0\x3\t"+
		"\x5\t\xC4\n\t\x3\t\x3\t\x3\t\x3\t\x3\t\x5\t\xCB\n\t\x3\t\x6\t\xCE\n\t"+
		"\r\t\xE\t\xCF\x3\t\a\t\xD3\n\t\f\t\xE\t\xD6\v\t\x3\t\x3\t\x3\t\x3\t\x3"+
		"\t\x5\t\xDD\n\t\x5\t\xDF\n\t\x3\n\x6\n\xE2\n\n\r\n\xE\n\xE3\x3\n\a\n\xE7"+
		"\n\n\f\n\xE\n\xEA\v\n\x3\n\x3\n\x3\n\x3\n\x3\n\x5\n\xF1\n\n\x3\n\x5\n"+
		"\xF4\n\n\x3\n\x5\n\xF7\n\n\x3\v\x3\v\x3\f\x3\f\x3\r\x3\r\x5\r\xFF\n\r"+
		"\x3\r\x3\r\x2\x2\x2\xE\x3\x2\x3\x5\x2\x4\a\x2\x5\t\x2\x6\v\x2\a\r\x2\b"+
		"\xF\x2\t\x11\x2\n\x13\x2\v\x15\x2\f\x17\x2\r\x19\x2\xE\x3\x2\a\x3\x2\x32"+
		";\x3\x2\x43\\\x3\x2\x43H\x4\x2JJjj\x4\x2\v\v\xF\xF\x136\x2\x3\x3\x2\x2"+
		"\x2\x2\x5\x3\x2\x2\x2\x2\a\x3\x2\x2\x2\x2\t\x3\x2\x2\x2\x2\v\x3\x2\x2"+
		"\x2\x2\r\x3\x2\x2\x2\x2\xF\x3\x2\x2\x2\x2\x11\x3\x2\x2\x2\x2\x13\x3\x2"+
		"\x2\x2\x2\x15\x3\x2\x2\x2\x2\x17\x3\x2\x2\x2\x2\x19\x3\x2\x2\x2\x3\x1B"+
		"\x3\x2\x2\x2\x5$\x3\x2\x2\x2\a+\x3\x2\x2\x2\tS\x3\x2\x2\x2\v\x61\x3\x2"+
		"\x2\x2\r\x66\x3\x2\x2\x2\xF\xB8\x3\x2\x2\x2\x11\xDE\x3\x2\x2\x2\x13\xF6"+
		"\x3\x2\x2\x2\x15\xF8\x3\x2\x2\x2\x17\xFA\x3\x2\x2\x2\x19\xFE\x3\x2\x2"+
		"\x2\x1B\x1C\aU\x2\x2\x1C\x1D\aV\x2\x2\x1D\x1E\a\x43\x2\x2\x1E\x1F\aT\x2"+
		"\x2\x1F \aV\x2\x2 \"\x3\x2\x2\x2!#\a\v\x2\x2\"!\x3\x2\x2\x2\"#\x3\x2\x2"+
		"\x2#\x4\x3\x2\x2\x2$%\aG\x2\x2%&\aP\x2\x2&\'\a\x46\x2\x2\')\x3\x2\x2\x2"+
		"(*\a\v\x2\x2)(\x3\x2\x2\x2)*\x3\x2\x2\x2*\x6\x3\x2\x2\x2+,\a\x44\x2\x2"+
		",-\a[\x2\x2-.\aV\x2\x2./\aG\x2\x2/\x31\x3\x2\x2\x2\x30\x32\a\v\x2\x2\x31"+
		"\x30\x3\x2\x2\x2\x31\x32\x3\x2\x2\x2\x32\b\x3\x2\x2\x2\x33\x34\a\x45\x2"+
		"\x2\x34\x38\x5\x17\f\x2\x35\x37\t\x2\x2\x2\x36\x35\x3\x2\x2\x2\x37:\x3"+
		"\x2\x2\x2\x38\x36\x3\x2\x2\x2\x38\x39\x3\x2\x2\x2\x39>\x3\x2\x2\x2:\x38"+
		"\x3\x2\x2\x2;=\t\x3\x2\x2<;\x3\x2\x2\x2=@\x3\x2\x2\x2><\x3\x2\x2\x2>?"+
		"\x3\x2\x2\x2?\x41\x3\x2\x2\x2@>\x3\x2\x2\x2\x41\x42\x5\x17\f\x2\x42T\x3"+
		"\x2\x2\x2\x43\x44\aZ\x2\x2\x44H\x5\x17\f\x2\x45G\t\x2\x2\x2\x46\x45\x3"+
		"\x2\x2\x2GJ\x3\x2\x2\x2H\x46\x3\x2\x2\x2HI\x3\x2\x2\x2IN\x3\x2\x2\x2J"+
		"H\x3\x2\x2\x2KM\t\x4\x2\x2LK\x3\x2\x2\x2MP\x3\x2\x2\x2NL\x3\x2\x2\x2N"+
		"O\x3\x2\x2\x2OQ\x3\x2\x2\x2PN\x3\x2\x2\x2QR\x5\x17\f\x2RT\x3\x2\x2\x2"+
		"S\x33\x3\x2\x2\x2S\x43\x3\x2\x2\x2T\n\x3\x2\x2\x2UV\aY\x2\x2VW\aQ\x2\x2"+
		"WX\aT\x2\x2X\x62\a\x46\x2\x2YZ\aT\x2\x2Z[\aG\x2\x2[\\\aU\x2\x2\\\x62\a"+
		"\x44\x2\x2]^\aT\x2\x2^_\aG\x2\x2_`\aU\x2\x2`\x62\aY\x2\x2\x61U\x3\x2\x2"+
		"\x2\x61Y\x3\x2\x2\x2\x61]\x3\x2\x2\x2\x62\x64\x3\x2\x2\x2\x63\x65\a\v"+
		"\x2\x2\x64\x63\x3\x2\x2\x2\x64\x65\x3\x2\x2\x2\x65\f\x3\x2\x2\x2\x66g"+
		"\aT\x2\x2gh\aU\x2\x2hi\aW\x2\x2ij\a\x44\x2\x2jl\x3\x2\x2\x2km\a\v\x2\x2"+
		"lk\x3\x2\x2\x2lm\x3\x2\x2\x2m\xE\x3\x2\x2\x2no\a\x43\x2\x2op\a\x46\x2"+
		"\x2p\xB9\a\x46\x2\x2qr\a\x43\x2\x2rs\aP\x2\x2s\xB9\a\x46\x2\x2tu\a\x45"+
		"\x2\x2uv\aQ\x2\x2vw\aO\x2\x2w\xB9\aR\x2\x2xy\a\x46\x2\x2yz\aK\x2\x2z\xB9"+
		"\aX\x2\x2{\xB9\aL\x2\x2|}\aL\x2\x2}~\aG\x2\x2~\xB9\aS\x2\x2\x7F\x80\a"+
		"L\x2\x2\x80\x81\aI\x2\x2\x81\xB9\aV\x2\x2\x82\x83\aL\x2\x2\x83\x84\aN"+
		"\x2\x2\x84\xB9\aV\x2\x2\x85\x86\aL\x2\x2\x86\x87\aU\x2\x2\x87\x88\aW\x2"+
		"\x2\x88\xB9\a\x44\x2\x2\x89\x8A\aN\x2\x2\x8A\x8B\a\x46\x2\x2\x8B\xB9\a"+
		"\x43\x2\x2\x8C\x8D\aN\x2\x2\x8D\x8E\a\x46\x2\x2\x8E\x8F\a\x45\x2\x2\x8F"+
		"\xB9\aJ\x2\x2\x90\x91\aN\x2\x2\x91\x92\a\x46\x2\x2\x92\xB9\aN\x2\x2\x93"+
		"\x94\aN\x2\x2\x94\x95\a\x46\x2\x2\x95\xB9\aZ\x2\x2\x96\x97\aO\x2\x2\x97"+
		"\x98\aW\x2\x2\x98\xB9\aN\x2\x2\x99\x9A\aQ\x2\x2\x9A\xB9\aT\x2\x2\x9B\x9C"+
		"\aT\x2\x2\x9C\xB9\a\x46\x2\x2\x9D\x9E\aU\x2\x2\x9E\x9F\aV\x2\x2\x9F\xB9"+
		"\a\x43\x2\x2\xA0\xA1\aU\x2\x2\xA1\xA2\aV\x2\x2\xA2\xA3\a\x45\x2\x2\xA3"+
		"\xB9\aJ\x2\x2\xA4\xA5\aU\x2\x2\xA5\xA6\aV\x2\x2\xA6\xB9\aN\x2\x2\xA7\xA8"+
		"\aU\x2\x2\xA8\xA9\aV\x2\x2\xA9\xAA\aU\x2\x2\xAA\xB9\aY\x2\x2\xAB\xAC\a"+
		"U\x2\x2\xAC\xAD\aV\x2\x2\xAD\xB9\aZ\x2\x2\xAE\xAF\aU\x2\x2\xAF\xB0\aW"+
		"\x2\x2\xB0\xB9\a\x44\x2\x2\xB1\xB2\aV\x2\x2\xB2\xB9\a\x46\x2\x2\xB3\xB4"+
		"\aV\x2\x2\xB4\xB5\aK\x2\x2\xB5\xB9\aZ\x2\x2\xB6\xB7\aY\x2\x2\xB7\xB9\a"+
		"\x46\x2\x2\xB8n\x3\x2\x2\x2\xB8q\x3\x2\x2\x2\xB8t\x3\x2\x2\x2\xB8x\x3"+
		"\x2\x2\x2\xB8{\x3\x2\x2\x2\xB8|\x3\x2\x2\x2\xB8\x7F\x3\x2\x2\x2\xB8\x82"+
		"\x3\x2\x2\x2\xB8\x85\x3\x2\x2\x2\xB8\x89\x3\x2\x2\x2\xB8\x8C\x3\x2\x2"+
		"\x2\xB8\x90\x3\x2\x2\x2\xB8\x93\x3\x2\x2\x2\xB8\x96\x3\x2\x2\x2\xB8\x99"+
		"\x3\x2\x2\x2\xB8\x9B\x3\x2\x2\x2\xB8\x9D\x3\x2\x2\x2\xB8\xA0\x3\x2\x2"+
		"\x2\xB8\xA4\x3\x2\x2\x2\xB8\xA7\x3\x2\x2\x2\xB8\xAB\x3\x2\x2\x2\xB8\xAE"+
		"\x3\x2\x2\x2\xB8\xB1\x3\x2\x2\x2\xB8\xB3\x3\x2\x2\x2\xB8\xB6\x3\x2\x2"+
		"\x2\xB9\xBB\x3\x2\x2\x2\xBA\xBC\a\v\x2\x2\xBB\xBA\x3\x2\x2\x2\xBB\xBC"+
		"\x3\x2\x2\x2\xBC\x10\x3\x2\x2\x2\xBD\xBF\t\x2\x2\x2\xBE\xBD\x3\x2\x2\x2"+
		"\xBF\xC0\x3\x2\x2\x2\xC0\xBE\x3\x2\x2\x2\xC0\xC1\x3\x2\x2\x2\xC1\xC3\x3"+
		"\x2\x2\x2\xC2\xC4\t\x5\x2\x2\xC3\xC2\x3\x2\x2\x2\xC3\xC4\x3\x2\x2\x2\xC4"+
		"\xCA\x3\x2\x2\x2\xC5\xC6\a.\x2\x2\xC6\xC7\a\"\x2\x2\xC7\xCB\aZ\x2\x2\xC8"+
		"\xC9\a.\x2\x2\xC9\xCB\aZ\x2\x2\xCA\xC5\x3\x2\x2\x2\xCA\xC8\x3\x2\x2\x2"+
		"\xCA\xCB\x3\x2\x2\x2\xCB\xDF\x3\x2\x2\x2\xCC\xCE\t\x3\x2\x2\xCD\xCC\x3"+
		"\x2\x2\x2\xCE\xCF\x3\x2\x2\x2\xCF\xCD\x3\x2\x2\x2\xCF\xD0\x3\x2\x2\x2"+
		"\xD0\xD4\x3\x2\x2\x2\xD1\xD3\t\x2\x2\x2\xD2\xD1\x3\x2\x2\x2\xD3\xD6\x3"+
		"\x2\x2\x2\xD4\xD2\x3\x2\x2\x2\xD4\xD5\x3\x2\x2\x2\xD5\xDC\x3\x2\x2\x2"+
		"\xD6\xD4\x3\x2\x2\x2\xD7\xD8\a.\x2\x2\xD8\xD9\a\"\x2\x2\xD9\xDD\aZ\x2"+
		"\x2\xDA\xDB\a.\x2\x2\xDB\xDD\aZ\x2\x2\xDC\xD7\x3\x2\x2\x2\xDC\xDA\x3\x2"+
		"\x2\x2\xDC\xDD\x3\x2\x2\x2\xDD\xDF\x3\x2\x2\x2\xDE\xBE\x3\x2\x2\x2\xDE"+
		"\xCD\x3\x2\x2\x2\xDF\x12\x3\x2\x2\x2\xE0\xE2\t\x3\x2\x2\xE1\xE0\x3\x2"+
		"\x2\x2\xE2\xE3\x3\x2\x2\x2\xE3\xE1\x3\x2\x2\x2\xE3\xE4\x3\x2\x2\x2\xE4"+
		"\xE8\x3\x2\x2\x2\xE5\xE7\t\x2\x2\x2\xE6\xE5\x3\x2\x2\x2\xE7\xEA\x3\x2"+
		"\x2\x2\xE8\xE6\x3\x2\x2\x2\xE8\xE9\x3\x2\x2\x2\xE9\xF0\x3\x2\x2\x2\xEA"+
		"\xE8\x3\x2\x2\x2\xEB\xEC\a.\x2\x2\xEC\xED\a\"\x2\x2\xED\xF1\aZ\x2\x2\xEE"+
		"\xEF\a.\x2\x2\xEF\xF1\aZ\x2\x2\xF0\xEB\x3\x2\x2\x2\xF0\xEE\x3\x2\x2\x2"+
		"\xF0\xF1\x3\x2\x2\x2\xF1\xF3\x3\x2\x2\x2\xF2\xF4\a\v\x2\x2\xF3\xF2\x3"+
		"\x2\x2\x2\xF3\xF4\x3\x2\x2\x2\xF4\xF7\x3\x2\x2\x2\xF5\xF7\a\v\x2\x2\xF6"+
		"\xE1\x3\x2\x2\x2\xF6\xF5\x3\x2\x2\x2\xF7\x14\x3\x2\x2\x2\xF8\xF9\a\f\x2"+
		"\x2\xF9\x16\x3\x2\x2\x2\xFA\xFB\a)\x2\x2\xFB\x18\x3\x2\x2\x2\xFC\xFF\x3"+
		"\x2\x2\x2\xFD\xFF\t\x6\x2\x2\xFE\xFC\x3\x2\x2\x2\xFE\xFD\x3\x2\x2\x2\xFF"+
		"\x100\x3\x2\x2\x2\x100\x101\b\r\x2\x2\x101\x1A\x3\x2\x2\x2\x1D\x2\")\x31"+
		"\x38>HNS\x61\x64l\xB8\xBB\xC0\xC3\xCA\xCF\xD4\xDC\xDE\xE3\xE8\xF0\xF3"+
		"\xF6\xFE\x3\x2\x3\x2";
	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}
} // namespace Practica02
