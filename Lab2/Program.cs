using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns;

namespace Program
{
    internal class Lab2
    {

        private static Passenger[] MakePassangers(int n)
        {
            Passenger[] passangers = new Passenger[n];
            for (int i = 0; i < n; i++)
            {
                passangers[i] = new Passenger();
            }
            return passangers;
        }

        public static void Main(string[] args)
        {
            
        }

    }
}
