using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{


    public abstract class FlyClass : People
    {
        public abstract int PassangersCount { get; }

        public FlyClass()
        {
            var random = new Random(PassangersCount);
            for (int i = 0; i < PassangersCount; i++)
            {
                Add(new Passenger(random.Next(5, 65)));
            }
        }

    }
}
