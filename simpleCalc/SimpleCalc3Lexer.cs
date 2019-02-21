// $ANTLR 3.0.1 H:\\KB\\AntLr\\AntLr\\AntLr\\SimpleCalc3.g 2008-07-27 15:34:30

using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;



public class SimpleCalc3Lexer : Lexer 
{
    public const int RPAREN = 8;
    public const int WS = 14;
    public const int NEWLINE = 11;
    public const int ASSIGN = 10;
    public const int PLUS = 4;
    public const int INT = 13;
    public const int DIV = 7;
    public const int MULT = 6;
    public const int MINUS = 5;
    public const int ID = 12;
    public const int Tokens = 15;
    public const int EOF = -1;
    public const int LPAREN = 9;

    public SimpleCalc3Lexer() 
    {
		InitializeCyclicDFAs();
    }
    public SimpleCalc3Lexer(ICharStream input) 
		: base(input)
	{
		InitializeCyclicDFAs();
    }
    
    override public string GrammarFileName
    {
    	get { return "H:\\KB\\AntLr\\AntLr\\AntLr\\SimpleCalc3.g";} 
    }

    // $ANTLR start PLUS 
    public void mPLUS() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = PLUS;
            // H:\\KB\\AntLr\\AntLr\\AntLr\\SimpleCalc3.g:7:6: ( '+' )
            // H:\\KB\\AntLr\\AntLr\\AntLr\\SimpleCalc3.g:7:8: '+'
            {
            	Match('+'); 
            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end PLUS

    // $ANTLR start MINUS 
    public void mMINUS() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = MINUS;
            // H:\\KB\\AntLr\\AntLr\\AntLr\\SimpleCalc3.g:8:7: ( '-' )
            // H:\\KB\\AntLr\\AntLr\\AntLr\\SimpleCalc3.g:8:9: '-'
            {
            	Match('-'); 
            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end MINUS

    // $ANTLR start MULT 
    public void mMULT() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = MULT;
            // H:\\KB\\AntLr\\AntLr\\AntLr\\SimpleCalc3.g:9:6: ( '*' )
            // H:\\KB\\AntLr\\AntLr\\AntLr\\SimpleCalc3.g:9:8: '*'
            {
            	Match('*'); 
            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end MULT

    // $ANTLR start DIV 
    public void mDIV() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = DIV;
            // H:\\KB\\AntLr\\AntLr\\AntLr\\SimpleCalc3.g:10:5: ( '/' )
            // H:\\KB\\AntLr\\AntLr\\AntLr\\SimpleCalc3.g:10:7: '/'
            {
            	Match('/'); 
            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end DIV

    // $ANTLR start RPAREN 
    public void mRPAREN() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = RPAREN;
            // H:\\KB\\AntLr\\AntLr\\AntLr\\SimpleCalc3.g:11:8: ( ')' )
            // H:\\KB\\AntLr\\AntLr\\AntLr\\SimpleCalc3.g:11:10: ')'
            {
            	Match(')'); 
            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end RPAREN

    // $ANTLR start LPAREN 
    public void mLPAREN() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = LPAREN;
            // H:\\KB\\AntLr\\AntLr\\AntLr\\SimpleCalc3.g:12:8: ( '(' )
            // H:\\KB\\AntLr\\AntLr\\AntLr\\SimpleCalc3.g:12:10: '('
            {
            	Match('('); 
            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end LPAREN

    // $ANTLR start ASSIGN 
    public void mASSIGN() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = ASSIGN;
            // H:\\KB\\AntLr\\AntLr\\AntLr\\SimpleCalc3.g:13:8: ( '=' )
            // H:\\KB\\AntLr\\AntLr\\AntLr\\SimpleCalc3.g:13:10: '='
            {
            	Match('='); 
            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end ASSIGN

    // $ANTLR start ID 
    public void mID() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = ID;
            // H:\\KB\\AntLr\\AntLr\\AntLr\\SimpleCalc3.g:78:5: ( ( 'a' .. 'z' | 'A' .. 'Z' )+ )
            // H:\\KB\\AntLr\\AntLr\\AntLr\\SimpleCalc3.g:78:7: ( 'a' .. 'z' | 'A' .. 'Z' )+
            {
            	// H:\\KB\\AntLr\\AntLr\\AntLr\\SimpleCalc3.g:78:7: ( 'a' .. 'z' | 'A' .. 'Z' )+
            	int cnt1 = 0;
            	do 
            	{
            	    int alt1 = 2;
            	    int LA1_0 = input.LA(1);
            	    
            	    if ( ((LA1_0 >= 'A' && LA1_0 <= 'Z') || (LA1_0 >= 'a' && LA1_0 <= 'z')) )
            	    {
            	        alt1 = 1;
            	    }
            	    
            	
            	    switch (alt1) 
            		{
            			case 1 :
            			    // H:\\KB\\AntLr\\AntLr\\AntLr\\SimpleCalc3.g:
            			    {
            			    	if ( (input.LA(1) >= 'A' && input.LA(1) <= 'Z') || (input.LA(1) >= 'a' && input.LA(1) <= 'z') ) 
            			    	{
            			    	    input.Consume();
            			    	
            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse =
            			    	        new MismatchedSetException(null,input);
            			    	    Recover(mse);    throw mse;
            			    	}

            			    
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
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end ID

    // $ANTLR start INT 
    public void mINT() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = INT;
            // H:\\KB\\AntLr\\AntLr\\AntLr\\SimpleCalc3.g:79:5: ( ( '0' .. '9' )+ )
            // H:\\KB\\AntLr\\AntLr\\AntLr\\SimpleCalc3.g:79:7: ( '0' .. '9' )+
            {
            	// H:\\KB\\AntLr\\AntLr\\AntLr\\SimpleCalc3.g:79:7: ( '0' .. '9' )+
            	int cnt2 = 0;
            	do 
            	{
            	    int alt2 = 2;
            	    int LA2_0 = input.LA(1);
            	    
            	    if ( ((LA2_0 >= '0' && LA2_0 <= '9')) )
            	    {
            	        alt2 = 1;
            	    }
            	    
            	
            	    switch (alt2) 
            		{
            			case 1 :
            			    // H:\\KB\\AntLr\\AntLr\\AntLr\\SimpleCalc3.g:79:7: '0' .. '9'
            			    {
            			    	MatchRange('0','9'); 
            			    
            			    }
            			    break;
            	
            			default:
            			    if ( cnt2 >= 1 ) goto loop2;
            		            EarlyExitException eee =
            		                new EarlyExitException(2, input);
            		            throw eee;
            	    }
            	    cnt2++;
            	} while (true);
            	
            	loop2:
            		;	// Stops C# compiler whinging that label 'loop2' has no statements

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end INT

    // $ANTLR start NEWLINE 
    public void mNEWLINE() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = NEWLINE;
            // H:\\KB\\AntLr\\AntLr\\AntLr\\SimpleCalc3.g:80:9: ( ( '\\r' )? '\\n' )
            // H:\\KB\\AntLr\\AntLr\\AntLr\\SimpleCalc3.g:80:11: ( '\\r' )? '\\n'
            {
            	// H:\\KB\\AntLr\\AntLr\\AntLr\\SimpleCalc3.g:80:11: ( '\\r' )?
            	int alt3 = 2;
            	int LA3_0 = input.LA(1);
            	
            	if ( (LA3_0 == '\r') )
            	{
            	    alt3 = 1;
            	}
            	switch (alt3) 
            	{
            	    case 1 :
            	        // H:\\KB\\AntLr\\AntLr\\AntLr\\SimpleCalc3.g:80:11: '\\r'
            	        {
            	        	Match('\r'); 
            	        
            	        }
            	        break;
            	
            	}

            	Match('\n'); 
            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end NEWLINE

    // $ANTLR start WS 
    public void mWS() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = WS;
            // H:\\KB\\AntLr\\AntLr\\AntLr\\SimpleCalc3.g:81:4: ( ( ' ' | '\\t' | '\\n' | '\\r' )+ )
            // H:\\KB\\AntLr\\AntLr\\AntLr\\SimpleCalc3.g:81:6: ( ' ' | '\\t' | '\\n' | '\\r' )+
            {
            	// H:\\KB\\AntLr\\AntLr\\AntLr\\SimpleCalc3.g:81:6: ( ' ' | '\\t' | '\\n' | '\\r' )+
            	int cnt4 = 0;
            	do 
            	{
            	    int alt4 = 2;
            	    int LA4_0 = input.LA(1);
            	    
            	    if ( ((LA4_0 >= '\t' && LA4_0 <= '\n') || LA4_0 == '\r' || LA4_0 == ' ') )
            	    {
            	        alt4 = 1;
            	    }
            	    
            	
            	    switch (alt4) 
            		{
            			case 1 :
            			    // H:\\KB\\AntLr\\AntLr\\AntLr\\SimpleCalc3.g:
            			    {
            			    	if ( (input.LA(1) >= '\t' && input.LA(1) <= '\n') || input.LA(1) == '\r' || input.LA(1) == ' ' ) 
            			    	{
            			    	    input.Consume();
            			    	
            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse =
            			    	        new MismatchedSetException(null,input);
            			    	    Recover(mse);    throw mse;
            			    	}

            			    
            			    }
            			    break;
            	
            			default:
            			    if ( cnt4 >= 1 ) goto loop4;
            		            EarlyExitException eee =
            		                new EarlyExitException(4, input);
            		            throw eee;
            	    }
            	    cnt4++;
            	} while (true);
            	
            	loop4:
            		;	// Stops C# compiler whinging that label 'loop4' has no statements

            	Skip();
            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end WS

    override public void mTokens() // throws RecognitionException 
    {
        // H:\\KB\\AntLr\\AntLr\\AntLr\\SimpleCalc3.g:1:8: ( PLUS | MINUS | MULT | DIV | RPAREN | LPAREN | ASSIGN | ID | INT | NEWLINE | WS )
        int alt5 = 11;
        switch ( input.LA(1) ) 
        {
        case '+':
        	{
            alt5 = 1;
            }
            break;
        case '-':
        	{
            alt5 = 2;
            }
            break;
        case '*':
        	{
            alt5 = 3;
            }
            break;
        case '/':
        	{
            alt5 = 4;
            }
            break;
        case ')':
        	{
            alt5 = 5;
            }
            break;
        case '(':
        	{
            alt5 = 6;
            }
            break;
        case '=':
        	{
            alt5 = 7;
            }
            break;
        case 'A':
        case 'B':
        case 'C':
        case 'D':
        case 'E':
        case 'F':
        case 'G':
        case 'H':
        case 'I':
        case 'J':
        case 'K':
        case 'L':
        case 'M':
        case 'N':
        case 'O':
        case 'P':
        case 'Q':
        case 'R':
        case 'S':
        case 'T':
        case 'U':
        case 'V':
        case 'W':
        case 'X':
        case 'Y':
        case 'Z':
        case 'a':
        case 'b':
        case 'c':
        case 'd':
        case 'e':
        case 'f':
        case 'g':
        case 'h':
        case 'i':
        case 'j':
        case 'k':
        case 'l':
        case 'm':
        case 'n':
        case 'o':
        case 'p':
        case 'q':
        case 'r':
        case 's':
        case 't':
        case 'u':
        case 'v':
        case 'w':
        case 'x':
        case 'y':
        case 'z':
        	{
            alt5 = 8;
            }
            break;
        case '0':
        case '1':
        case '2':
        case '3':
        case '4':
        case '5':
        case '6':
        case '7':
        case '8':
        case '9':
        	{
            alt5 = 9;
            }
            break;
        case '\r':
        	{
            int LA5_10 = input.LA(2);
            
            if ( (LA5_10 == '\n') )
            {
                int LA5_11 = input.LA(3);
                
                if ( ((LA5_11 >= '\t' && LA5_11 <= '\n') || LA5_11 == '\r' || LA5_11 == ' ') )
                {
                    alt5 = 11;
                }
                else 
                {
                    alt5 = 10;}
            }
            else 
            {
                alt5 = 11;}
            }
            break;
        case '\n':
        	{
            int LA5_11 = input.LA(2);
            
            if ( ((LA5_11 >= '\t' && LA5_11 <= '\n') || LA5_11 == '\r' || LA5_11 == ' ') )
            {
                alt5 = 11;
            }
            else 
            {
                alt5 = 10;}
            }
            break;
        case '\t':
        case ' ':
        	{
            alt5 = 11;
            }
            break;
        	default:
        	    NoViableAltException nvae_d5s0 =
        	        new NoViableAltException("1:1: Tokens : ( PLUS | MINUS | MULT | DIV | RPAREN | LPAREN | ASSIGN | ID | INT | NEWLINE | WS );", 5, 0, input);
        
        	    throw nvae_d5s0;
        }
        
        switch (alt5) 
        {
            case 1 :
                // H:\\KB\\AntLr\\AntLr\\AntLr\\SimpleCalc3.g:1:10: PLUS
                {
                	mPLUS(); 
                
                }
                break;
            case 2 :
                // H:\\KB\\AntLr\\AntLr\\AntLr\\SimpleCalc3.g:1:15: MINUS
                {
                	mMINUS(); 
                
                }
                break;
            case 3 :
                // H:\\KB\\AntLr\\AntLr\\AntLr\\SimpleCalc3.g:1:21: MULT
                {
                	mMULT(); 
                
                }
                break;
            case 4 :
                // H:\\KB\\AntLr\\AntLr\\AntLr\\SimpleCalc3.g:1:26: DIV
                {
                	mDIV(); 
                
                }
                break;
            case 5 :
                // H:\\KB\\AntLr\\AntLr\\AntLr\\SimpleCalc3.g:1:30: RPAREN
                {
                	mRPAREN(); 
                
                }
                break;
            case 6 :
                // H:\\KB\\AntLr\\AntLr\\AntLr\\SimpleCalc3.g:1:37: LPAREN
                {
                	mLPAREN(); 
                
                }
                break;
            case 7 :
                // H:\\KB\\AntLr\\AntLr\\AntLr\\SimpleCalc3.g:1:44: ASSIGN
                {
                	mASSIGN(); 
                
                }
                break;
            case 8 :
                // H:\\KB\\AntLr\\AntLr\\AntLr\\SimpleCalc3.g:1:51: ID
                {
                	mID(); 
                
                }
                break;
            case 9 :
                // H:\\KB\\AntLr\\AntLr\\AntLr\\SimpleCalc3.g:1:54: INT
                {
                	mINT(); 
                
                }
                break;
            case 10 :
                // H:\\KB\\AntLr\\AntLr\\AntLr\\SimpleCalc3.g:1:58: NEWLINE
                {
                	mNEWLINE(); 
                
                }
                break;
            case 11 :
                // H:\\KB\\AntLr\\AntLr\\AntLr\\SimpleCalc3.g:1:66: WS
                {
                	mWS(); 
                
                }
                break;
        
        }
    
    }


	private void InitializeCyclicDFAs()
	{
	}

 
    
}
