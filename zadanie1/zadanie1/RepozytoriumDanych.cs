using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie1
{
    public class RepozytoriumDanych
    {
        private BazaDanych bazaDanych = new BazaDanych();

        public RepozytoriumDanych(WypelnienieDanymi wypelnienie)
        {
            bazaDanych = wypelnienie.wypelnij();
        }

        public void dodajWpisKatalogowy(string tytulGry, string opisGry)
        {
            bazaDanych.katalogGier.dodajWpis(tytulGry, opisGry);
        }

        public string zwrocInformacjeKatalogoweGry(string tytulGry)
        {
            return bazaDanych.katalogGier.zwrocOpisGry(tytulGry);
        }

        public void zaktualizujOpisGry(string tytulGry, string nowyOpis)
        {
            bazaDanych.katalogGier.ustawOpisGry(tytulGry, nowyOpis);
        }

        public void usunWpisKatalogowy(string tytulGry)
        {
            bazaDanych.katalogGier.usunGre(tytulGry);
        }

        public Dictionary<string, string> zwrocInformacjeKatalogoweWszystkichGier()
        {
            return bazaDanych.katalogGier.zwrocSlownik();
        }
        
    }
}
