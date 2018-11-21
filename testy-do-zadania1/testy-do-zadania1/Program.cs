using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zadanie1;


namespace testy_do_zadania1
{
    class Program
    {
        static void Main(string[] args)
        {
            RepozytoriumDanych rp = new RepozytoriumDanych( new WypelnienieStalymi() );

            Console.ReadKey();
        }
    }
}
