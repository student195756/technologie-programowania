using Microsoft.VisualStudio.TestTools.UnitTesting;
using zadanie1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zadanie1Tests;
using System.Collections.ObjectModel;

namespace zadanie1.Tests
{
    [TestClass()]
    public class RepozytoriumDanychTests
    {
        [TestMethod()]
        public void dodajWpisKatalogowyTest()
        {
            WypelnienieTestowymi daneTestowe = new WypelnienieTestowymi();
            RepozytoriumDanych repozytorium;
            repozytorium = new RepozytoriumDanych(daneTestowe);
            Dictionary<string, string> slownik;
            string opis;

            repozytorium.dodajWpisKatalogowy("tytulTest", "opisTest");
            opis = repozytorium.zwrocInformacjeKatalogoweGry("tytulTest");
            slownik = repozytorium.zwrocInformacjeKatalogoweWszystkichGier();

            Assert.AreEqual("opisTest", opis);
            Assert.IsTrue(slownik.ContainsKey("tytulTest"));
        }

        [TestMethod()]
        public void zwrocInformacjeKatalogoweGryTest()
        {
            WypelnienieTestowymi daneTestowe = new WypelnienieTestowymi();
            RepozytoriumDanych repozytorium;
            repozytorium = new RepozytoriumDanych(daneTestowe);

            string opisGry = repozytorium.zwrocInformacjeKatalogoweGry("tytul");

            Assert.AreEqual("opis", opisGry);
        }

        [TestMethod()]
        public void zaktualizujOpisGryTest()
        {
            WypelnienieTestowymi daneTestowe = new WypelnienieTestowymi();
            RepozytoriumDanych repozytorium;
            repozytorium = new RepozytoriumDanych(daneTestowe);

            repozytorium.zaktualizujOpisGry("tytul", "nowyOpis");
            string opisGry = repozytorium.zwrocInformacjeKatalogoweGry("tytul");

            Assert.AreEqual("nowyOpis", opisGry);
        }

        [TestMethod()]
        public void usunWpisKatalogowyTest()
        {
            WypelnienieTestowymi daneTestowe = new WypelnienieTestowymi();
            RepozytoriumDanych repozytorium;
            repozytorium = new RepozytoriumDanych(daneTestowe);
            int liczbaWpisow;

            repozytorium.usunWpisKatalogowy("tytul2");
            liczbaWpisow = repozytorium.zwrocInformacjeKatalogoweWszystkichGier().Count;

            Assert.AreEqual(1, liczbaWpisow);
        }

        [TestMethod()]
        public void zwrocInformacjeKatalogoweWszystkichGierTest()
        {
            WypelnienieTestowymi daneTestowe = new WypelnienieTestowymi();
            RepozytoriumDanych repozytorium;
            repozytorium = new RepozytoriumDanych(daneTestowe);
            Dictionary<string, string> slownik;
            int liczbaWpisow;

            slownik = repozytorium.zwrocInformacjeKatalogoweWszystkichGier();
            liczbaWpisow = slownik.Count;

            Assert.AreEqual(2, liczbaWpisow);
            Assert.IsTrue(slownik.ContainsValue("opis"));
            Assert.IsTrue(slownik.ContainsValue("opis2"));
            Assert.IsTrue(slownik.ContainsKey("tytul"));
            Assert.IsTrue(slownik.ContainsKey("tytul"));
        }

        [TestMethod()]
        public void dodajKlientaTest()
        {
            WypelnienieTestowymi daneTestowe = new WypelnienieTestowymi();
            RepozytoriumDanych repozytorium;
            repozytorium = new RepozytoriumDanych(daneTestowe);
            Klient klient = new Klient("Lukasz", "Baczyk", "123ABC");
            string imie;
            string nazwisko;
            string numerDowodu;

            repozytorium.dodajKlienta(klient);
            imie = repozytorium.zwrocKlienta(2).zwrocImie();
            nazwisko = repozytorium.zwrocKlienta(2).zwrocNazwisko();
            numerDowodu = repozytorium.zwrocKlienta(2).zwrocNumerDowodu();

            Assert.AreEqual("Lukasz", imie);
            Assert.AreEqual("Baczyk", nazwisko);
            Assert.AreEqual("123ABC", numerDowodu);
        }

        [TestMethod()]
        public void zwrocKlientaTest()
        {
            WypelnienieTestowymi daneTestowe = new WypelnienieTestowymi();
            RepozytoriumDanych repozytorium;
            repozytorium = new RepozytoriumDanych(daneTestowe);
            Klient klient;
            string imie;
            string nazwisko;
            string numerDowodu;

            klient = repozytorium.zwrocKlienta(0);
            imie = klient.zwrocImie();
            nazwisko = klient.zwrocNazwisko();
            numerDowodu = klient.zwrocNumerDowodu();

            Assert.AreEqual("imie", imie);
            Assert.AreEqual("nazwisko", nazwisko);
            Assert.AreEqual("nrDowodu", numerDowodu);
        }

        [TestMethod()]
        public void zwrocListeKlientowTest()
        {
            WypelnienieTestowymi daneTestowe = new WypelnienieTestowymi();
            RepozytoriumDanych repozytorium;
            repozytorium = new RepozytoriumDanych(daneTestowe);
            List<Klient> klienci;
            Klient klient1;
            string imie1;
            string nazwisko1;
            string numerDowodu1;
            Klient klient2;
            string imie2;
            string nazwisko2;
            string numerDowodu2;

            klienci = repozytorium.zwrocListeKlientow();
            klient1 = klienci[0];
            klient2 = klienci[1];
            imie1 = klient1.zwrocImie();
            imie2 = klient2.zwrocImie();
            nazwisko1 = klient1.zwrocNazwisko();
            nazwisko2 = klient2.zwrocNazwisko();
            numerDowodu1 = klient1.zwrocNumerDowodu();
            numerDowodu2 = klient2.zwrocNumerDowodu();

            Assert.AreEqual("imie", imie1);
            Assert.AreEqual("imie2", imie2);
            Assert.AreEqual("nazwisko", nazwisko1);
            Assert.AreEqual("nazwisko2", nazwisko2);
            Assert.AreEqual("nrDowodu", numerDowodu1);
            Assert.AreEqual("nrDowodu2", numerDowodu2);
        }

        [TestMethod()]
        public void aktualizujKlientaTest()
        {
            WypelnienieTestowymi daneTestowe = new WypelnienieTestowymi();
            RepozytoriumDanych repozytorium;
            repozytorium = new RepozytoriumDanych(daneTestowe);
            Klient klient;
            string imie;
            string nazwisko;
            string numerDowodu;

            klient = new Klient("imieTest", "nazwiskoTest", "numerTest");
            repozytorium.aktualizujKlienta(0, klient);
            imie = repozytorium.zwrocKlienta(0).zwrocImie();
            nazwisko = repozytorium.zwrocKlienta(0).zwrocNazwisko();
            numerDowodu = repozytorium.zwrocKlienta(0).zwrocNumerDowodu();

            Assert.AreEqual("imieTest", imie);
            Assert.AreEqual("nazwiskoTest", nazwisko);
            Assert.AreEqual("numerTest", numerDowodu);
        }

        [TestMethod()]
        public void usunKlientaTest()
        {
            WypelnienieTestowymi daneTestowe = new WypelnienieTestowymi();
            RepozytoriumDanych repozytorium;
            repozytorium = new RepozytoriumDanych(daneTestowe);

            repozytorium.usunKlienta(0);

            Assert.AreEqual(1, repozytorium.zwrocListeKlientow().Count);
        }

        [TestMethod()]
        public void dodajZdarzenieTest()
        {
            WypelnienieTestowymi daneTestowe = new WypelnienieTestowymi();
            RepozytoriumDanych repozytorium;
            repozytorium = new RepozytoriumDanych(daneTestowe);
            Klient wypozyczajacy = new Klient("test", "test", "test");
            StanGry gra = new StanGry("test", 1, 1f);
            DateTime a = new DateTime(1, 1, 1);
            Wypozyczenie wypozyczenie;
            int liczbaWypozyczen;

            wypozyczenie = new Wypozyczenie(gra, wypozyczajacy, a, a);
            repozytorium.dodajZdarzenie(wypozyczenie);
            liczbaWypozyczen = repozytorium.zwrocWszystkieZdarzenia().Count;

            Assert.AreEqual(3, liczbaWypozyczen);
        }

        [TestMethod()]
        public void zwrocZdarzenieTest()
        {
            WypelnienieTestowymi daneTestowe = new WypelnienieTestowymi();
            RepozytoriumDanych repozytorium;
            repozytorium = new RepozytoriumDanych(daneTestowe);
            Wypozyczenie wypozyczenie;
            StanGry gra;
            string nazwaGry;
            int liczbaEgzemplarzyGry;
            float cenaGry;
            Klient klient;
            string imieKlienta;
            string nazwiskoKlienta;
            string nrDowoduKlienta;
            DateTime dataWypozyczenia;
            DateTime dataOddania;

            wypozyczenie = (Wypozyczenie)repozytorium.zwrocZdarzenie(0);
            gra = wypozyczenie.zwrocStanGry();
            nazwaGry = gra.zwrocNazweGry();
            liczbaEgzemplarzyGry = gra.zwrocLiczbeEgzemplarzy();
            cenaGry = gra.zwrocCeneWypozyczenia();
            klient = wypozyczenie.zwrocWypozyczajacego();
            imieKlienta = klient.zwrocImie();
            nazwiskoKlienta = klient.zwrocNazwisko();
            nrDowoduKlienta = klient.zwrocNumerDowodu();
            dataWypozyczenia = wypozyczenie.zwrocDateWypozyczenia();
            dataOddania = wypozyczenie.zwrocDateOddania();

            Assert.AreEqual("nazwa", nazwaGry);
            Assert.AreEqual(1, liczbaEgzemplarzyGry);
            Assert.AreEqual(100f, cenaGry);
            Assert.AreEqual("imie", imieKlienta);
            Assert.AreEqual("nazwisko", nazwiskoKlienta);
            Assert.AreEqual("numerDowodu", nrDowoduKlienta);
            Assert.AreEqual("01.01.0001 00:00:00", dataWypozyczenia.ToString());
            Assert.AreEqual("02.02.0002 00:00:00", dataOddania.ToString());
        }

        [TestMethod()]
        public void zwrocWszystkieZdarzeniaTest()
        {
            WypelnienieTestowymi daneTestowe = new WypelnienieTestowymi();
            RepozytoriumDanych repozytorium;
            repozytorium = new RepozytoriumDanych(daneTestowe);
            ObservableCollection<Zdarzenie> zdarzenia;

            zdarzenia = repozytorium.zwrocWszystkieZdarzenia();

            Assert.AreEqual(2, zdarzenia.Count);
        }

        [TestMethod()]
        public void aktualizujZdarzenieTest()
        {
            WypelnienieTestowymi daneTestowe = new WypelnienieTestowymi();
            RepozytoriumDanych repozytorium;
            repozytorium = new RepozytoriumDanych(daneTestowe);
            StanGry gra = new StanGry("test", 1, 1f);
            StanGry graTest;
            Klient klient = new Klient("test", "test", "test");
            Klient klientTest;
            DateTime a = new DateTime(1, 2, 3);
            Wypozyczenie wypozyczenieDoAktualizacji;
            Wypozyczenie wypozyczenieTest;
            wypozyczenieDoAktualizacji = new Wypozyczenie(gra, klient, a, a);
            string nazwaGry;
            int liczbaEgzemplarzyGry;
            float cenaGry;
            string imieKlienta;
            string nazwiskoKlienta;
            string nrDowoduKlienta;
            DateTime dataWypozyczenia;
            DateTime dataOddania;

            repozytorium.aktualizujZdarzenie(0, wypozyczenieDoAktualizacji);
            wypozyczenieTest = (Wypozyczenie)repozytorium.zwrocZdarzenie(0);
            graTest = wypozyczenieTest.zwrocStanGry();
            nazwaGry = graTest.zwrocNazweGry();
            liczbaEgzemplarzyGry = graTest.zwrocLiczbeEgzemplarzy();
            cenaGry = graTest.zwrocCeneWypozyczenia();
            klientTest = wypozyczenieTest.zwrocWypozyczajacego();
            imieKlienta = klientTest.zwrocImie();
            nazwiskoKlienta = klientTest.zwrocNazwisko();
            nrDowoduKlienta = klientTest.zwrocNumerDowodu();
            dataWypozyczenia = wypozyczenieTest.zwrocDateWypozyczenia();
            dataOddania = wypozyczenieTest.zwrocDateOddania();

            Assert.AreEqual("test", nazwaGry);
            Assert.AreEqual(1, liczbaEgzemplarzyGry);
            Assert.AreEqual(1f, cenaGry);
            Assert.AreEqual("test", imieKlienta);
            Assert.AreEqual("test", nazwiskoKlienta);
            Assert.AreEqual("test", nrDowoduKlienta);
            Assert.AreEqual("03.02.0001 00:00:00", dataWypozyczenia.ToString());
            Assert.AreEqual("03.02.0001 00:00:00", dataOddania.ToString());
        }

        [TestMethod()]
        public void usunZdarzenieTest()
        {
            WypelnienieTestowymi daneTestowe = new WypelnienieTestowymi();
            RepozytoriumDanych repozytorium;
            repozytorium = new RepozytoriumDanych(daneTestowe);
            int liczbaZdarzen;

            repozytorium.usunZdarzenie(0);
            liczbaZdarzen = repozytorium.zwrocWszystkieZdarzenia().Count;

            Assert.AreEqual(1, liczbaZdarzen);
        }

        [TestMethod()]
        public void dodajNowyStanGryTest()
        {
            WypelnienieTestowymi daneTestowe = new WypelnienieTestowymi();
            RepozytoriumDanych repozytorium;
            repozytorium = new RepozytoriumDanych(daneTestowe);
            StanGry gra = new StanGry("t", 1, 1f);
            int liczbaStanowGier;

            repozytorium.dodajNowyStanGry(gra);
            liczbaStanowGier = repozytorium.zwrocListeGier().Count;

            Assert.AreEqual(3, liczbaStanowGier);
        }

        [TestMethod()]
        public void zwrocStanGryTest()
        {
            WypelnienieTestowymi daneTestowe = new WypelnienieTestowymi();
            RepozytoriumDanych repozytorium;
            repozytorium = new RepozytoriumDanych(daneTestowe);
            StanGry stanGry;
            string nazwaGry;
            int liczbaGier;
            float cenaWypozyczeniaGry;

            stanGry = repozytorium.zwrocStanGry(0);
            nazwaGry = stanGry.zwrocNazweGry();
            liczbaGier = stanGry.zwrocLiczbeEgzemplarzy();
            cenaWypozyczeniaGry = stanGry.zwrocCeneWypozyczenia();

            Assert.AreEqual("nazwa", nazwaGry);
            Assert.AreEqual(1, liczbaGier);
            Assert.AreEqual(100f, cenaWypozyczeniaGry);
        }

        [TestMethod()]
        public void zwrocListeGierTest()
        {
            WypelnienieTestowymi daneTestowe = new WypelnienieTestowymi();
            RepozytoriumDanych repozytorium;
            repozytorium = new RepozytoriumDanych(daneTestowe);
            List<StanGry> lista;
            int liczbaGier;

            lista = repozytorium.zwrocListeGier();
            liczbaGier = lista.Count;

            Assert.AreEqual(2, liczbaGier);
        }

        [TestMethod()]
        public void aktualizujStanGryTest()
        {
            WypelnienieTestowymi daneTestowe = new WypelnienieTestowymi();
            RepozytoriumDanych repozytorium;
            repozytorium = new RepozytoriumDanych(daneTestowe);
            StanGry stanGry = new StanGry("t", 12, 1f);
            string nazwaGry;
            int liczbaGier;
            float cenaGry;

            repozytorium.aktualizujStanGry(0, stanGry);
            nazwaGry = repozytorium.zwrocStanGry(0).zwrocNazweGry();
            liczbaGier = repozytorium.zwrocStanGry(0).zwrocLiczbeEgzemplarzy();
            cenaGry = repozytorium.zwrocStanGry(0).zwrocCeneWypozyczenia();

            Assert.AreEqual("t", nazwaGry);
            Assert.AreEqual(12, liczbaGier);
            Assert.AreEqual(1f, cenaGry);
        }

        [TestMethod()]
        public void usunStanGryTest()
        {
            WypelnienieTestowymi daneTestowe = new WypelnienieTestowymi();
            RepozytoriumDanych repozytorium;
            repozytorium = new RepozytoriumDanych(daneTestowe);
            int liczbaStanowGier;

            repozytorium.usunStanGry(1);
            liczbaStanowGier = repozytorium.zwrocListeGier().Count;

            Assert.AreEqual(1, liczbaStanowGier);
        }
    }
}