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
        public override float WeightThreshold => float.PositiveInfinity;
    }

    public class BusinessClass : FlyClass
    {
        public override int PassangersCount => 20;
        public override float Surcharge { get; } = 100;
        public override float WeightThreshold => 35f;
    }

    public class EconomyClass : FlyClass
    {
        public override int PassangersCount => 150;
        public override float Surcharge { get; } = 100;
        public override float WeightThreshold => 20f;
    }
}
