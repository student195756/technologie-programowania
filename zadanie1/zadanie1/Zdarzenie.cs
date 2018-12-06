using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie1
{
    public abstract class Zdarzenie
    {
        protected int idWypozyczajacego;
        protected int idGry;
        protected DateTime dataWypozyczenia;
        protected DateTime dataOddania;
        protected string rodzajZdarzenia;

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

        public string zwrocRodzajZdarzenia()
        {
            return this.rodzajZdarzenia;
        }
    }
}
