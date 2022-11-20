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
    public class NetworkComponentRepository : Repository<NetworkComponentModel>, INetworkComponentRepository
    {
        public NetworkComponentRepository(DbContext context) : base(context)
        {
        }

        public IEnumerable<NetworkComponentModel> GetHighestTrafficProducingComponents(int numOfComponentsToShow = 10)
        {
            return NetworkDbContext.NetworkComponents
                .OrderByDescending(c => c.TotalDayThroughput)
                .Take(numOfComponentsToShow)
                .ToList();
        }

        //        public IEnumerable<NetworkComponentModel> GetComponentsWithConnectedComponents(int pageIndex, int pageSize = 5)
        //        {
        //            return NetworkDbContext.NetworkComponents
        //                .Include(c => c.ConnectedComponents)
        //                .OrderByDescending(c => c.ConnectedComponents.Count)
        //                .Skip((pageIndex - 1) * pageSize)
        //                .Take(pageSize);
        //    }


        public NetworkDbContext NetworkDbContext
        {
            get {return Context as NetworkDbContext;}
        }
    }
}
