using AirportDB_FluentAPI_.Configs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AirportDB_FluentAPI_
{
    public class AirportDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string conn = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=AirportDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer(conn);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new ClientCfg());
            modelBuilder.ApplyConfiguration(new FlightsCfg());
            modelBuilder.ApplyConfiguration(new PlaneCfg());
            modelBuilder.ApplyConfiguration(new AccountCfg());
            modelBuilder.ApplyConfiguration(new ArrivalCityCfg());
            modelBuilder.ApplyConfiguration(new DepartueCityCfg());
            modelBuilder.ApplyConfiguration(new SexCfg());
            modelBuilder.ApplyConfiguration(new PlaneTypeCfg());
            modelBuilder.ApplyConfiguration(new CountryCfg());


            modelBuilder.Entity<ArrivalCity>().HasData(new[]
            {
                new ArrivalCity() { Id = 1, Name = "San Diego"},
                new ArrivalCity() { Id = 2, Name = "Los Angeles"},
                new ArrivalCity() { Id = 3, Name = "London"},
                new ArrivalCity() { Id = 4, Name = "Berlin"}
            }); 
            modelBuilder.Entity<DepartueCity>().HasData(new[]
            {
                new ArrivalCity() { Id = 1, Name = "San Diego"},
                new ArrivalCity() { Id = 2, Name = "Los Angeles"},
                new ArrivalCity() { Id = 3, Name = "London"},
                new ArrivalCity() { Id = 4, Name = "Berlin"}
            });
            modelBuilder.Entity<PlaneType>().HasData(new[]
            {
                new PlaneType() { Id = 1, Name = "Jet"},
                new PlaneType() { Id = 2, Name = "Airbus"}
            });

            modelBuilder.Entity<Sex>().HasData(new[]
            {
                new Sex() { Id = 1, Name = "Male" },
                new Sex() { Id = 2, Name = "Female" }
            });
            modelBuilder.Entity<Country>().HasData(new[]
            {
                new Country() { Id = 1, Name = "Ukraine"},
                new Country() { Id = 2, Name = "Poland"}
            });
            modelBuilder.Entity<Account>().HasData(new[]
            {
                new Account() { Id = 1, Login = "firstTime", Password = "myfirsttime"},
                new Account() { Id = 2, Login = "favAirline", Password = "rasha-parasha" }
            });
            modelBuilder.Entity<Plane>().HasData(new[]
            {
                new Plane() { Id = 1, CountryId = 1, PlaneTypeId = 1, Name = "CJ2", MaxPassengersCount = 8},
                new Plane() { Id = 2, CountryId = 2, PlaneTypeId = 2, Name = "A380", MaxPassengersCount = 545},
            });
            modelBuilder.Entity<Client>().HasData(new[]
            {
                new Client() { Id = 1, Name = "Artem", Surname = "Guda", SexId = 1, Email ="guda@gmail.com", AccountId = 1 },
                new Client() { Id = 2, Name = "Viktor", Surname = "Viktor", SexId = 1, Email = "viktor@gmail.com", AccountId = 2 }
            });
            modelBuilder.Entity<Flights>().HasData(new[]
            {
                new Flights() { Id = 1, Number = 1, PlaneId = 1, DepartueDate = new DateTime(2018,02,20), ArrivalDate = new DateTime(2018,02,21), DeparturePlaceId = 1, ArrivalPlaceId = 3 },
                new Flights() { Id = 2, Number = 2, PlaneId = 2, DepartueDate = new DateTime(2020, 10, 12), ArrivalDate = new DateTime(2020,10,13), DeparturePlaceId = 2, ArrivalPlaceId = 4 }
            });
            
            

    }
            public DbSet<Country> Countries { get; set; }
            public DbSet<Plane> Planes { get; set; }
            public DbSet<ArrivalCity> Cities { get; set; }
            public DbSet<Account> Accounts { get; set; }
            public DbSet<Client> Clients { get; set; }
            public DbSet<Flights> Flights { get; set; }
            public DbSet<Sex> Sexes { get; set; }
            public DbSet<PlaneType> PlaneTypes { get; set; }
    }
}
