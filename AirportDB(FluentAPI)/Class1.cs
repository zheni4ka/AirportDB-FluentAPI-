using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportDB_FluentAPI_
{
    internal class Test
    {
        private static void Main(string[] args)
        {
            AirportDbContext dbContext = new AirportDbContext();
            foreach (var i in dbContext.Planes) { Console.WriteLine(i.Name); }
        }
    }
}
