using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportDB_FluentAPI_
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public int SexId { get; set; }
        public Sex Sex { get; set; }
        public Account Account { get; set; } 
        public int AccountId { get; set; }
        public ICollection<Flights> Flights { get; set; } = new HashSet<Flights>();
    }
}
