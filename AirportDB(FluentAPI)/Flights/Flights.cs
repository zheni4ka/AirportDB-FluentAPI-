using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportDB_FluentAPI_
{
    public class Flights
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public ICollection<Client> Clients { get; set; } = new HashSet<Client>();
        public int PlaneId { get; set; }
        public Plane Plane { get; set; }
        public DateTime DepartueDate { get; set; }
        public DateTime ArrivalDate { get; set; }
        public DepartueCity DepartuePlace { get; set; }
        public int ArrivalPlaceId { get; set; }
        public ArrivalCity ArrivalPlace { get; set; }
        public int DeparturePlaceId { get; set; }
    }
}
