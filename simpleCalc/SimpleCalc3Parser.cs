// $ANTLR 3.0.1 H:\\KB\\AntLr\\AntLr\\AntLr\\SimpleCalc3.g 2008-07-27 15:34:29

using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;



public class SimpleCalc3Parser : Parser 
{
    public static readonly string[] tokenNames = new string[] 
	{
        "<invalid>", 
		"<EOR>", 
		"<DOWN>", 
		"<UP>", 
		"PLUS", 
		"MINUS", 
		"MULT", 
		"DIV", 
		"RPAREN", 
		"LPAREN", 
		"ASSIGN", 
		"NEWLINE", 
		"ID", 
		"INT", 
		"WS"
    };

    public const int RPAREN = 8;
    public const int WS = 14;
    public const int NEWLINE = 11;
    public const int ASSIGN = 10;
    public const int PLUS = 4;
    public const int INT = 13;
    public const int MINUS = 5;
    public const int MULT = 6;
    public const int DIV = 7;
    public const int ID = 12;
    public const int EOF = -1;
    public const int LPAREN = 9;
    
    
        public SimpleCalc3Parser(ITokenStream input) 
    		: base(input)
    	{
    		InitializeCyclicDFAs();
        }
        

    override public string[] TokenNames
	{
		get { return tokenNames; }
	}

    override public string GrammarFileName
	{
		get { return "H:\\KB\\AntLr\\AntLr\\AntLr\\SimpleCalc3.g"; }
	}

    
    public static System.Collections.Generic.Dictionary<string, int> IDTable = new System.Collections.Generic.Dictionary<string, int>();
    
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


    
    // $ANTLR start prog
    // H:\\KB\\AntLr\\AntLr\\AntLr\\SimpleCalc3.g:51:1: prog : ( stat )+ ;
    public void prog() // throws RecognitionException [1]
    {   
        try 
    	{
            // H:\\KB\\AntLr\\AntLr\\AntLr\\SimpleCalc3.g:51:6: ( ( stat )+ )
            // H:\\KB\\AntLr\\AntLr\\AntLr\\SimpleCalc3.g:51:8: ( stat )+
            {
            	// H:\\KB\\AntLr\\AntLr\\AntLr\\SimpleCalc3.g:51:8: ( stat )+
            	int cnt1 = 0;
            	do 
            	{
            	    int alt1 = 2;
            	    int LA1_0 = input.LA(1);
            	    
            	    if ( (LA1_0 == LPAREN || (LA1_0 >= NEWLINE && LA1_0 <= INT)) )
            	    {
            	        alt1 = 1;
            	    }
            	    
            	
            	    switch (alt1) 
            		{
            			case 1 :
            			    // H:\\KB\\AntLr\\AntLr\\AntLr\\SimpleCalc3.g:51:8: stat
            			    {
            			    	PushFollow(FOLLOW_stat_in_prog102);
            			    	stat();
            			    	followingStackPointer_--;

            			    
            			    }
            			    break;
            	
            			default:
            			    if ( cnt1 >= 1 ) goto loop1;
            		            EarlyExitException eee =
            		                new EarlyExitException(1, input);
            		            throw eee;
            	    }
            	    cnt1++;
            	} while (true);
            	
            	loop1:
            		;	// Stops C# compiler whinging that label 'loop1' has no statements

            
            }
    
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return ;
    }
    // $ANTLR end prog

    
    // $ANTLR start stat
    // H:\\KB\\AntLr\\AntLr\\AntLr\\SimpleCalc3.g:53:1: stat : ( expr NEWLINE | ID ASSIGN expr NEWLINE | NEWLINE );
    public void stat() // throws RecognitionException [1]
    {   
        IToken ID2 = null;
        int expr1 = 0;

        int expr3 = 0;
        
    
        try 
    	{
            // H:\\KB\\AntLr\\AntLr\\AntLr\\SimpleCalc3.g:53:6: ( expr NEWLINE | ID ASSIGN expr NEWLINE | NEWLINE )
            int alt2 = 3;
            switch ( input.LA(1) ) 
            {
            case LPAREN:
            case INT:
            	{
                alt2 = 1;
                }
                break;
            case ID:
            	{
                int LA2_2 = input.LA(2);
                
                if ( (LA2_2 == ASSIGN) )
                {
                    alt2 = 2;
                }
                else if ( ((LA2_2 >= PLUS && LA2_2 <= DIV) || LA2_2 == NEWLINE) )
                {
                    alt2 = 1;
                }
                else 
                {
                    NoViableAltException nvae_d2s2 =
                        new NoViableAltException("53:1: stat : ( expr NEWLINE | ID ASSIGN expr NEWLINE | NEWLINE );", 2, 2, input);
                
                    throw nvae_d2s2;
                }
                }
                break;
            case NEWLINE:
            	{
                alt2 = 3;
                }
                break;
            	default:
            	    NoViableAltException nvae_d2s0 =
            	        new NoViableAltException("53:1: stat : ( expr NEWLINE | ID ASSIGN expr NEWLINE | NEWLINE );", 2, 0, input);
            
            	    throw nvae_d2s0;
            }
            
            switch (alt2) 
            {
                case 1 :
                    // H:\\KB\\AntLr\\AntLr\\AntLr\\SimpleCalc3.g:53:8: expr NEWLINE
                    {
                    	PushFollow(FOLLOW_expr_in_stat111);
                    	expr1 = expr();
                    	followingStackPointer_--;

                    	Match(input,NEWLINE,FOLLOW_NEWLINE_in_stat113); 
                    	System.Console.WriteLine(expr1);
                    
                    }
                    break;
                case 2 :
                    // H:\\KB\\AntLr\\AntLr\\AntLr\\SimpleCalc3.g:54:4: ID ASSIGN expr NEWLINE
                    {
                    	ID2 = (IToken)input.LT(1);
                    	Match(input,ID,FOLLOW_ID_in_stat123); 
                    	Match(input,ASSIGN,FOLLOW_ASSIGN_in_stat125); 
                    	PushFollow(FOLLOW_expr_in_stat127);
                    	expr3 = expr();
                    	followingStackPointer_--;

                    	Match(input,NEWLINE,FOLLOW_NEWLINE_in_stat129); 
                    	IDTable[ID2.Text] =expr3;
                    
                    }
                    break;
                case 3 :
                    // H:\\KB\\AntLr\\AntLr\\AntLr\\SimpleCalc3.g:55:4: NEWLINE
                    {
                    	Match(input,NEWLINE,FOLLOW_NEWLINE_in_stat137); 
                    
                    }
                    break;
            
            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return ;
    }
    // $ANTLR end stat

    
    // $ANTLR start expr
    // H:\\KB\\AntLr\\AntLr\\AntLr\\SimpleCalc3.g:57:1: expr returns [int value] : a= multExpr ( PLUS b= multExpr | MINUS b= multExpr )* ;
    public int expr() // throws RecognitionException [1]
    {   

        int value = 0;
    
        int a = 0;

        int b = 0;
        
    
        try 
    	{
            // H:\\KB\\AntLr\\AntLr\\AntLr\\SimpleCalc3.g:58:2: (a= multExpr ( PLUS b= multExpr | MINUS b= multExpr )* )
            // H:\\KB\\AntLr\\AntLr\\AntLr\\SimpleCalc3.g:58:4: a= multExpr ( PLUS b= multExpr | MINUS b= multExpr )*
            {
            	PushFollow(FOLLOW_multExpr_in_expr155);
            	a = multExpr();
            	followingStackPointer_--;

            	value =  a;
            	// H:\\KB\\AntLr\\AntLr\\AntLr\\SimpleCalc3.g:58:36: ( PLUS b= multExpr | MINUS b= multExpr )*
            	do 
            	{
            	    int alt3 = 3;
            	    int LA3_0 = input.LA(1);
            	    
            	    if ( (LA3_0 == PLUS) )
            	    {
            	        alt3 = 1;
            	    }
            	    else if ( (LA3_0 == MINUS) )
            	    {
            	        alt3 = 2;
            	    }
            	    
            	
            	    switch (alt3) 
            		{
            			case 1 :
            			    // H:\\KB\\AntLr\\AntLr\\AntLr\\SimpleCalc3.g:59:3: PLUS b= multExpr
            			    {
            			    	Match(input,PLUS,FOLLOW_PLUS_in_expr163); 
            			    	PushFollow(FOLLOW_multExpr_in_expr167);
            			    	b = multExpr();
            			    	followingStackPointer_--;

            			    	value+=b;
            			    
            			    }
            			    break;
            			case 2 :
            			    // H:\\KB\\AntLr\\AntLr\\AntLr\\SimpleCalc3.g:61:3: MINUS b= multExpr
            			    {
            			    	Match(input,MINUS,FOLLOW_MINUS_in_expr177); 
            			    	PushFollow(FOLLOW_multExpr_in_expr181);
            			    	b = multExpr();
            			    	followingStackPointer_--;

            			    	value-=b;
            			    
            			    }
            			    break;
            	
            			default:
            			    goto loop3;
            	    }
            	} while (true);
            	
            	loop3:
            		;	// Stops C# compiler whinging that label 'loop3' has no statements

            
            }
    
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return value;
    }
    // $ANTLR end expr

    
    // $ANTLR start multExpr
    // H:\\KB\\AntLr\\AntLr\\AntLr\\SimpleCalc3.g:63:1: multExpr returns [int value] : a= atom ( MULT b= atom | DIV b= atom )* ;
    public int multExpr() // throws RecognitionException [1]
    {   

        int value = 0;
    
        int a = 0;

        int b = 0;
        
    
        try 
    	{
            // H:\\KB\\AntLr\\AntLr\\AntLr\\SimpleCalc3.g:64:2: (a= atom ( MULT b= atom | DIV b= atom )* )
            // H:\\KB\\AntLr\\AntLr\\AntLr\\SimpleCalc3.g:64:4: a= atom ( MULT b= atom | DIV b= atom )*
            {
            	PushFollow(FOLLOW_atom_in_multExpr198);
            	a = atom();
            	followingStackPointer_--;

            	value =  a;
            	// H:\\KB\\AntLr\\AntLr\\AntLr\\SimpleCalc3.g:64:32: ( MULT b= atom | DIV b= atom )*
            	do 
            	{
            	    int alt4 = 3;
            	    int LA4_0 = input.LA(1);
            	    
            	    if ( (LA4_0 == MULT) )
            	    {
            	        alt4 = 1;
            	    }
            	    else if ( (LA4_0 == DIV) )
            	    {
            	        alt4 = 2;
            	    }
            	    
            	
            	    switch (alt4) 
            		{
            			case 1 :
            			    // H:\\KB\\AntLr\\AntLr\\AntLr\\SimpleCalc3.g:65:3: MULT b= atom
            			    {
            			    	Match(input,MULT,FOLLOW_MULT_in_multExpr206); 
            			    	PushFollow(FOLLOW_atom_in_multExpr210);
            			    	b = atom();
            			    	followingStackPointer_--;

            			    	value*=b;
            			    
            			    }
            			    break;
            			case 2 :
            			    // H:\\KB\\AntLr\\AntLr\\AntLr\\SimpleCalc3.g:67:3: DIV b= atom
            			    {
            			    	Match(input,DIV,FOLLOW_DIV_in_multExpr220); 
            			    	PushFollow(FOLLOW_atom_in_multExpr224);
            			    	b = atom();
            			    	followingStackPointer_--;

            			    	value/=b;
            			    
            			    }
            			    break;
            	
            			default:
            			    goto loop4;
            	    }
            	} while (true);
            	
            	loop4:
            		;	// Stops C# compiler whinging that label 'loop4' has no statements

            
            }
    
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return value;
    }
    // $ANTLR end multExpr

    
    // $ANTLR start atom
    // H:\\KB\\AntLr\\AntLr\\AntLr\\SimpleCalc3.g:69:1: atom returns [int value] : ( INT | ID | LPAREN expr RPAREN );
    public int atom() // throws RecognitionException [1]
    {   

        int value = 0;
    
        IToken INT4 = null;
        IToken ID5 = null;
        int expr6 = 0;
        
    
        try 
    	{
            // H:\\KB\\AntLr\\AntLr\\AntLr\\SimpleCalc3.g:70:2: ( INT | ID | LPAREN expr RPAREN )
            int alt5 = 3;
            switch ( input.LA(1) ) 
            {
            case INT:
            	{
                alt5 = 1;
                }
                break;
            case ID:
            	{
                alt5 = 2;
                }
                break;
            case LPAREN:
            	{
                alt5 = 3;
                }
                break;
            	default:
            	    NoViableAltException nvae_d5s0 =
            	        new NoViableAltException("69:1: atom returns [int value] : ( INT | ID | LPAREN expr RPAREN );", 5, 0, input);
            
            	    throw nvae_d5s0;
            }
            
            switch (alt5) 
            {
                case 1 :
                    // H:\\KB\\AntLr\\AntLr\\AntLr\\SimpleCalc3.g:70:4: INT
                    {
                    	INT4 = (IToken)input.LT(1);
                    	Match(input,INT,FOLLOW_INT_in_atom239); 
                    	value =  int.Parse(INT4.Text);
                    
                    }
                    break;
                case 2 :
                    // H:\\KB\\AntLr\\AntLr\\AntLr\\SimpleCalc3.g:71:4: ID
                    {
                    	ID5 = (IToken)input.LT(1);
                    	Match(input,ID,FOLLOW_ID_in_atom249); 
                    	if (IDTable.ContainsKey(ID5.Text)){value =  IDTable[ID5.Text];}else{System.Console.WriteLine("ID does not exist");}
                    
                    }
                    break;
                case 3 :
                    // H:\\KB\\AntLr\\AntLr\\AntLr\\SimpleCalc3.g:72:4: LPAREN expr RPAREN
                    {
                    	Match(input,LPAREN,FOLLOW_LPAREN_in_atom259); 
                    	PushFollow(FOLLOW_expr_in_atom261);
                    	expr6 = expr();
                    	followingStackPointer_--;

                    	Match(input,RPAREN,FOLLOW_RPAREN_in_atom263); 
                    	value =  expr6;
                    
                    }
                    break;
            
            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return value;
    }
    // $ANTLR end atom


	private void InitializeCyclicDFAs()
	{
	}

 

    public static readonly BitSet FOLLOW_stat_in_prog102 = new BitSet(new ulong[]{0x0000000000003A02UL});
    public static readonly BitSet FOLLOW_expr_in_stat111 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_NEWLINE_in_stat113 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_stat123 = new BitSet(new ulong[]{0x0000000000000400UL});
    public static readonly BitSet FOLLOW_ASSIGN_in_stat125 = new BitSet(new ulong[]{0x0000000000003200UL});
    public static readonly BitSet FOLLOW_expr_in_stat127 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_NEWLINE_in_stat129 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NEWLINE_in_stat137 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_multExpr_in_expr155 = new BitSet(new ulong[]{0x0000000000000032UL});
    public static readonly BitSet FOLLOW_PLUS_in_expr163 = new BitSet(new ulong[]{0x0000000000003200UL});
    public static readonly BitSet FOLLOW_multExpr_in_expr167 = new BitSet(new ulong[]{0x0000000000000032UL});
    public static readonly BitSet FOLLOW_MINUS_in_expr177 = new BitSet(new ulong[]{0x0000000000003200UL});
    public static readonly BitSet FOLLOW_multExpr_in_expr181 = new BitSet(new ulong[]{0x0000000000000032UL});
    public static readonly BitSet FOLLOW_atom_in_multExpr198 = new BitSet(new ulong[]{0x00000000000000C2UL});
    public static readonly BitSet FOLLOW_MULT_in_multExpr206 = new BitSet(new ulong[]{0x0000000000003200UL});
    public static readonly BitSet FOLLOW_atom_in_multExpr210 = new BitSet(new ulong[]{0x00000000000000C2UL});
    public static readonly BitSet FOLLOW_DIV_in_multExpr220 = new BitSet(new ulong[]{0x0000000000003200UL});
    public static readonly BitSet FOLLOW_atom_in_multExpr224 = new BitSet(new ulong[]{0x00000000000000C2UL});
    public static readonly BitSet FOLLOW_INT_in_atom239 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_atom249 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LPAREN_in_atom259 = new BitSet(new ulong[]{0x0000000000003200UL});
    public static readonly BitSet FOLLOW_expr_in_atom261 = new BitSet(new ulong[]{0x0000000000000100UL});
    public static readonly BitSet FOLLOW_RPAREN_in_atom263 = new BitSet(new ulong[]{0x0000000000000002UL});

}
