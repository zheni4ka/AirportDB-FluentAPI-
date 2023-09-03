using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportDB_FluentAPI_
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Plane> Planes { get; set; } = new HashSet<Plane>();
    }
}
