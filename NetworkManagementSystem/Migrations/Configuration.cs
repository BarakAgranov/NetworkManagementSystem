using System.Collections.ObjectModel;
using NetworkManagementSystem.Core.Domain;
using NetworkManagementSystem.Core.Domain.Enums;

namespace NetworkManagementSystem.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.IO;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<NetworkManagementSystem.Persistence.NetworkDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(NetworkManagementSystem.Persistence.NetworkDbContext context)
        {
            var url = System.AppContext.BaseDirectory;
            var pathToRoot = url.Replace("\\bin\\Debug", "");

            var networksFile = Path.Combine(pathToRoot, "networks.txt");
            var networkComponentsFile = Path.Combine(pathToRoot, "network_components.txt");
            var componentTypesFile = Path.Combine(pathToRoot, "components_types.txt");
            
            List<IpAddressModel> ipAddressList = new List<IpAddressModel>();
            List<ComponentTypeModel> componentTypeList = new List<ComponentTypeModel>();
            List<NetworkModel> networkList = new List<NetworkModel>();
            List<NetworkComponentModel> networkComponents = new List<NetworkComponentModel>();
            

            string[] networkLines = File.ReadAllLines(networksFile);
            string[] networkComponentLines = File.ReadAllLines(networkComponentsFile);
            string[] componentTypeLines = File.ReadAllLines(componentTypesFile);

            foreach (var line in networkComponentLines)
            {
                var normalizedLine = line.Replace(" ", "");
                string[] fields = normalizedLine.Split('|');

                var newTypeModel = new ComponentTypeModel(int.Parse(fields[0]), fields[1]);
                var newIpAddressModel = new IpAddressModel(int.Parse(fields[0]), fields[1],
                    (IpAddressType)int.Parse(fields[0]), IpVersion.IPv4);

                componentTypeList.Add(newTypeModel);
                ipAddressList.Add(newIpAddressModel);
                
            }

            var componentTypes = context.ComponentTypes.AddRange(componentTypeList);
            var ipAddresses = context.IpAddresses.AddRange(ipAddressList);
            

            foreach (var network in networkLines)
            {
                var normalizedType = network.Replace(" ", "");
                string[] fields = normalizedType.Split('|');

                var ipAddress = ipAddresses.Where(i => i.Id == int.Parse(fields[0]));

                var newNetworkModel = new NetworkModel(int.Parse(fields[0]),
                    fields[1], fields[2], fields[3], new ObservableCollection<IpAddressModel>(ipAddress));

                networkList.Add(newNetworkModel);
            }

            var networks = context.Networks.AddRange(networkList);
            
            
            foreach (var component in networkComponentLines)
            {
                var normalizedComponent = component.Replace(" ", "");
                string[] fields = normalizedComponent.Split('|');
                Random randomNetwork = new Random();

                var ipAddress = ipAddresses.Where(i => i.Address.Equals(fields[1]));
                var componentType = componentTypes.Where(c => c.Id == int.Parse(fields[3]));
                var network = networks.Where(n => n.Id == randomNetwork.Next(0,1));

                var newComponentModel = new NetworkComponentModel(int.Parse(fields[0]),
                    new ObservableCollection<IpAddressModel>(ipAddress), fields[2], componentType, fields[4],
                    fields[5], new ObservableCollection<NetworkModel>(network), long.Parse(fields[6]));

                networkComponents.Add(newComponentModel);
            }

            context.NetworkComponents.AddRange(networkComponents);

            context.SaveChanges();
        }
    }
}
