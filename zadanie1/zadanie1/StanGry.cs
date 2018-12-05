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

        public StanGry(string nazwaGry, int liczbaEgzemplarzy, float cenaWypozyczenia)
        {
            this.nazwaGry = nazwaGry;
            this.liczbaEgzemplarzy = liczbaEgzemplarzy;
            this.cenaWypozyczenia = cenaWypozyczenia;
        }

        public string zwrocNazweGry()
        {
            return this.nazwaGry;
        }

        public float zwrocCeneWypozyczenia()
        {
            return this.cenaWypozyczenia;
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
