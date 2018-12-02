using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zadanie1;

namespace zadanie1Tests
{
    class WypelnienieTestowymi : WypelnienieDanymi
    {
        public override BazaDanych wypelnij()
        {
            BazaDanych baza = new BazaDanych();

            baza.wykazKlientow.Add( new Klient("test", "test", "test") );
            baza.katalogGier.dodajWpis("test", "test");
            baza.zdarzenia.Add(new Wypozyczenie(
                                    new StanGry("test", 1, 100f),
                                    new Klient("test", "test", "test"),
                                    new DateTime(1, 1, 1),
                                    new DateTime(1, 1, 1) )
                               );
            baza.stanGier.Add( new StanGry("test", 1, 100f) );
            return baza;
        }
    }
}
