using System;
using task1_airline.Aircrafts;

namespace task1_airline
{
    class Program
    {
        static void Main(string[] args)
        {
            AirlineCompany airlineCompany = new AirlineCompany();
            PassengerAirplane airplane1 = new PassengerAirplane(airplaneModel: "Boing 777-9X", maxRangeFlight: 14075, fuelExpend: 2000, maxPassengerCapacity: 450);
            PassengerAirplane airplane2 = new PassengerAirplane(airplaneModel: "Boing 777-200", maxRangeFlight: 7075, fuelExpend: 1000, maxPassengerCapacity: 250);
            PassengerAirplane airplane3 = new PassengerAirplane(airplaneModel: "IL-96", maxRangeFlight: 9000, fuelExpend: 1700, maxPassengerCapacity: 435);
            TransportAirplane airplane4 = new TransportAirplane(airplaneModel: "IL-96T", maxRangeFlight: 9000, fuelExpend: 4800, maxLoadCapacity: 58000);
            TransportAirplane airplane5 = new TransportAirplane(airplaneModel: "Boeing C-17", maxRangeFlight: 5190, fuelExpend: 3000, maxLoadCapacity: 56000);
            TransportAirplane airplane6 = new TransportAirplane(airplaneModel: "Lockheed C-5", maxRangeFlight: 4440, fuelExpend: 2700, maxLoadCapacity: 118000);
            
            airlineCompany.AddAircraft(airplane1);
            airlineCompany.AddAircraft(airplane2);
            airlineCompany.AddAircraft(airplane3);
            airlineCompany.AddAircraft(airplane4);
            airlineCompany.AddAircraft(airplane5);
            airlineCompany.AddAircraft(airplane6);
            
            airlineCompany.GetAllAirplanes();
            Console.WriteLine("");
            airlineCompany.SortByFuelExpend();
            Console.WriteLine("");
            airlineCompany.SortByMaxRangeFlight();
            Console.WriteLine("");
            
            Console.WriteLine($"The capacity of all passenger aircraft of the airline: {airlineCompany.GetCountPassengerCapacity()}");
            Console.WriteLine($"The capacity of all load transport aircraft of the airline: {airlineCompany.GetCountLoadCapacity()}");

        }
    }
}
