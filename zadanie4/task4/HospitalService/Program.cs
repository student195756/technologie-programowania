using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalService
{
    class Program
    {
        static void Main(string[] args)
        {
            LinqToSqlDataContext db = new LinqToSqlDataContext();

            string department = (from d in db.oddzialies
                                select d.nazwa).First().ToString();

            Console.WriteLine(department);
            Console.ReadKey();
        }
    }
}
