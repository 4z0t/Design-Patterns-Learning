using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class PilotsCrew : People
    {
        public const int PILOTS_COUNT = 2;
        public PilotsCrew() : base()
        {
            for (int i = 0; i < PILOTS_COUNT; i++)
            {
                Add(new Pilot());
            }
        }
    }
}
