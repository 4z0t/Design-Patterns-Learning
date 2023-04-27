using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab5
{
    internal class DashCorrectionExpression : IExpression
    {
        public void Interpret(Context context)
        {
            context.input = Regex.Replace(context.input, " - ", " — ");
        }
    }
}
