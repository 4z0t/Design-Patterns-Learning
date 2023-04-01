using DesignPatterns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Plane
    {
        public People Pilots { get; } = new PilotsCrew();
        public People Stewardesses { get; } = new StewardessesCrew();

        public FlyClass FirstClass { get; } = new FirstClass();
        public FlyClass BusinessClass { get; } = new BusinessClass();
        public FlyClass EconomyClass { get; } = new EconomyClass();

        private float _maxWeight;

        public Plane(float maxWeight)
        {
            _maxWeight = maxWeight;
        }


        private PassangerFlyData CalculateFlyData(Passenger passenger, FlyClass flyClass)
        {

            float surcharge = 0;
            if (passenger.Weight > flyClass.WeightThreshold)
                surcharge = (passenger.Weight - flyClass.WeightThreshold) * flyClass.Surcharge;
            return new(surcharge, passenger);
        }


        public List<PassangerFlyData> Load()
        {
            var flyData = new List<PassangerFlyData>();

            float totalWeight = 0;

            foreach (var passenger in FirstClass)
            {
                var data = CalculateFlyData(passenger as Passenger, FirstClass);
                if (_maxWeight - totalWeight > passenger.Weight)
                {
                    totalWeight += passenger.Weight;
                    data.status = BaggageStatus.ACCEPTED;
                }
                else
                {
                    data.status = BaggageStatus.REMOVED; ;
                }
                data.type = FlyClassType.FIRST;
                flyData.Add(data);
            }

            foreach (var passenger in BusinessClass)
            {
                var data = CalculateFlyData(passenger as Passenger, BusinessClass);
                if (_maxWeight - totalWeight > passenger.Weight)
                {
                    totalWeight += passenger.Weight;
                    data.status = BaggageStatus.ACCEPTED;
                }
                else
                {
                    data.status = BaggageStatus.REMOVED; ;
                }
                data.type = FlyClassType.BUSINESS;
                flyData.Add(data);
            }

            foreach (var passenger in EconomyClass)
            {
                var data = CalculateFlyData(passenger as Passenger, EconomyClass);
                if (_maxWeight - totalWeight > passenger.Weight)
                {
                    totalWeight += passenger.Weight;
                    data.status = BaggageStatus.ACCEPTED;
                }
                else
                {
                    data.status = BaggageStatus.REMOVED; ;
                }
                data.type = FlyClassType.ECONOMY;
                flyData.Add(data);
            }

            return flyData;
        }






    }
}
