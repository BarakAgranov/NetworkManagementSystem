using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetworkManagementSystem.Core.Domain;
using NetworkManagementSystem.Persistence;

namespace NetworkManagementSystem.Core.Repositories
{
    public interface INetworkComponentRepository : IRepository<NetworkComponentModel>
    {
        IEnumerable<NetworkComponentModel> GetHighestTrafficProducingComponents(int numOfComponentsToShow);


//        IEnumerable<NetworkComponentModel> GetComponentsWithConnectedComponents(int pageIndex, int pageSize);

    }
}
