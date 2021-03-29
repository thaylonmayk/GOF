using System.Collections;
using System.Collections.Generic;
using System;

namespace Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            string romano = "MCMXXVIII";
            Contexto context = new Contexto(romano);
            
            List<Expressao> tree = new List<Expressao>();
            tree.Add(new Milhar());
            tree.Add(new Centena());
            tree.Add(new Dezena());
            tree.Add(new Unidade());

            
            foreach (Expressao exp in tree)
            {
                exp.Interpret(context);
            }

            Console.WriteLine(context.getOutput());
        }
    }
}
