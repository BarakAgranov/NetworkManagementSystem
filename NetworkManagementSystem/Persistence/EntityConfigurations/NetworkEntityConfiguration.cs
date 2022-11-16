using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetworkManagementSystem.Core.Domain;

namespace NetworkManagementSystem.Persistence.EntityConfigurations
{
    public class NetworkEntityConfiguration : EntityTypeConfiguration<NetworkModel>
    {
        public NetworkEntityConfiguration()
        {
            Property(n => n.Id)
                .IsRequired();

            Property(n => n.Name)
                .IsRequired();

            Property(n => n.HostName)
                .IsRequired()
                .HasMaxLength(60);

            Property(n => n.Domain)
                .IsRequired()
                .HasMaxLength(60);

            HasMany(n => n.IpAddresses);

            HasMany(n => n.Subnets)
                .WithMany(s => s.Subnets);

            HasMany(n => n.Components)
                .WithMany(c => c.Networks);

            Property(n => n.TotalDayThroughput)
                .IsOptional();

        }
    }
}
