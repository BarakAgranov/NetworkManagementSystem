using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetworkManagementSystem.Core.Domain;

namespace NetworkManagementSystem.Persistence.EntityConfigurations
{
    public class ComponentTypeEntityConfiguration : EntityTypeConfiguration<ComponentTypeModel>
    {

        public ComponentTypeEntityConfiguration()
        {

            Property(t => t.Id)
                .IsRequired();

            Property(i => i.TypeName)
                .IsRequired();
                

    }
    }
}
