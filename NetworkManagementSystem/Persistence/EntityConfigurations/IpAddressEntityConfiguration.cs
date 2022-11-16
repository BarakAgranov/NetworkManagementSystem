using NetworkManagementSystem.Core.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkManagementSystem.Persistence.EntityConfigurations
{
    public class IpAddressEntityConfiguration : EntityTypeConfiguration<IpAddressModel>
    {
        public IpAddressEntityConfiguration()
        {

            Property(i => i.Id)
                .IsRequired();

            Property(i => i.Address)
                .IsRequired()
                .HasMaxLength(50);

            Property(i => i.AddressType)
                .IsRequired();

            Property(i => i.Version)
                .IsRequired();


    }
    }
}
