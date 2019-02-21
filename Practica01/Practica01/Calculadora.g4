grammar Calculadora;

options
{
    language=CSharp2;
}

/*
 * Parser Rules
 */

 prog:expr+;
 
 expr:expr op=('*'|'/')expr
	  |expr op=('+'|'-')expr
	   |INT
	  |'('expr')'
		|ID	
		|expr '='expr
		;

compileUnit
	:	expr EOF
	;

/*
 * Lexer Rules
 */


ID:[a-z];
IGUAL:['='];
INT:[0-9]+;
MUL:'*';
DIV:'/';
ADD:'+';
SUB:'-';
WS
	:	(' '|'\r'|'\n') -> channel(HIDDEN)
	;