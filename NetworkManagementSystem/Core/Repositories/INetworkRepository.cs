using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetworkManagementSystem.Core.Domain;
using NetworkManagementSystem.Persistence;

namespace NetworkManagementSystem.Core.Repositories
{
    public interface INetworkRepository : IRepository<NetworkModel>
    {

        NetworkModel GetNetworkWithComponents(int networkId);

        IEnumerable<NetworkModel> GetMostPopulatedNetworks(int numOfNetworksToShow = 10);
    }
}
