using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetworkManagementSystem.Persistence;

namespace NetworkManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var unitOfWork = new UnitOfWork(new NetworkDbContext()))
            {
                
                var  mostPopulatedNetworks = unitOfWork.Networks.GetMostPopulatedNetworks();
                foreach (var net in mostPopulatedNetworks)
                {
                    Console.WriteLine("most populated network: ");
                    Console.WriteLine(net.Name);
                }

                var networkWithComponents = unitOfWork.Networks.GetNetworkWithComponents(1);
                Console.WriteLine("network with components: ");
                Console.WriteLine(networkWithComponents.Domain);
                var components = networkWithComponents.Components.ToList();
                foreach (var comp in components)
                {
                    Console.WriteLine("component names: ");
                    Console.WriteLine(comp.HostName);
                }

                var componentsWithHighestTraffic = unitOfWork.Components.GetHighestTrafficProducingComponents(3);
                foreach (var comp in componentsWithHighestTraffic)
                {
                    Console.WriteLine("highest traffic components: ");
                    Console.WriteLine(comp.TotalDayThroughput);
                }

                var allComponents = unitOfWork.Components.GetAll();

                foreach (var comp in allComponents)
                {
                    Console.WriteLine(comp.MacAddress);
                }
            }
        }
    }
}
