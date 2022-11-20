using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetworkManagementSystem.Core.Domain.Enums;

namespace NetworkManagementSystem.Core.Domain
{
    public class IpAddressModel
    {
        
        public int Id { get; set; }
        public string Address { get; set; }
        public IpAddressType AddressType { get; set; }
        public IpVersion Version { get; set; }


        public IpAddressModel(int id, string address, IpAddressType addressType, IpVersion version)
        {
            Id = id;
            Address = address;
            AddressType = addressType;
            Version = version;
        }

        public IpAddressModel()
        {
            
        }
    }

}
