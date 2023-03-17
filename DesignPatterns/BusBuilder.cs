using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class BusBuilder : IBoardBuilder
    {

        private BoardBus? _taxi;
        private BusDriver? _driver;

        public void BuildBoard()
        {
            _taxi = new BoardBus();
        }

        public void BuildeDriver()
        {
            _driver = new BusDriver();
        }

        public IBoardAnyCar GetBoard()
        {
            if (_driver == null || _taxi == null) throw new Exception("Bus and driver were not created!");
            _taxi.BoardDriver(_driver);
            return _taxi;
        }
    }
}
