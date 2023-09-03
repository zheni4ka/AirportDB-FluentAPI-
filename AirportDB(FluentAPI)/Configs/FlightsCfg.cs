using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportDB_FluentAPI_.Configs
{
    public class FlightsCfg : IEntityTypeConfiguration<Flights>
    {
        public void Configure(EntityTypeBuilder<Flights> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Number).IsRequired();
            builder.Property(x => x.ArrivalDate).IsRequired();
            builder.Property(x => x.DepartueDate).IsRequired();
            

            builder.HasOne(x => x.ArrivalPlace).WithMany(x => x.Flights).HasForeignKey(x => x.ArrivalPlaceId).IsRequired();
            builder.HasOne(x => x.DepartuePlace).WithMany(x => x.Flights).HasForeignKey(x => x.DeparturePlaceId).IsRequired();
        }


    }
}
