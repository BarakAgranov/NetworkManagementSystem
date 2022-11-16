using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace NetworkManagementSystem.Core.Domain
{
    public class NetworkModel
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string HostName { get; set; }
        public string Domain { get; set; }
        public ObservableCollection<IpAddressModel> IpAddresses { get; set; }
        public ObservableCollection<NetworkModel> Subnets { get; set; }
        public ObservableCollection<NetworkComponentModel> Components { get; set; }
        public long TotalDayThroughput { get; set; }
    }
}
