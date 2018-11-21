using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie1
{
    class Program
    {
        static void Main(string[] args)
        {
            RepozytoriumDanych repozytorium = new RepozytoriumDanych( new WypelnienieStalymi() );

            Console.ReadKey();
        }
    }
}