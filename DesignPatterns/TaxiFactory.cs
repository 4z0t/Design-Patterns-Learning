using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    internal class TaxiFactory : IBoardFactory
    {
        public IBoardAnyCar CreateBoard() => new BoardTaxi();

        public IDriver CreateDriver() => new TaxiDriver();
    }
}
