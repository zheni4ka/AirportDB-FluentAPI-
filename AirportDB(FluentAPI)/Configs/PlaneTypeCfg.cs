using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportDB_FluentAPI_.Configs
{
    internal class PlaneTypeCfg : IEntityTypeConfiguration<PlaneType>
    {
        public void Configure(EntityTypeBuilder<PlaneType> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name).IsRequired();
        }
    }
}
