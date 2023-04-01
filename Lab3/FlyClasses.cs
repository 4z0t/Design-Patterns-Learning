using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class FirstClass : FlyClass
    {
        public override int PassangersCount => 10;
    }

    public class BusynessClass : FlyClass
    {
        public override int PassangersCount => 20;
    }

    public class EconomyClass : FlyClass
    {
        public override int PassangersCount => 150;
    }
}
