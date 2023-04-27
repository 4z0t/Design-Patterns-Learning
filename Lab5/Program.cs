﻿

namespace Lab5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Interpreter interpreter = new Interpreter(
                new IExpression[]
                {
                    new RemoveMultipleSpacesExpression(),
                    new DashCorrectionExpression(),
                    new QuotesCorrectionExpression(),
                }
            );
            
            var s = "a“hellofdsfdf d fds  fds   1 12 12 s” - “world  a-a  a   - -  a v v v  ";
            s = interpreter.Process(s);
            Console.WriteLine(s);

        }
    }
}
