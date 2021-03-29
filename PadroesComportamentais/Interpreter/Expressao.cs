using System;
namespace Interpreter
{
    public abstract class Expressao
    {
        public void Interpret(Contexto context)
        {
            if (context.getInput().Length == 0)
                return;

            if (context.getInput().StartsWith(Nove()))
            {
                context.setOutput(context.getOutput() + (9 * Multiplicador()));
                context.setInput(context.getInput().Substring(2));
            }
            else if (context.getInput().StartsWith(Quatro()))
            {
                context.setOutput(context.getOutput() + (4 * Multiplicador()));
                context.setInput(context.getInput().Substring(2));
            }
            else if (context.getInput().StartsWith(Cinco()))
            {
                context.setOutput(context.getOutput() + (5 * Multiplicador()));
                context.setInput(context.getInput().Substring(1));
            }
            while (context.getInput().StartsWith(Um()))
            {
                context.setOutput(context.getOutput() + (1 * Multiplicador()));
                context.setInput(context.getInput().Substring(1));
            }
           
        }
        public abstract string Um();
        public abstract string Quatro();
        public abstract string Cinco();
        public abstract string Nove();
        public abstract int Multiplicador();
    }
}