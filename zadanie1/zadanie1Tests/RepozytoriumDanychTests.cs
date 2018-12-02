using Microsoft.VisualStudio.TestTools.UnitTesting;
using zadanie1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zadanie1Tests;

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
            Klient klientTestowy = new Klient("Lukasz", "Baczyk", "ABC123");

            repozytorium.dodajKlienta(klientTestowy);

            Assert.AreEqual( "Lukasz", repozytorium.zwrocKlienta(1).zwrocImie() );
            Assert.AreEqual( "Baczyk", repozytorium.zwrocKlienta(1).zwrocNazwisko() );
            Assert.AreEqual( "ABC123", repozytorium.zwrocKlienta(1).zwrocNumerDowodu() );
        }

        [TestMethod()]
        public void zwrocInformacjeKatalogoweGryTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void zaktualizujOpisGryTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void usunWpisKatalogowyTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void zwrocInformacjeKatalogoweWszystkichGierTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void dodajKlientaTest()
        {
            Assert.Fail();
        }
    }
}