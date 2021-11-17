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

        public override void GetAirplane()
        {
            Console.WriteLine($"Passenger airplane: {AirplaneModel} | max range: {MaxRangeFlight} | max passenger capacity: {MaxPassengerCapacity} | fuel expend {FuelExpend}");
        }

        public int GetPassengerCapacity()
        {
            return MaxPassengerCapacity;
        }
    }
}
