

namespace Lab5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Interpreter interpreter = new Interpreter(
                new IExpression[]
                {
                    new CorrectDashExpression(),
                    new CorrectQuoteExpression(),
                    new RemoveSpaceAfterExpression("("),
                    new RemoveSpaceBeforeExpression( new string []{ ")", ".", "," }),
                    new RemoveMultipleExpression(new string []{"\n", "\t", " "}),
                }
            );

            var s = "\t\t       .    “hello” - “world - . ,   (  ) k\n" +
                "\n" +
                "\n" +
                "\t\t\tssssssssssss";
            s = interpreter.Process(s);
            Console.WriteLine(s);

        }
    }
}
