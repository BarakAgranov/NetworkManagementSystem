using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetworkManagementSystem.Core.Domain;
using NetworkManagementSystem.Core.Repositories;
using NetworkManagementSystem.Persistence.Repositories;

namespace NetworkManagementSystem.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly NetworkDbContext _context;
        public INetworkRepository Networks { get; private set; }

        public INetworkComponentRepository Components { get; private set; }

        public IIpAddressRepository Addresses { get; private set; }
        public IComponentTypeRepository ComponentTypes { get; private set; }

        public UnitOfWork(NetworkDbContext context)
        {
            _context = context;
            Networks = new NetworkRepository(_context);
            Components = new NetworkComponentRepository(_context);
            Addresses = new IpAddressRepository(_context);
            ComponentTypes = new ComponentTypeRepository(_context);

        }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
