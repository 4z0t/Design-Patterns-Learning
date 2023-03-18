using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class BusBuilder : IBoardBuilder
    {

        private BoardBus? _bus;
        private BusDriver? _driver;

        public void BuildBoard()
        {
            _bus = new BoardBus();
        }

        public void BuildeDriver()
        {
            _driver = new BusDriver();
        }

        public IBoardAnyCar GetBoard()
        {
            if (_driver == null || _bus == null) throw new Exception("Bus and driver were not created!");
            _bus.BoardDriver(_driver);
            return _bus;
        }
    }
}
