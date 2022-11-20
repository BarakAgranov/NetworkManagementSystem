using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetworkManagementSystem.Core.Domain;

namespace NetworkManagementSystem.Core.Repositories
{
    public interface IComponentTypeRepository : IRepository<ComponentTypeModel>
    {
        ComponentTypeModel GetComponentType(int id);
        IQueryable<ComponentTypeModel> GetAllComponentTypesQueryable();

    }
}
