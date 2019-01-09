using HospitalService;
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
            Query query = new Query();

            Console.WriteLine(query.getDepartment(1));

            List<string> departmentsList = new List<string>();

            departmentsList = query.ListDepartments();

            foreach(var i in departmentsList)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
