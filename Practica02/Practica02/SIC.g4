grammar SIC;

options
{
    language=CSharp2;
}

@parser::members
	{
	int i=1;
	string ruta = "";
	}

/*
 * Parser Rules
 */


go[string val]: {ruta=val;}inicio expr* fin;

inicio: checarEtiq INIT checarOp ENTER {i++;};

fin: checarEtiq ACABA checarOp ENTER {i++;}; 

expr : (checarEtiq checarInstru checarOp ENTER
	| checarEtiq checarRsub ENTER
	| checarEtiq checarDirec checarOp ENTER
	| checarEtiq checarByte checarOpbyte ENTER) {i++;}
	;

checarOpbyte
	:
	~OPERANDBYTE {using (System.IO.StreamWriter file = new System.IO.StreamWriter(@ruta, true)){ file.WriteLine("Error OPBYTE en la linea: " + i);}}
	|
	OPERANDBYTE 
	;

checarByte
	:
	~DIRBYTE {using (System.IO.StreamWriter file = new System.IO.StreamWriter(@ruta, true)){ file.WriteLine("Error BYTE en la linea: " + i);}}
	|
	DIRBYTE 
	;

checarRsub
	:
	~EXEP {using (System.IO.StreamWriter file = new System.IO.StreamWriter(@ruta, true)){ file.WriteLine("Error RSUB en la linea: " + i);}}
	|
	EXEP
	;

checarOp
	:
	~OPERANDO //{using (System.IO.StreamWriter file = new System.IO.StreamWriter(@ruta, true)){ file.WriteLine("Error OPERADOR en la linea: " + i);}}
	|
	OPERANDO 
	|
	checarEtiq
	;

checarDirec
	:
	~DIRECTIVA checarByte
	|
	DIRECTIVA
	;

checarEtiq
	:
	~ETIQUETA  {using (System.IO.StreamWriter file = new System.IO.StreamWriter(@ruta, true)){ file.WriteLine("Error ETIQUETA en la linea: " + i);}}
	|
	ETIQUETA  
	;

checarInstru
	:
	~INSTRUCCION checarDirec
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
OPERANDBYTE: ('C'QUOTE[A-Z]*[0-9]*[A-Z]*QUOTE | 'X'QUOTE[A-F]*[0-9]*[A-F]*QUOTE );
DIRECTIVA: ('WORD'|'RESB'|'RESW')'\t'?;
EXEP: 'RSUB''\t'?;
INSTRUCCION: ('ADD'|'AND'|'COMP'|'DIV'|'J'|'JEQ'|'JGT'|'JLT'|'JSUB'|'LDA'|'LDCH'|'LDL'|'LDX'|'MUL'|'OR'|'RD'|'STA'|'STCH'|'STL'|'STSW'|'STX'|'SUB'|'TD'|'TIX'|'WD')'\t'?;
OPERANDO: [0-9]+(('H'|'h')?)((', X'|',X')?) | ([A-Z]+ [0-9]*)((', X'|',X')?);
ETIQUETA: ([A-Z]+ [0-9]*)((', X'|',X')?)'\t'? | '\t';
ENTER: '\n';
QUOTE : '\'';
WS
	:	( |'\r'|'\t') -> channel(HIDDEN)
	;
