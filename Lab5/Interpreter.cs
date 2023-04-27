using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public class Interpreter
    {
        private List<IExpression> expressions;

        public Interpreter() : this(new List<IExpression>())
        {
        }

        public Interpreter(IEnumerable<IExpression> expressions)
        {
            this.expressions = new(expressions);
        }

        public string Process(string input)
        {
            Context context = new Context();
            context.input = input;

            foreach (var expression in expressions)
            {
                expression.Interpret(context);
            }

            return context.input;
        }

    }
}
