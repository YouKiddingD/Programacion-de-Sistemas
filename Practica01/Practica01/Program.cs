using Antlr4.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Antlr4;

namespace Practica01
{
    class Program
    {

        static void Main(string[] args)
        {
            string line = "";
            //VARIABLE PARA ALMACENAR LA CADENA DE ENTRADA
            while (true)
            {
                line = Console.ReadLine();
                //SE ALMACENA LA CADENA DE ENTRADA
                if (line.Contains("EXIT") || line.Contains("exit"))
                    //SI DETECTA EXIT SALE DEL PROGRAMA
                    break;
                CalculadoraLexer lex = new CalculadoraLexer(new AntlrInputStream(line + Environment.NewLine));
                //CREAMOS UN LEXER CON LA CADENA QUE ESCRIBIO EL USUARIO
                CommonTokenStream tokens = new CommonTokenStream(lex);
                //CREAMOS LOS TOKENS SEGUN EL LEXER CREADO
                CalculadoraParser parser = new CalculadoraParser(tokens);
                //CREAMOS EL PARSER CON LOS TOKENS CREADOS
                try
                {
                    parser.expr();
                    //SE VERIFICA QUE EL ANALIZADOR EMPIECE CON LA EXPRESION
                    /*var tree=  parser.compileUnit();
                    var visitor = new CalculadoraVisitor();
                    visitor.Visit(tree);*/
                }
                catch (RecognitionException e)
                {
                    Console.Error.WriteLine(e.StackTrace);
                }
            }
        }
    }
}
