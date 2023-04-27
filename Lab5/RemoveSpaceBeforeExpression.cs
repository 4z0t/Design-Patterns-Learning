using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab5
{
    internal class RemoveSpaceBeforeExpression : RemoveSpaceAfterExpression
    {
        public RemoveSpaceBeforeExpression(string[] strings) : base(strings)
        {
        }

        public RemoveSpaceBeforeExpression(string s) : base(s)
        {
        }
        public override string Replace(string s, string pattern) => Regex.Replace(s, " " + pattern, "$1");
    }
}
