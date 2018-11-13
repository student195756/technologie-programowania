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
            WykazKlientow wykaz = new WykazKlientow();

            wykaz.dodajKlienta("Lukasz", "Baczyk", "AUZ123");

            KatalogGier katalog = new KatalogGier();

            katalog.dodajWpis("magia i miecz", "fajna gra");

            Console.Write(katalog.zwrocOpisGry("magia i miecz"));

            System.Console.ReadKey();
        }
    }
}
