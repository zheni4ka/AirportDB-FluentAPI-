using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportDB_FluentAPI_
{
    public class Plane
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public PlaneType Type { get; set; }
        public int PlaneTypeId { get; set; }
        public int MaxPassengersCount { get; set; }
        public Country Country { get; set; }
        public int CountryId { get; set; }
        public ICollection<Flights> Flights { get; set; } = new HashSet<Flights>();
    }
}
