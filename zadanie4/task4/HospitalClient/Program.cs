using HospitalInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace HospitalClient
{
    class Program
    {
        static void Main(string[] args)
        {
            ChannelFactory<IWCFHospitalService> channelFactory;
            channelFactory = new ChannelFactory<IWCFHospitalService>("HospitalServiceEndpoint");

            IWCFHospitalService proxy = channelFactory.CreateChannel();

            List<string> rooms = proxy.listDepartments();

            foreach(var i in rooms)
            {
                Console.WriteLine(i);
            }

            proxy.removeDepartment(4);
            foreach (var i in rooms)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}
