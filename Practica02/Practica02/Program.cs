using Antlr4.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Antlr4;
using System.IO;

namespace Practica02
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "",prog;
            //Console.WriteLine("");
            Console.WriteLine("Utiliza exit para cerrar el programa");
            //VARIABLE PARA ALMACENAR LA CADENA DE ENTRADA
            while (true)
            {
                prog = "";
                line = Console.ReadLine();
                //SE ALMACENA LA CADENA DE ENTRADA
                if (line.Contains("EXIT") || line.Contains("exit"))
                    //SI DETECTA EXIT SALE DEL PROGRAMA
                    break;
                else
                {
                    string linea, error;
                    System.IO.StreamReader file = null;
                    try
                    {
                        file = new System.IO.StreamReader(@line);
                        while ((linea = file.ReadLine()) != null)
                        {
                            prog += linea + '\n';
                        }
                        error = line.Substring(0, line.Length-1);
                        using (FileStream fs = File.Create(error+'t'))
                        {
                        }
                        prog = prog.Substring(0, prog.Length - 1);
                        file.Close();
                        SICLexer lex = new SICLexer(new AntlrInputStream(prog + Environment.NewLine));
                        //CREAMOS UN LEXER CON LA CADENA QUE ESCRIBIO EL USUARIO
                        CommonTokenStream tokens = new CommonTokenStream(lex);
                        //CREAMOS LOS TOKENS SEGUN EL LEXER CREADO
                        SICParser parser = new SICParser(tokens);
                        //CREAMOS EL PARSER CON LOS TOKENS CREADOS
                        try
                        {
                            parser.go();
                        }
                        catch (RecognitionException e)
                        {
                            Console.Error.WriteLine(e.StackTrace);
                        }
                    }
                    catch(Exception e)
                    {
                        System.Console.WriteLine("Archivo inexistente");
                    }
                }
            }
        }
    }
}
