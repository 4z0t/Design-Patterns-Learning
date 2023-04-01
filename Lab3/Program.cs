using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns;
using Lab3;

namespace Program
{
    public class Lab3
    {


        public static void Main(string[] args)
        {
            Plane plane = new Plane(4000);

            var data = plane.Load();

            for (int i = 0; i < data.Count; i++)
            {
                var passengerData = data[i];
                Console.WriteLine($"Passenger {i} \t FlyClass: {passengerData.type}\t Weight: {passengerData.passenger.Weight,5:F2}\t Surcharge: {passengerData.surcharge,8:F2}\t Baggage status: {passengerData.status}");
            }


        }


    }
}
