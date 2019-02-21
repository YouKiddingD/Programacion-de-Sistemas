using Antlr4.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Antlr4;

namespace Practica02
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "";
            //Console.WriteLine("");
            Console.WriteLine("Utiliza exit para cerrar el programa");
            //VARIABLE PARA ALMACENAR LA CADENA DE ENTRADA
            while (true)
            {
                line = Console.ReadLine();
                //SE ALMACENA LA CADENA DE ENTRADA
                if (line.Contains("EXIT") || line.Contains("exit"))
                    //SI DETECTA EXIT SALE DEL PROGRAMA
                    break;
                else
                {
                    string linea; 
                    System.IO.StreamReader file = new System.IO.StreamReader(@".\copy.s");
                    while ((linea = file.ReadLine()) != null)
                    {
                        SICLexer lex = new SICLexer(new AntlrInputStream(linea + Environment.NewLine));
                        //CREAMOS UN LEXER CON LA CADENA QUE ESCRIBIO EL USUARIO
                        CommonTokenStream tokens = new CommonTokenStream(lex);
                        //CREAMOS LOS TOKENS SEGUN EL LEXER CREADO
                        SICParser parser = new SICParser(tokens);
                        //CREAMOS EL PARSER CON LOS TOKENS CREADOS
                        try
                        {
                            parser.expr();
                        }
                        catch (RecognitionException e)
                        {
                            Console.Error.WriteLine(e.StackTrace);
                        }
                    }
                    file.Close();
                }
                /*SICLexer lex = new SICLexer(new AntlrInputStream(line + Environment.NewLine));
                //CREAMOS UN LEXER CON LA CADENA QUE ESCRIBIO EL USUARIO
                CommonTokenStream tokens = new CommonTokenStream(lex);
                //CREAMOS LOS TOKENS SEGUN EL LEXER CREADO
                SICParser parser = new SICParser(tokens);
                //CREAMOS EL PARSER CON LOS TOKENS CREADOS
                try
                {
                    parser.expr();
                }
                catch (RecognitionException e)
                {
                    Console.Error.WriteLine(e.StackTrace);
                }*/
            }
        }
    }
}
