using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    internal class Example1
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

        public static void Start()
        {
            PassangerLoader busLoader = new PassangerLoader(new BusFactory());

            Passanger[] passangers = MakePassangers(40);

            for (int i = 0; i < passangers.Length; i++)
            {
                if (!busLoader.LoadPassanger(passangers[i]))
                    break;
                Console.WriteLine("Bus Loaded passenger " + i.ToString());
            }


            PassangerLoader  taxiLoader = new PassangerLoader(new TaxiFactory());

            Passanger[] taxiPassangers = MakePassangers(10);

            for (int i = 0; i < taxiPassangers.Length; i++)
            {
                if (!taxiLoader.LoadPassanger(taxiPassangers[i])) 
                    break;
                Console.WriteLine("Taxi Loaded passenger " + i.ToString());
            }

        }

    }
}
