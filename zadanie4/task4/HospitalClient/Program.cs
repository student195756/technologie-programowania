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
            channelFactory = new ChannelFactory<IWCFHospitalService>("Hospital Service Endpoint");

            IWCFHospitalService proxy = channelFactory.CreateChannel();

            List<string> departments = proxy.ListDepartments();

            foreach(var i in departments)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}
