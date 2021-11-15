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
        public Guid Id { get; set; }
        public string NameCompany { get; set; }
        public List<Airplane> Aircrafts { get; set; }

        public AirlineCompany()
        {

        }
    }
}
