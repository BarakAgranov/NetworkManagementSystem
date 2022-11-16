using NetworkManagementSystem.Core.Domain;
using NetworkManagementSystem.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkManagementSystem.Persistence.Repositories
{
    public class ComponentTypeRepository : Repository<ComponentTypeModel>, IComponentTypeRepository
    {
        public ComponentTypeRepository(DbContext context) : base(context)
        {
        }
    }
}
