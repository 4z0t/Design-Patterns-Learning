using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class BoardBus : IBoardAnyCar
    {

        private IDriver? _driver;
        private List<Passenger> _passengers = new List<Passenger>();

        public int MaxPassengersAllowed => 30;

        public int PassengersCount => _passengers.Count;

        public bool CanRide => _driver is not null && PassengersCount > 0;

        public void BoardDriver(IDriver driver)
        {
            if (_driver is not null) throw new ArgumentException("Bus already has a driver");
            if (driver.Licence != "Bus") throw new ArgumentException("Bus requires Bus licenced driver");

            _driver = driver;
        }

        public void BoardPassenger(Passenger passenger)
        {
            if (PassengersCount == MaxPassengersAllowed) throw new ArgumentException("Passenger can't fit in Bus, limit is reached");

            _passengers.Add(passenger);
        }


    }
}
