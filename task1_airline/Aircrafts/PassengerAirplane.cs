using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1_airline.Aircrafts
{
    public class PassengerAirplane:Airplane
    {
        private int MaxPassengerCapacity;   // Вместимость

        public PassengerAirplane(string airplaneModel, int maxRangeFlight, int fuelExpend, int maxPassengerCapacity) 
            : base(airplaneModel, maxRangeFlight, fuelExpend)
        {
            MaxPassengerCapacity = maxPassengerCapacity;
        }

        public int GetPassengerCapacity()
        {
            return MaxPassengerCapacity;
        }
    }
}
