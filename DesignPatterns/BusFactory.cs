using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    internal class BusFactory : IBoardFactory
    {
        public IBoardAnyCar CreateBoard() => new BoardBus();
        public IDriver CreateDriver() => Singleton<BusDriver>.Instance;
        
    }
}
