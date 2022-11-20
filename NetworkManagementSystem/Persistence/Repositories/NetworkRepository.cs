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

        public NetworkModel GetNetworkWithComponents(int networkId)
        {
            return NetworkDbContext.Networks
                .Include(n => n.Components)
                .SingleOrDefault(n => n.Id == networkId);
        }

        public IEnumerable<NetworkModel> GetMostPopulatedNetworks(int numOfNetworksToShow = 10)
        {
            return NetworkDbContext.Networks
                .OrderByDescending(n => n.Components.Count)
                .Take(numOfNetworksToShow)
                .ToList();
        }

        public NetworkDbContext NetworkDbContext
        {
            get { return Context as NetworkDbContext; }
        }
    }
}
