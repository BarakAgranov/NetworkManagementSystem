using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkManagementSystem.Core.Domain
{
     public class ComponentTypeModel
    {
        public int Id { get; set; }
        public string TypeName { get; set; }

        public ComponentTypeModel(int id, string typeName)
        {
            Id = id;
            TypeName = typeName;
        }

        public ComponentTypeModel()
        {
            
        }
    }
}
