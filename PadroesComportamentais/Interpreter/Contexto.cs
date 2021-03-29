using System;
namespace Interpreter
{
    public class Contexto
    {
        private string input;
        private int output;

        public Contexto(string input)
        {
            this.input = input;
        }
        public string getInput()
        {
            return input;
        }
        public void setInput(string input)
        {
            this.input = input;
        }
        public int getOutput()
        {
            return output;
        }
        public void setOutput(int output)
        {
            this.output = output;
        }
    }
}