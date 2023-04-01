using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class StewardessesCrew : People
    {
        public const int STEWARDESSES_COUNT = 6;

        public StewardessesCrew() : base()
        {
            for (int i = 0; i < STEWARDESSES_COUNT; i++)
            {
                Add(new Stewardess());
            }
        }

    }
}
