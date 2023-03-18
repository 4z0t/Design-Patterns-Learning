using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{

    public enum PassengerCategory
    {
        Child,
        Adult,
        Preferential
    }

    public class Passenger
    {
        public Passenger(PassengerCategory category)
        {
            Category = category;   
        }
        public PassengerCategory Category { get; init; }
    }
}
