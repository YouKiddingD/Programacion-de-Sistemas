grammar SimpleCalc3;
options {
	language=CSharp;
}
tokens {
	PLUS 	= '+' ;
	MINUS	= '-' ;
	MULT	= '*' ;
	DIV	= '/' ;
	RPAREN	= ')' ;
	LPAREN	= '(' ;
	ASSIGN	= '=' ;
}
@members
{
public static System.Collections.Generic.Dictionary IDTable = new System.Collections.Generic.Dictionary();
public static void Main(string[] args)
{
	Console.WriteLine("type '@' to quit...");
	string line = "";
	while (true)
	{
		line = Console.ReadLine();
		if (line.Contains("@")) break;
		SimpleCalc3Lexer lex = new SimpleCalc3Lexer(new ANTLRStringStream(line+Environment.NewLine));
		CommonTokenStream tokens = new CommonTokenStream(lex);
		SimpleCalc3Parser parser = new SimpleCalc3Parser(tokens);
		try
		{
			parser.prog();
		}
		catch (RecognitionException e)
		{
			Console.Error.WriteLine(e.StackTrace);
		}
	}
}
}
/*------------------------------------------------------------------
 * PARSER RULES
 *------------------------------------------------------------------*/
prog	:	stat+;
stat	:	expr NEWLINE			{System.Console.WriteLine($expr.value);}
	|	ID ASSIGN expr NEWLINE		{IDTable[$ID.Text] =$expr.value;}
	|	NEWLINE; 			//Do nothing
expr	returns[int value]
	:	a=multExpr {$value = $a.value;} (
		PLUS b=multExpr {$value+=$b.value;}
		MINUS b=multExpr{$value-=$b.value;})*;
multExpr returns[int value]
	:	a=atom {$value = $a.value;} (
		MULT b=atom {$value*=$b.value;}
		DIV b=atom{$value/=$b.value;})*;
atom	returns[int value]
	:	INT				{$value = int.Parse($INT.text);}
	|	ID				{if (IDTable.ContainsKey($ID.Text)){$value = IDTable[$ID.Text];}else{System.Console.WriteLine("ID does not exist");}}
	|	LPAREN expr RPAREN		{$value = $expr.value;};
/*------------------------------------------------------------------
 * LEXER RULES
 *------------------------------------------------------------------*/
ID 	:	('a'..'z'|'A'..'Z')+;
INT	:	'0'..'9'+;
NEWLINE	:	'\r'?'\n';
WS	:	(' '|'\t'|'\n'|'\r')+ {Skip();};


