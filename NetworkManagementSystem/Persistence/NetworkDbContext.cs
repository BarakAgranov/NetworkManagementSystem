using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetworkManagementSystem.Core.Domain;
using NetworkManagementSystem.Persistence.EntityConfigurations;

namespace NetworkManagementSystem.Persistence
{
    public class NetworkDbContext : DbContext
    {

        public NetworkDbContext()
            : base("name=NetworkContext")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public virtual DbSet<NetworkModel> Networks { get; set; }
        public virtual DbSet<NetworkComponentModel> NetworkComponents { get; set; }
        public virtual DbSet<ComponentTypeModel> ComponentTypes { get; set; }
        public virtual DbSet<IpAddressModel> IpAddresses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new NetworkEntityConfiguration());
            modelBuilder.Configurations.Add(new NetworkComponentEntityConfiguration());
            modelBuilder.Configurations.Add(new ComponentTypeEntityConfiguration());
            modelBuilder.Configurations.Add(new IpAddressEntityConfiguration());
        }

    }
}
