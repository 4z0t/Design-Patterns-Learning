using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class PassengerLoader
    {

        private IDriver _driver;

        private IBoardAnyCar _board;
        public IBoardAnyCar Board => _board;
        public PassengerLoader(IBoardFactory factory)
        {
            _driver = factory.CreateDriver();
            _board = factory.CreateBoard();
            _board.BoardDriver(_driver);
        }

        public bool LoadPassenger(Passenger passenger)
        {
            try
            {
                _board.BoardPassenger(passenger);
                return true;
            }
            catch(ArgumentException)
            {
                return false;
            }
        }


    }
}
