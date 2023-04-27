using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab5
{
    internal class RemoveSpaceAfterExpression : IExpression
    {

        public string[] PatternStrings { private set; get; }

        public RemoveSpaceAfterExpression(string[] strings)
        {
            SetPatternStrings(strings);
        }

        public RemoveSpaceAfterExpression(string s) : this(new string[] { s })
        {
        }


        void SetPatternStrings(string[] strings)
        {
            this.PatternStrings = strings.Select(s => string.Format("({0})", Regex.Escape(s))).ToArray();
        }

        public virtual string Replace(string s, string pattern) => Regex.Replace(s, pattern + " ", "$1");


        public void Interpret(Context context)
        {
            foreach (string s in PatternStrings)
                context.input = Replace(context.input, s);
        }
    }
}
