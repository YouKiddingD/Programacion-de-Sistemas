lexer grammar SimpleCalc3;
options {
  language=CSharp;

}

PLUS : '+' ;
MINUS : '-' ;
MULT : '*' ;
DIV : '/' ;
RPAREN : ')' ;
LPAREN : '(' ;
ASSIGN : '=' ;

// $ANTLR src "H:\KB\AntLr\AntLr\AntLr\SimpleCalc3.g" 78
ID 	:	('a'..'z'|'A'..'Z')+;
// $ANTLR src "H:\KB\AntLr\AntLr\AntLr\SimpleCalc3.g" 79
INT	:	'0'..'9'+;
// $ANTLR src "H:\KB\AntLr\AntLr\AntLr\SimpleCalc3.g" 80
NEWLINE	:	'\r'?'\n';
// $ANTLR src "H:\KB\AntLr\AntLr\AntLr\SimpleCalc3.g" 81
WS	:	(' '|'\t'|'\n'|'\r')+ {Skip();};
