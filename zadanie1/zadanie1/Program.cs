using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// projekt zawierający implementacje wypozyczalni

namespace zadanie1
{
    class Program
    {
        static void Main(string[] args)
        {
            WypozyczalniaGier wypozyczalnia;
            WypelnienieDanymi wypelnienie = new WypelnienieZPliku("test.dat");

            wypozyczalnia = new WypozyczalniaGier(wypelnienie);
            wypozyczalnia.wyswietlKlienta(3);

            wypozyczalnia.zapiszDane("test.dat");
            System.Console.ReadKey();
        }
    }
}