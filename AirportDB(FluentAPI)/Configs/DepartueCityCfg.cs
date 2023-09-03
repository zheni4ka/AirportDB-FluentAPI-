using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportDB_FluentAPI_.Configs
{
    internal class DepartueCityCfg : IEntityTypeConfiguration<DepartueCity>
    {
        public void Configure(EntityTypeBuilder<DepartueCity> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name).IsRequired();
        }
    
    }
}
