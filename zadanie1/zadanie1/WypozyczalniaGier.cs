using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie1
{
    class WypozyczalniaGier
    {
        private RepozytoriumDanych repozytorium;
        public WypozyczalniaGier(RepozytoriumDanych repozytorium)
        {
            this.repozytorium = repozytorium;
        }

        public void wyswietlOpisGry(string tytulGry)
        {
            string opisGry;

            opisGry = repozytorium.zwrocInformacjeKatalogoweGry(tytulGry);
            Console.Write(opisGry);
        }

        public void wyswietlPozycjeKatalogu()
        {
            Dictionary<string, string> slownikKatalogu;
            List<string> pozycjeKatalogowe;

            slownikKatalogu = repozytorium.zwrocInformacjeKatalogoweWszystkichGier();
            pozycjeKatalogowe = new List<string>(slownikKatalogu.Keys);

            foreach(string i in pozycjeKatalogowe)
            {
                Console.WriteLine(i);
            }
        }

        public void wyswietlKlienta(int id)
        {
            Klient klient;

            klient = repozytorium.zwrocKlienta(id);

            Console.WriteLine( "imie: " + klient.zwrocImie() );
            Console.WriteLine( "nazwisko: " + klient.zwrocNazwisko() );
            Console.WriteLine( "numer dowodu: " + klient.zwrocNumerDowodu() );
        }

        public void wyswietlStanGry(int id)
        {
            StanGry gra;

            gra = repozytorium.zwrocStanGry(id);

            Console.WriteLine("gra: " + gra.zwrocNazweGry());
            Console.WriteLine("liczba: " + gra.zwrocLiczbeEgzemplarzy());
            Console.WriteLine("cena wypozyczenia: " + gra.zwrocCeneWypozyczenia());
        }

        public void wyswietlZdarzenie(int id)
        {
            Zdarzenie zdarzenie = repozytorium.zwrocZdarzenie(id);
            Klient klient;
            int idWypozyczajacego = zdarzenie.zwrocIdWypozyczajacego();
            string imieKlienta;
            string nazwiskoKlienta;
            string numerDowoduKlienta;
            StanGry gra;
            int idGry = zdarzenie.zwrocIdGry();
            string nazwaGry;
            float cenaWypozyczenia;
            DateTime dataWypozyczenia;
            string dataWypozyczeniaString;
            DateTime dataOddania;
            string dataOddaniaString;

            dataWypozyczenia = zdarzenie.zwrocDateWypozyczenia();
            dataWypozyczeniaString = dataWypozyczenia.ToString();
            dataWypozyczeniaString = dataWypozyczeniaString.Substring(0, 10);
            dataOddania = zdarzenie.zwrocDateOddania();
            dataOddaniaString = dataOddania.ToString();
            dataOddaniaString = dataOddaniaString.Substring(0, 10);

            klient = repozytorium.zwrocKlienta(idWypozyczajacego);
            imieKlienta = klient.zwrocImie();
            nazwiskoKlienta = klient.zwrocNazwisko();
            numerDowoduKlienta = klient.zwrocNumerDowodu();

            gra = repozytorium.zwrocStanGry(idGry);
            nazwaGry = gra.zwrocNazweGry();
            cenaWypozyczenia = gra.zwrocCeneWypozyczenia();
            
            Console.WriteLine( zdarzenie.zwrocRodzajZdarzenia() );
            Console.WriteLine();
            Console.WriteLine("Klient");
            Console.WriteLine();
            Console.WriteLine(imieKlienta + " " + nazwiskoKlienta);
            Console.WriteLine("identyfikujacy sie dowodem numer: " + numerDowoduKlienta);
            Console.WriteLine();
            Console.WriteLine("gra: " + nazwaGry);
            Console.WriteLine("koszt wypozyczenia:" + cenaWypozyczenia);
            Console.WriteLine("data wypozyczenia: " + dataWypozyczeniaString);
            Console.WriteLine("data oddania: " + dataOddaniaString);
        }
    }
}
