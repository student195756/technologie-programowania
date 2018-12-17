using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zadanie1;

namespace uzycie_wypozyczalni
{
    class Program
    {
        static void Main(string[] args)
        {
            WypelnienieTestowymi wt = new WypelnienieTestowymi();
            WypozyczalniaGier wypozyczalnia = new WypozyczalniaGier(wt);
            wypozyczalnia.wyswietlStanGry(0);
            Console.ReadKey();
        }
    }
}
