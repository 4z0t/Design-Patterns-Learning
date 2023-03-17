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
        private List<Passenger> _passengers = new List<Passenger>();

        public int MaxPassengersAllowed => 4;

        public int PassengersCount => _passengers.Count;

        public bool CanRide => _driver is not null && PassengersCount > 0;

        public bool HasChildSeat { get; set; }

        public void BoardDriver(IDriver driver)
        {
            if (_driver is not null) throw new ArgumentException("Taxi already has a driver");
            if (driver.Licence != "Taxi") throw new ArgumentException("Taxi requires Taxi licenced driver");

            _driver = driver;
        }

        public void BoardPassenger(Passenger passenger)
        {
            if (PassengersCount == MaxPassengersAllowed) throw new ArgumentException("Passenger can't fit in taxi, limit is reached");

            _passengers.Add(passenger);
        }

        public decimal GetTicketPriceFor(Passenger passenger) => 400;

        public void InstallChildSeat()
        {
            if (HasChildSeat) throw new Exception("Child seat already installed!");
            HasChildSeat = true;
        }
    }
}
