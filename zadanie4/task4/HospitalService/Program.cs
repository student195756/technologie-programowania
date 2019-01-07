using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace HospitalService
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(WCFHospitalService)))
            {
                host.Open();
                Console.WriteLine("Serwer otwarty");
                Console.WriteLine("<nacisnij enter aby zamknac serwer>");
                Console.ReadLine();
            }
        }
    }
}
