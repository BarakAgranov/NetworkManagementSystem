using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetworkManagementSystem.Core.Domain;

namespace NetworkManagementSystem.Persistence.EntityConfigurations
{
    public class NetworkComponentEntityConfiguration : EntityTypeConfiguration<NetworkComponentModel>
    {
        public NetworkComponentEntityConfiguration()
        {
            Property(n => n.Id)
                .IsRequired();

            HasMany(n => n.IpAddresses)
                .WithRequired();

            Property(n => n.MacAddress)
                .IsRequired()
                .HasMaxLength(60);

            Property(n => n.HostName)
                .IsRequired()
                .HasMaxLength(60);

            Property(n => n.VendorName)
                .IsOptional()
                .HasMaxLength(60);

            HasMany(n => n.Networks)
                .WithMany(n => n.Components);

            Property(n => n.TotalDayThroughput)
                .IsOptional();

        }
    }
}
