using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1_airline.Aircrafts
{
    public abstract class Airplane
    {
        public string AirplaneModel { get; private set; }
        public int MaxRangeFlight { get; private set; }        // Дальность полета
        public int FuelExpend { get; private set; }             // Расход топлива

        public Airplane(string airplaneModel, int maxRangeFlight, int fuelExpend)
        {
            AirplaneModel = airplaneModel;
            MaxRangeFlight = maxRangeFlight;
            FuelExpend = fuelExpend;
        }
        
        public abstract void GetAirplane();
        
        public int GetRangeFlight()
        {
            return MaxRangeFlight;
        }

        public int GetFuelExpend()
        {
            return FuelExpend;
        }
    }
}
