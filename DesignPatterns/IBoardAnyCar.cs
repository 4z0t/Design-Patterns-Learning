﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public interface IBoardAnyCar
    {
        public int MaxPassengersAllowed { get; }
        public int PassengersCount { get; }

        void BoardPassenger(Passenger passenger);

        void BoardDriver(IDriver driver);

        public decimal GetTicketPriceFor(Passenger passenger);

        public bool CanRide { get; }
    }
}
