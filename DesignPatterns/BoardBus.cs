using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    internal class BoardBus : IBoardAnyCar
    {

        private BusDriver? _driver;
        private List<Passanger> _passangers = new List<Passanger>();

        public int MaxPassengersAllowed => 30;

        public int PassangersCount => _passangers.Count;

        public bool CanRide => _driver is not null;

        public void BoardDriver(IDriver driver)
        {
            if (_driver is not null) throw new ArgumentException("Bus already has a driver");
            if (driver is not BusDriver busDriver) throw new ArgumentException("Bus requires Bus driver");

            _driver = busDriver;
        }

        public void BoardPassanger(Passanger passanger)
        {
            if (PassangersCount == MaxPassengersAllowed) throw new ArgumentException("Passanger can't fit in Bus, limit is reached");

            _passangers.Add(passanger);
        }


    }
}
