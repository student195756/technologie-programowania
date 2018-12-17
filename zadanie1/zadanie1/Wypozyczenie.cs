using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace zadanie1
{
    [Serializable()]
    public class Wypozyczenie : Zdarzenie
    {
        public Wypozyczenie(int idGry, int idWypozyczajacego, DateTime dataWypozyczenia, DateTime dataOddania)
        {
            this.idWypozyczajacego = idWypozyczajacego;
            this.idGry = idGry;
            this.dataWypozyczenia = dataWypozyczenia;
            this.dataOddania = dataOddania;
            this.rodzajZdarzenia = "wypozyczenie";
        }

        public Wypozyczenie(SerializationInfo info, StreamingContext context)
        {
            idWypozyczajacego = (int)info.GetValue("id wypozyczajacego", typeof(int));
            idGry = (int)info.GetValue("id gry", typeof(int));
            dataWypozyczenia = (DateTime)info.GetValue("data wypozyczenia", typeof(DateTime));
            dataOddania = (DateTime)info.GetValue("data oddania", typeof(DateTime));
            rodzajZdarzenia = (string)info.GetValue("rodzaj zdarzenia", typeof(string));
        }


    }
}