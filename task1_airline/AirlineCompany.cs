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
        public List<Airplane> Airplanes { get; private set; } = new List<Airplane>();

        public AirlineCompany()
        {
        }
        
        public AirlineCompany(IEnumerable<Airplane> airplanes)
        {
            Airplanes = airplanes.ToList();
        }
        
        public void AddAircraft(Airplane airplane)
        {
            Airplanes.Add(airplane);
        }

        public void GetAllAirplanes()
        {
            Console.WriteLine("-= All airplane company =-");
            foreach (var item in Airplanes)
            {
                item.GetAirplane();
            }
        }

        public List<PassengerAirplane> GetPassengerAirplanes()
        {
            return Airplanes.OfType<PassengerAirplane>().ToList();
        }

        public List<TransportAirplane> GetTransportAirplanes()
        {
            return Airplanes.OfType<TransportAirplane>().ToList();
        }

        public AirlineCompany SortByMaxRangeFlight()
        {
            Console.WriteLine("-= Sort airplane by max range =-");
            AirlineCompany airlineCompany = new AirlineCompany(Airplanes.OrderBy(x => x.GetRangeFlight()));
            GetAirplanes(airlineCompany.Airplanes);
            return airlineCompany;
        }

        public AirlineCompany SortByFuelExpend()
        {
            Console.WriteLine("-= Sort airplane by fuel =-");
            AirlineCompany airlineCompany = new AirlineCompany(Airplanes.OrderBy(x => x.GetFuelExpend()));
            GetAirplanes(airlineCompany.Airplanes);
            return airlineCompany; 
        }

        private void GetAirplanes(List<Airplane> airplanes)
        {
            foreach (var item in airplanes)
            {
                item.GetAirplane();
            }
        }

        public int GetCountLoadCapacity()
        {
            int count = GetTransportAirplanes().Sum(x => x.GetLoadCapacity());
            return count;
        }

        public int GetCountPassengerCapacity()
        {
            int count = GetPassengerAirplanes().Sum(x => x.GetPassengerCapacity());
            return count;
        }

        public AirlineCompany GetAirplanesByFuelExpend(int fuelExpend)
        {
            AirlineCompany airlineCompany = new AirlineCompany(Airplanes.Where(x => x.FuelExpend == fuelExpend));
            if(airlineCompany.Airplanes.Count != 0)
            {
                GetAirplanes(airlineCompany.Airplanes);
            }
            else
            {
                Console.WriteLine("Sorry, but no planes were found with this speed :(");
            }
            return airlineCompany;
        }
    }
}
