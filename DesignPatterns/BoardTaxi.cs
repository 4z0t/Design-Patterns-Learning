﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    internal class BoardTaxi : IBoardAnyCar
    {
        
        private TaxiDriver? _driver;

        public int MaxPassengersAllowed => 4;

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
