using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public enum BaggageStatus
    {
        ACCEPTED,
        REMOVED
    }
    public class PassangerFlyData
    {
        public float surcharge;
        public Passenger passenger;
        public BaggageStatus status;

        public PassangerFlyData(float surcharge, Passenger passenger, BaggageStatus baggageStatus)
        {
            this.surcharge = surcharge;
            this.passenger = passenger;
            this.status = baggageStatus;

        }
    }
}
