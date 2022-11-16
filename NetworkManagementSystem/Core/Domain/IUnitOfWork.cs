using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetworkManagementSystem.Core.Repositories;

namespace NetworkManagementSystem.Core.Domain
{
    public interface IUnitOfWork : IDisposable
    {
        INetworkRepository Networks { get; }
        INetworkComponentRepository Components { get; }
        IIpAddressRepository Addresses { get; }
        IComponentTypeRepository ComponentTypes { get; }
        int Complete();
    }
}
