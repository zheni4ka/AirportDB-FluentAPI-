using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportDB_FluentAPI_
{
    public class ClientCfg : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Surname).IsRequired();
            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.Email).IsRequired();

            builder.HasOne(x => x.Account).WithOne(x => x.Client).HasForeignKey<Account>(x => x.ClientId).IsRequired();
            builder.HasMany(x => x.Flights).WithMany(x => x.Clients);
            builder.HasOne(x => x.Sex).WithMany(x => x.Clients).HasForeignKey(x => x.SexId).IsRequired();
        }
    }
}
