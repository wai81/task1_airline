using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1_airline.Aircrafts
{
    public class TransportAirplane : Airplane
    {
        private int MaxLoadCapacity;       // Грузоподъемность

        public TransportAirplane(string airplaneModel, int maxRangeFlight, int fuelExpend, int maxLoadCapacity) 
            : base(airplaneModel, maxRangeFlight, fuelExpend)
        {
            MaxLoadCapacity = maxLoadCapacity;
        }

        public int GetLoadCapacity()
        {
            return MaxLoadCapacity;
        }
    }
}
