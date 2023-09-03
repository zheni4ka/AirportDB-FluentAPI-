using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportDB_FluentAPI_
{ 
    public class PlaneCfg : IEntityTypeConfiguration<Plane>
    {
        public void Configure(EntityTypeBuilder<Plane> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.MaxPassengersCount).IsRequired();
            
            builder.HasOne(x => x.Country).WithMany(x => x.Planes).HasForeignKey(x => x.CountryId).IsRequired();
            builder.HasOne(x => x.Type).WithMany(x => x.Planes).HasForeignKey(x => x.PlaneTypeId).IsRequired();
            builder.HasMany(x => x.Flights).WithOne(x => x.Plane).HasForeignKey(x => x.PlaneId).IsRequired();
        }
    }
}
