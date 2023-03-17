using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DesignPatterns;

namespace Program
{
    public class Lab1
    {

        private static Passenger[] MakePassengers(int n)
        {
            Passenger[] passengers = new Passenger[n];
            for (int i = 0; i < n; i++)
            {
                passengers[i] = new Passenger();
            }
            return passengers;
        }

        public static void Main(string[] args)
        {
            PassengerLoader busLoader = new PassengerLoader(new BusFactory());
            PassengerLoader taxiLoader = new PassengerLoader(new TaxiFactory());

            Passenger[] passengers = MakePassengers(40);

            for (int i = 0; i < passengers.Length; i++)
            {
                if (busLoader.LoadPassenger(passengers[i]))
                {
                    Console.WriteLine("Bus Loaded passenger \t№" + i.ToString() +
                        "\nPassangers in bus: \t" + busLoader.Board.PassengersCount.ToString());
                    continue;
                }

                if (taxiLoader.LoadPassenger(passengers[i]))
                {
                    Console.WriteLine("Taxi Loaded passenger \t№" + i.ToString() +
                        "\nPassangers in taxi: \t" + taxiLoader.Board.PassengersCount.ToString());
                    continue;
                }

                break;
            }
        }

    }
}
