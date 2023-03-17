using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class BoardTaxi : IBoardAnyCar
    {

        private IDriver? _driver;
        private List<Passenger> _passangers = new List<Passenger>();

        public int MaxPassengersAllowed => 4;

        public int PassangersCount => _passangers.Count;

        public bool CanRide => _driver is not null && PassangersCount > 0;

        public void BoardDriver(IDriver driver)
        {
            if (_driver is not null) throw new ArgumentException("Taxi already has a driver");
            if (driver.Licence != "Taxi") throw new ArgumentException("Taxi requires Taxi licenced driver");

            _driver = driver;
        }

        public void BoardPassanger(Passenger passenger)
        {
            if (PassangersCount == MaxPassengersAllowed) throw new ArgumentException("Passenger can't fit in taxi, limit is reached");

            _passangers.Add(passenger);
        }



    }
}
