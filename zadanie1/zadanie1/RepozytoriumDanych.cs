using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

        public void dodajKlienta(Klient klient)
        {
            bazaDanych.wykazKlientow.Add(klient);
        }

        Klient zwrocKlienta(int indeks)
        {
            return bazaDanych.wykazKlientow.ElementAt(indeks);
        }

        List<Klient> zwrocListeKlientow()
        {
            return bazaDanych.wykazKlientow;
        }

        void aktualizujKlienta(int indeks, Klient klient)
        {
            bazaDanych.wykazKlientow[indeks] = klient;
        }

        void usunKlienta(int indeks)
        {
            bazaDanych.wykazKlientow.RemoveRange(indeks, 1);
        }

        void dodajZdarzenie(Zdarzenie zdarzenie)
        {
            bazaDanych.zdarzenia.Add(zdarzenie);
        }

        Zdarzenie zwrocZdarzenie(int indeks)
        {
            return bazaDanych.zdarzenia[indeks];
        }

        ObservableCollection<Zdarzenie> zwrocWszystkieZdarzenia()
        {
            return bazaDanych.zdarzenia;
        }

        void aktualizujZdarzenie(int indeks, Zdarzenie zdarzenie)
        {
            bazaDanych.zdarzenia[indeks] = zdarzenie;
        }

        void usunZdarzenie(int indeks)
        {
            bazaDanych.zdarzenia.RemoveAt(indeks);
        }
        
    }
}
