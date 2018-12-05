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
    }
}
