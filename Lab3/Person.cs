using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Person : IEntity
    {
        public float Weight { get; init; }

        public Person()
        {
            Weight = 0;
        }

        public Person(float weight)
        {
            Weight = weight;
        }
    }
}
