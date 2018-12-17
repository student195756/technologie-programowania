using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie1
{
    [Serializable()]
    public class Oddanie : Zdarzenie
    {
        public Oddanie(int idGry, int idWypozyczajacego, DateTime dataWypozyczenia, DateTime dataOddania)
        {
            this.idWypozyczajacego = idWypozyczajacego;
            this.idGry = idGry;
            this.dataWypozyczenia = dataWypozyczenia;
            this.dataOddania = dataOddania;
            this.rodzajZdarzenia = "oddanie";
        }
    }
}