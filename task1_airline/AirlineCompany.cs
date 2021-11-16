using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task1_airline.Aircrafts;

namespace task1_airline
{
    class AirlineCompany
    {
        public List<Airplane> Aircrafts { get; private set; } = new List<Airplane>();

        public AirlineCompany()
        {

        }

        public AirlineCompany(List<Airplane> aircrafts)
        {
            Aircrafts = aircrafts;
        }

        public void AddAircraft(Airplane airplane)
        {
            Aircrafts.Add(airplane);
        }

        public List<Airplane> GetAirplanes()
        {
            return Aircrafts;
        }

        public AirlineCompany SortByMaxRangeFlight()
        {
            return new AirlineCompany((List<Airplane>)Aircrafts.OrderBy(x=>x.GetRangeFlight()));
        }

        public AirlineCompany SortByFuelExpend()
        {
            return new AirlineCompany((List<Airplane>)Aircrafts.OrderBy(x=>x.GetFuelExpend()));
        }
    }
}
