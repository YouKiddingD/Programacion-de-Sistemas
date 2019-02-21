grammar SIC;

options
{
    language=CSharp2;
}

@asd{bool val = false;}

/*
 * Parser Rules
 */

//prog: inicio expr* fin;

inicio: checarEtiq INIT checarOp ENTER;

fin: checarEtiq ACABA checarOp ENTER; 

expr returns[bool val]: checarEtiq checarInstru checarOp ENTER
	| checarEtiq checarRsub ENTER
	| checarEtiq checarDirec checarOp ENTER
	| checarEtiq checarByte checarOpbyte ENTER
	| inicio
	| fin
	;

checarOpbyte
	:
	~OPERANDBYTE 
	|
	OPERANDBYTE 
	;

checarByte
	:
	~DIRBYTE
	|
	DIRBYTE 
	;

checarRsub
	:
	~EXEP
	|
	EXEP
	;

checarOp
	:
	~ OPERANDO
	|
	OPERANDO
	|
	checarEtiq
	;

checarDirec
	:
	~DIRECTIVA
	|
	DIRECTIVA
	;

checarEtiq
	:
	~ETIQUETA
	|
	ETIQUETA
	;

checarInstru
	:
	~INSTRUCCION
	|
	INSTRUCCION
	;

compileUnit
	:	expr EOF
	;

/*
 * Lexer Rules
 */

INIT: 'START''\t'?;
ACABA: 'END''\t'?;
DIRBYTE: 'BYTE''\t'?;
OPERANDBYTE: ('C'['][0-9]*[A-Z]*['] | 'X'['][0-9]*[A-F]*[']);
DIRECTIVA: ('WORD'|'RESB'|'RESW')'\t'?;
EXEP: 'RSUB''\t'?;
INSTRUCCION: ('ADD'|'AND'|'COMP'|'DIV'|'J'|'JEQ'|'JGT'|'JLT'|'JSUB'|'LDA'|'LDCH'|'LDL'|'LDX'|'MUL'|'OR'|'RD'|'STA'|'STCH'|'STL'|'STSW'|'STX'|'SUB'|'TD'|'TIX'|'WD')'\t'?;
OPERANDO: [0-9]+(('H'|'h')?)(', X'?);
ETIQUETA: ([A-Z]+ [0-9]*)(', X'?)'\t'? | '\t';
ENTER: '\n';
WS
	:	(' '|'\r'|'\t') -> channel(HIDDEN)
	;
