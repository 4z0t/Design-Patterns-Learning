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

        public int MaxPassengersAllowed => 30;

        public void BoardDriver(IDriver driver)
        {
            throw new NotImplementedException();
        }

        public void BoardPassanger(Passanger passanger)
        {
            throw new NotImplementedException();
        }
    }
}
