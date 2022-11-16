using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace NetworkManagementSystem.Core.Domain
{
    public class NetworkComponentModel
    {
        public int Id { get; set; }
        public ObservableCollection<IpAddressModel> IpAddresses { get; set; }
        public string MacAddress { get; set; }
        public ComponentTypeModel ComponentType { get; set; }
        public string HostName { get; set; }
        public string VendorName { get; set; }
        public ObservableCollection<NetworkModel> Networks { get; set; }
        public ObservableCollection<NetworkComponentModel> ConnectedComponents { get; set; }
        public long TotalDayThroughput { get; set; }
    }
}
