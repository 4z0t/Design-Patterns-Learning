

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

                }
            );

            var s = "aaa   a-a  a   - -  a v v v  ";
            s = interpreter.Process(s);
            Console.WriteLine(s);

        }
    }
}
