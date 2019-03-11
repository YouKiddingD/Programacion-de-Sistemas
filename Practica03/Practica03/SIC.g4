grammar SIC;

options
{
    language=CSharp2;
}

@parser::members
	{
	int i=1;
	string rutae = "";
	string rutai = "";
	int CP=0;
	string linea = "";
	string Direct = "";
	int OP = 0;
	}

/*
 * Parser Rules
 */


go[string vale, string vali]: {rutae=vale; rutai = vali;}inicio expr* fin;

inicio: checarEtiq checarINIT checarOpSTART updateLine ENTER {i++;};

fin: checarEtiq checarACABA checarOp ENTER {i++;}{using (System.IO.StreamWriter file = new System.IO.StreamWriter(@rutai, true)){ file.WriteLine(linea);}}; 

expr : (checarEtiq checarInstru checarOp updateCPInst updateLine ENTER
	| checarEtiq checarRsub updateCPInst updateLine ENTER
	| checarEtiq checarDirec checarOp casoDirec updateLine ENTER
	| checarEtiq checarByte checarOpbyte updateCPByte updateLine ENTER) {i++;}
	;

checarINIT
	:
	INIT {linea+= $INIT.text;}
	;

checarACABA
	:
	ACABA {linea+= $ACABA.text;}
	;

checarOpbyte
	:
	~OPERANDBYTE {using (System.IO.StreamWriter file = new System.IO.StreamWriter(@rutae, true)){ file.WriteLine("Error OPBYTE en la linea: " + i);}}
	|
	OPERANDBYTE {linea+= $OPERANDBYTE.text;}
	;

checarByte
	:
	~DIRBYTE {using (System.IO.StreamWriter file = new System.IO.StreamWriter(@rutae, true)){ file.WriteLine("Error BYTE en la linea: " + i);}}
	|
	DIRBYTE {linea+= $DIRBYTE.text + " ";}
	;

checarRsub
	:
	~EXEP {using (System.IO.StreamWriter file = new System.IO.StreamWriter(@rutae, true)){ file.WriteLine("Error RSUB en la linea: " + i);}}
	|
	EXEP {linea+= $EXEP.text;}
	;

checarOpSTART
	:
	~OPERANDO //{using (System.IO.StreamWriter file = new System.IO.StreamWriter(@ruta, true)){ file.WriteLine("Error OPERADOR en la linea: " + i);}}
	|
	OPERANDO {
	linea+= $OPERANDO.text;
	if($OPERANDO.text[$OPERANDO.text.Length-1]=='H' || $OPERANDO.text[$OPERANDO.text.Length-1]=='h')
	{
		string final = $OPERANDO.text.Substring(0, $OPERANDO.text.Length - 1);
		CP = System.Convert.ToInt32(final,16);
	}
	else
	{
		CP =  System.Int32.Parse($OPERANDO.text);
	}
	linea = CP + linea.Substring(1,linea.Length-1);
	}
	|
	checarEtiq
	;

checarOp
	:
	~OPERANDO //{using (System.IO.StreamWriter file = new System.IO.StreamWriter(@ruta, true)){ file.WriteLine("Error OPERADOR en la linea: " + i);}}
	|
	OPERANDO {
	linea+= $OPERANDO.text;
	if($OPERANDO.text[$OPERANDO.text.Length-1]=='H' || $OPERANDO.text[$OPERANDO.text.Length-1]=='h')
	{
		string final = $OPERANDO.text.Substring(0, $OPERANDO.text.Length - 1);
		OP = System.Convert.ToInt32(final,16);
	}
	else
	{
		OP =  System.Int32.Parse($OPERANDO.text);
	}
	}
	|
	checarEtiq
	;

checarDirec
	:
	~DIRECTIVA checarByte
	|
	DIRECTIVA {linea+= $DIRECTIVA.text + " "; Direct = $DIRECTIVA.text;}
	;

casoDirec : {
switch(Direct)
	{
		case "WORD\t": CP+=3;
		break;
		case "RESW\t": CP+=OP*3;
		break;
		case "RESB\t": CP+=OP;
		break;
	}
			}
	;

checarEtiq
	:
	~ETIQUETA  {using (System.IO.StreamWriter file = new System.IO.StreamWriter(@rutae, true)){ file.WriteLine("Error ETIQUETA en la linea: " + i);}}
	|
	ETIQUETA  {linea+= CP + " " + $ETIQUETA.text + " ";}
	;

checarInstru
	:
	~INSTRUCCION checarDirec
	|
	INSTRUCCION {linea+=$INSTRUCCION.text + " ";}
	;

compileUnit
	:	expr EOF
	;

updateCPInst : {CP+=3;};

updateLine : {linea+='\n';};

updateCPByte : {};

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
OPERANDO: [0-9]+(('H'|'h')?)((', X'|',X')?);
ETIQUETA: ([A-Z]+ [0-9]*)((', X'|',X')?)'\t'? | '\t';
ENTER: '\n';
QUOTE : '\'';
WS
	:	( |'\r'|'\t') -> channel(HIDDEN)
	;
