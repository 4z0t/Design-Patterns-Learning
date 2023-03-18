using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class TaxiBuilder : IBoardBuilder
    {

        protected BoardTaxi? _taxi;
        protected TaxiDriver? _driver;

        public void BuildBoard()
        {
            _taxi = new BoardTaxi();
        }

        public void BuildeDriver()
        {
            _driver = new TaxiDriver();
        }

        public IBoardAnyCar GetBoard()
        {
            if (_driver == null || _taxi == null) throw new Exception("Taxi and driver were not created!");
            _taxi.BoardDriver(_driver);
            return _taxi;
        }
    }

    class TaxiWithChildSeatBuilder : TaxiBuilder
    {
        public new void  BuildBoard()
        {
            base.BuildBoard();
            _taxi.InstallChildSeat();
        }
    }

}
