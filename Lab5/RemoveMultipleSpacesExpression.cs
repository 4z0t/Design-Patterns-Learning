using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Lab5
{
    internal class RemoveMultipleSpacesExpression : RemoveMultipleExpression
    {
        public RemoveMultipleSpacesExpression() : base(" ")
        {
        }
    }
}
