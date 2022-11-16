using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetworkManagementSystem.Core.Domain;
using NetworkManagementSystem.Core.Repositories;

namespace NetworkManagementSystem.Persistence.Repositories
{
    public class NetworkRepository : Repository<NetworkModel>, INetworkRepository
    {
        public NetworkRepository(DbContext context) : base(context)
        {
        }
    }
}
