using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1_airline.Aircrafts
{
    abstract class Airplane
    {
        public string AirplaneModel { get; set; }
        public int MaxCapacity { get; set; }           // Вместимость
        public int MaxLoadCapacity { get; set; }       // Грузоподъемность
        public int MaxRangeFlight { get; set; }        // Дальность полета
    }
}
