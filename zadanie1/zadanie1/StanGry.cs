using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie1
{
    public class StanGry
    {
        private string nazwaGry;
        private int liczbaEgzemplarzy;
        private float cenaWypozyczenia;
        private string opis;

        // zakomentowane do czasu ogarniecia katalogu gier
        //public StanGry(string nazwaGry, int liczbaEgzemplarzy, float cenaWypozyczenia, KatalogGier katalog)
        //{
        //    this.nazwaGry = nazwaGry;
        //    this.liczbaEgzemplarzy = liczbaEgzemplarzy;
        //    this.cenaWypozyczenia = cenaWypozyczenia;
        //    this.opis = katalog.zwrocOpisGry(nazwaGry);
        //}

        //temporary solution
        public StanGry(string nazwaGry, int liczbaEgzemplarzy, float cenaWypozyczenia)
        {
            this.nazwaGry = nazwaGry;
            this.liczbaEgzemplarzy = liczbaEgzemplarzy;
            this.cenaWypozyczenia = cenaWypozyczenia;
        }

        public int zwrocLiczbeEgzemplarzy()
        {
            return liczbaEgzemplarzy;
        }

        public void ustawLiczbeEgzemplarzy(int liczbaEgzemplarzy)
        {
            this.liczbaEgzemplarzy = liczbaEgzemplarzy;
        }

    }
}
