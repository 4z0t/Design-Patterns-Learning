using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    internal interface IBoardAnyCar
    {
        public int MaxPassengersAllowed { get; }
        public int PassangersCount { get; }

        void BoardPassanger(Passanger passanger);

        void BoardDriver(IDriver driver);

        public bool CanRide { get; }
    }
}
