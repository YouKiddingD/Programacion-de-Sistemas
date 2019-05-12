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
	string valor="";
	int form = 0;
	}

/*
 * Parser Rules
 */


go[string vale, string vali]: {rutae=vale; rutai = vali;}inicio expr* fin;

inicio: checarEtiq checarINIT checarOpSTART updateLine ENTER {i++;};

fin: checarEtiq checarACABA checarOpEND {i++;}{using (System.IO.StreamWriter file = new System.IO.StreamWriter(@rutai, true)){ file.WriteLine(linea);}}; 

expr : (checarEtiq checarInstruExt updateCPInst updateLine ENTER
	| checarEtiq checarInstru checarOp updateCPInst updateLine ENTER
	| checarEtiq checarRsub updateCPInst updateLine ENTER
	| checarEtiq checarDirec checarOp casoDirec updateLine ENTER
	| checarEtiq checarByte checarOpbyte updateCPByte updateLine ENTER){i++;}
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
	OPERANDBYTE {linea+= $OPERANDBYTE.text; valor = $OPERANDBYTE.text;}
	;

checarByte
	:
	~DIRBYTE {using (System.IO.StreamWriter file = new System.IO.StreamWriter(@rutae, true)){ file.WriteLine("Error BYTE en la linea: " + i);}}{linea+= $DIRBYTE.text;CP-=3;}
	|
	DIRBYTE {linea+= $DIRBYTE.text;}
	;

checarRsub
	:
	~EXEP {using (System.IO.StreamWriter file = new System.IO.StreamWriter(@rutae, true)){ file.WriteLine("Error RSUB en la linea: " + i);}}{linea+= $EXEP.text;}
	|
	EXEP {linea+= $EXEP.text;}
	;

checarOpSTART
	:
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
	ETIQUETA {linea+=$ETIQUETA.text;}
	|
	checarOpbyte
	|
	~OPERANDO
	;

checarOp
	:
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
	ETIQUETA{linea+=$ETIQUETA.text;}
	|
	checarOpbyte
	|
	~OPERANDO
	;

checarOpEND
	:
	ETIQUETA{linea+=$ETIQUETA.text;}
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
	~OPERANDO
	;

checarDirec
	:
	~DIRECTIVA checarByte
	|
	DIRECTIVA {linea+= $DIRECTIVA.text; Direct = $DIRECTIVA.text;}
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
	ETIQUETA  {linea+= CP + " "; if($ETIQUETA.text=="\t" || $ETIQUETA.text==" "){linea+="u ";}else{linea+=$ETIQUETA.text;}}
	;

checarInstru
	:
	~INSTRUCCION checarDirec
	|
	INSTRUCCION {linea+=$INSTRUCCION.text;}
	;

checarOPExt
	:
	checarOPF2
	|
	checarOPF3
	;

checarInstruExt
	:
	FORMATO1 {linea+=$FORMATO1.text; form=1;}
	|
	FORMATO2 {linea+=$FORMATO2.text; form=2;} checarOPF2
	|
	FORMATO3 {linea+=$FORMATO3.text; form=3;} checarOPF3
	|
	FORMATO4 {linea+=$FORMATO4.text; form=4;} checarOPF3
	|
	WS
	;


checarOPF2
	:
	OPERANDO {linea+=$OPERANDO.text;}
	|
	REG {linea+=$REG.text;}
	;

checarOPF3
	:
	OPERANDO {linea+=$OPERANDO.text;}
	|
	ETIQUETA {linea+=$ETIQUETA.text;}
	|
	INDIRECTO {linea+=$INDIRECTO.text;}
	|
	INMEDIATO {linea+=$INMEDIATO.text;}
	;


compileUnit
	:	expr EOF
	;

updateCPInst : {switch(form)
	{
		case 1: CP+=1;
		break;
		case 2: CP+=2;
		break;
		case 3: CP+=3;
		break;
		case 4: CP+=4;
		break;
	}
};

updateLine : {linea+='\n';};

updateCPByte : {
	if(valor[0]=='C')
	{
		valor = valor.Substring(2,valor.Length-3);
		CP+=valor.Length;
	}
	else
	{
		valor = valor.Substring(2,valor.Length-3);
		CP+=(int)(valor.Length/2);
	}
};

/*
 * Lexer Rules
 */

INIT: 'START''\t'?;
ACABA: 'END''\t'?;
DIRBYTE: 'BYTE''\t'?;
OPERANDBYTE: ('C'QUOTE[A-Z]*[0-9]*[A-Z]*QUOTE | 'X'QUOTE[A-F]*[0-9]*[A-F]*QUOTE );
DIRECTIVA: ('WORD'|'RESB'|'RESW'|'BASE')'\t'?;
EXEP: 'RSUB''\t'?;
FORMATO1: ('FIX'|'FLOAT'|'HIO'|'NORM'|'SIO'|'TIO')'\t'?;
FORMATO2: ('ADDR'|'CLEAR'|'COMPR'|'DIVR'|'MULR'|'RMO'|'SHIFTL'|'SHIFTR'|'SUBR'|'SVC'|'TIXR')'\t'?;
FORMATO3: ('ADD'|'ADDF'|'AND'|'COMP'|'COMPF'|'DIV'|'DIVF'|'J'|'JEQ'|'JGT'|'JLT'|'JSUB'|'LDA'|'LDB'|'LDCH'|'LDF'|'LDL'|'LDS'|'LDT'|'LDX'|'LPS'|'MUL'|'MULF'|'OR'|'RD'|'RSUB'|'SSK'|'STA'|'STB'|'STCH'|'STF'|'STI'|'STL'|'STS'|'STSW'|'STT'|'STX'|'SUB'|'SUBF'|'TD'|'TIX'|'WD')'\t'?;
FORMATO4: ('+'FORMATO3);
INSTRUCCION: ('ADD'|'AND'|'COMP'|'DIV'|'J'|'JEQ'|'JGT'|'JLT'|'JSUB'|'LDA'|'LDCH'|'LDL'|'LDX'|'MUL'|'OR'|'RD'|'STA'|'STCH'|'STL'|'STSW'|'STX'|'SUB'|'TD'|'TIX'|'WD')'\t'?;
INDIRECTO:'@'(ETIQUETA|OPERANDO);
INMEDIATO:'#'(ETIQUETA|OPERANDO);
REG: ('A'|'X'|'L'|'CP'|'SW'|'B'|'S'|'T'|'F')(','(OPERANDO|('A'|'X'|'L'|'CP'|'SW'|'B'|'S'|'T'|'F')))?'\t'?; 
OPERANDO: [0-9]+(('H'|'h')?)((', X'|',X')?);
ETIQUETA: ([A-Z]+[0-9]*)((', X'|',X')?)'\t'? | '\t';
ENTER: '\n';
QUOTE : '\'';
WS
	:	( |'\r'|'\t') -> channel(HIDDEN)
	;
