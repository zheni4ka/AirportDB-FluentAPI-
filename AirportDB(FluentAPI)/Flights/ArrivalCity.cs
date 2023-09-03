using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportDB_FluentAPI_
{
    public class ArrivalCity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Flights> Flights { get; set; } = new HashSet<Flights>();
    }
}
