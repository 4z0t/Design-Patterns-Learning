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

        private static Passanger[] MakePassangers(int n)
        {
            Passanger[] passangers = new Passanger[n];
            for (int i = 0; i < n; i++)
            {
                passangers[i] = new Passanger();
            }
            return passangers;
        }

        public static void Main(string[] args)
        {
            PassangerLoader busLoader = new PassangerLoader(new BusFactory());
            PassangerLoader taxiLoader = new PassangerLoader(new TaxiFactory());

            Passanger[] passangers = MakePassangers(40);

            for (int i = 0; i < passangers.Length; i++)
            {
                if (busLoader.LoadPassanger(passangers[i]))
                {
                    Console.WriteLine("Bus Loaded passenger \t№" + i.ToString() +
                        "\nPassangers in bus: \t" + busLoader.Board.PassangersCount.ToString());
                    continue;
                }

                if (taxiLoader.LoadPassanger(passangers[i]))
                {
                    Console.WriteLine("Taxi Loaded passenger \t№" + i.ToString() +
                        "\nPassangers in taxi: \t" + taxiLoader.Board.PassangersCount.ToString());
                    continue;
                }

                break;
            }
        }

    }
}
