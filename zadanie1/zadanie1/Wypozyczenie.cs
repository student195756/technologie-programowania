using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie1
{
    public class Wypozyczenie : Zdarzenie
    {
        private int idWypozyczajacego;
        private int idGry;
        private DateTime dataWypozyczenia;
        private DateTime dataOddania;

        public Wypozyczenie(int idGry, int idWypozyczajacego, DateTime dataWypozyczenia, DateTime dataOddania)
        {
            this.idWypozyczajacego = idWypozyczajacego;
            this.idGry = idGry;
            this.dataWypozyczenia = dataWypozyczenia;
            this.dataOddania = dataOddania;
        }

        public int zwrocIdGry()
        {
            return this.idGry;
        }

        public int zwrocIdWypozyczajacego()
        {
            return this.idWypozyczajacego;
        }

        public DateTime zwrocDateWypozyczenia()
        {
            return this.dataWypozyczenia;
        }

        public DateTime zwrocDateOddania()
        {
            return this.dataOddania;
        }
    }
}