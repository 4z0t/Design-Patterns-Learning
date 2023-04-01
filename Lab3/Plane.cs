using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Plane
    {
        public People Pilots { get; } = new PilotsCrew();
        public People Stewardesses { get; } = new StewardessesCrew();
        public FlyClass FirstClass { get; } = new FirstClass();
        public FlyClass BusinessClass { get; } = new BusinessClass();
        public FlyClass EconomyClass  { get; } = new EconomyClass();

        private float _maxWeight;

        public Plane(float maxWeight)
        {
            _maxWeight = maxWeight;
        }

        public void Load()
        {

        }






    }
}
