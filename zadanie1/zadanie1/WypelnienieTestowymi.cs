using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using zadanie1;

namespace zadanie1
{
    public class WypelnienieTestowymi : WypelnienieDanymi
    {
        public override BazaDanych wypelnij()
        {
            baza = new BazaDanych();

            baza.wykazKlientow.Add( new Klient("imie", "nazwisko", "nrDowodu") );
            baza.wykazKlientow.Add(new Klient("imie2", "nazwisko2", "nrDowodu2"));
            baza.katalogGier.dodajWpis("tytul", "opis");
            baza.katalogGier.dodajWpis("tytul2", "opis2");
            baza.zdarzenia.Add( new Wypozyczenie(1, 1, new DateTime(1, 1, 1), new DateTime(2, 2, 2)) );
            baza.zdarzenia.Add( new Wypozyczenie(0, 0, new DateTime(2, 2, 2), new DateTime(3, 3, 3)) );
            baza.stanGier.Add( new StanGry("nazwa", 1, 100f) );
            baza.stanGier.Add( new StanGry("nazwa2", 0, 200f) );
            return baza;
        }
    }
}
