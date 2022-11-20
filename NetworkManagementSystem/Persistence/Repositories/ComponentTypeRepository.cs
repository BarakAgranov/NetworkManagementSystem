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

        public IQueryable<ComponentTypeModel> GetAllComponentTypesQueryable()
        {
            return NetworkDbContext.ComponentTypes
                .OrderBy(c => c.Id);
        }

        public ComponentTypeModel GetComponentType(int id)
        {
            return NetworkDbContext.ComponentTypes
                .SingleOrDefault(t => t.Id == id);
        }

        public NetworkDbContext NetworkDbContext
        {
            get { return Context as NetworkDbContext; }
        }
    }
}
