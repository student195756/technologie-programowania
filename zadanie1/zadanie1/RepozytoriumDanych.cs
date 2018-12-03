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

        public Klient zwrocKlienta(int indeks)
        {
            return bazaDanych.wykazKlientow.ElementAt(indeks);
        }

        public List<Klient> zwrocListeKlientow()
        {
            return bazaDanych.wykazKlientow;
        }

        public void aktualizujKlienta(int indeks, Klient nowyKlient)
        {
            bazaDanych.wykazKlientow[indeks] = nowyKlient;
        }

        public void usunKlienta(int indeks)
        {
            bazaDanych.wykazKlientow.RemoveAt(indeks);
        }

        public void dodajZdarzenie(Zdarzenie zdarzenie)
        {
            bazaDanych.zdarzenia.Add(zdarzenie);
        }

        public Zdarzenie zwrocZdarzenie(int indeks)
        {
            return bazaDanych.zdarzenia[indeks];
        }

        public ObservableCollection<Zdarzenie> zwrocWszystkieZdarzenia()
        {
            return bazaDanych.zdarzenia;
        }

        public void aktualizujZdarzenie(int indeks, Zdarzenie zdarzenie)
        {
            bazaDanych.zdarzenia[indeks] = zdarzenie;
        }

        public void usunZdarzenie(int indeks)
        {
            bazaDanych.zdarzenia.RemoveAt(indeks);
        }

        public void dodajNowyStanGry(StanGry stanGry)
        {
            bazaDanych.stanGier.Add(stanGry);
        }

        public StanGry zwrocStanGry(int indeks)
        {
            return bazaDanych.stanGier[indeks];
        }

        public List<StanGry> zwrocListeGier()
        {
            return bazaDanych.stanGier;
        }

        public void aktualizujStanGry(int indeks, StanGry stanGry)
        {
            bazaDanych.stanGier[indeks] = stanGry;
        }

        public void usunStanGry(int indeks)
        {
            bazaDanych.stanGier.RemoveAt(indeks);
        }
    }
}
