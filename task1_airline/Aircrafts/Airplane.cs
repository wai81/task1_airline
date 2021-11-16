using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1_airline.Aircrafts
{
    public abstract class Airplane
    {
        private string AirplaneModel;
        private int MaxRangeFlight;        // Дальность полета
        private int FuelExpend;            // Расход топлива

        public Airplane(string airplaneModel, int maxRangeFlight, int fuelExpend)
        {
            AirplaneModel = airplaneModel;
            MaxRangeFlight = maxRangeFlight;
            FuelExpend = fuelExpend;
        }

        public string GetAirplaneModel()
        {
            return AirplaneModel;
        }

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
