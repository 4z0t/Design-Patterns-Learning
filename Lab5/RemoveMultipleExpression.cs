using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab5
{
    internal class RemoveMultipleExpression : IExpression
    {

        public string[] PatternStrings { private set; get; }

        public RemoveMultipleExpression(string[] strings)
        {
            SetPatternStrings(strings);
        }

        public RemoveMultipleExpression(string s) : this(new string[] { s })
        {
        }


        void SetPatternStrings(string[] strings)
        {
            this.PatternStrings = strings.Select(s => string.Format("({0})", Regex.Escape(s))).ToArray();
        }


        public void Interpret(Context context)
        {
            foreach (string s in PatternStrings)
                context.input = Regex.Replace(context.input, s + "+", "$1");
        }
    }
}
