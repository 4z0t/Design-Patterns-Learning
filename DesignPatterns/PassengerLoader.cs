using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class PassangerLoader
    {

        private IDriver _driver;

        private IBoardAnyCar _board;
        public IBoardAnyCar Board => _board;
        public PassangerLoader(IBoardFactory factory)
        {
            _driver = factory.CreateDriver();
            _board = factory.CreateBoard();
            _board.BoardDriver(_driver);
        }

        public bool LoadPassanger(Passanger passanger)
        {
            try
            {
                _board.BoardPassanger(passanger);
                return true;
            }
            catch(ArgumentException)
            {
                return false;
            }
        }


    }
}
