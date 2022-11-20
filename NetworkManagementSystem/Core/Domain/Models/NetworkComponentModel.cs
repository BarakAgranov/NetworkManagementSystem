using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;


namespace NetworkManagementSystem.Core.Domain
{
    public class NetworkComponentModel
    {
        public int Id { get; set; }
        public virtual ObservableCollection<IpAddressModel> IpAddresses { get; set; }
        public string MacAddress { get; set; }
        public IEnumerable<ComponentTypeModel> ComponentType { get; set; }
        public string HostName { get; set; }
        public string VendorName { get; set; }
        public virtual ObservableCollection<NetworkModel> Networks { get; set; }
        // public virtual ObservableCollection<NetworkComponentModel> ConnectedComponents { get; set; }
        public long TotalDayThroughput { get; set; }

        public NetworkComponentModel(int id, ObservableCollection<IpAddressModel> ipAddresses, string macAddress, IEnumerable<ComponentTypeModel> componentType, string hostName, string vendorName, ObservableCollection<NetworkModel> networks, long totalDayThroughput)
        {
            Id = id;
            IpAddresses = ipAddresses;
            MacAddress = macAddress;
            ComponentType = componentType;
            HostName = hostName;
            VendorName = vendorName;
            Networks = networks;
            TotalDayThroughput = totalDayThroughput;
        }

        public NetworkComponentModel()
        {
            
        }
    }

}
