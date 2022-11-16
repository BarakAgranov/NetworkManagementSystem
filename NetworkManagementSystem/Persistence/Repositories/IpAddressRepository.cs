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
    public class IpAddressRepository : Repository<IpAddressModel>, IIpAddressRepository
    {
        public IpAddressRepository(DbContext context) : base(context)
        {
        }

        
    }
}
