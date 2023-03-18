using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns;

namespace Program
{
    public class Lab2
    {
        private static Random random = new Random();
        public static PassengerCategory RandomCategory()
        {
            return random.Next(1, 3) switch
            {
                1=> PassengerCategory.Adult,
                2 => PassengerCategory.Preferential,
                3 => PassengerCategory.Child,
                _ => PassengerCategory.Adult
            };

        }

        private static Passenger[] MakePassengers(int n)
        {
            Passenger[] passangers = new Passenger[n];
            for (int i = 0; i < n; i++)
            {
                passangers[i] = new Passenger(RandomCategory());
            }
            return passangers;
        }

        public static void Main(string[] args)
        {
            PassengerLoader busLoader = new PassengerLoader(new BusBuilder());
            PassengerLoader taxiLoader = new PassengerLoader(new TaxiBuilder());

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
