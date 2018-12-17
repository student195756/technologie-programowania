using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace zadanie1
{
    [Serializable()]
    public abstract class Zdarzenie : ISerializable
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

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("id wypozyczajacego", idWypozyczajacego);
            info.AddValue("id gry", idGry);
            info.AddValue("data wypozyczenia", dataWypozyczenia);
            info.AddValue("data oddania", dataOddania);
            info.AddValue("rodzaj zdarzenia", rodzajZdarzenia);
        }

        public Zdarzenie(SerializationInfo info, StreamingContext context)
        {
            idWypozyczajacego = (int)info.GetValue("id wypozyczajacego", typeof(int));
            idGry = (int)info.GetValue("id gry", typeof(int));
            dataWypozyczenia = (DateTime)info.GetValue("data wypozyczenia", typeof(DateTime));
            dataOddania = (DateTime)info.GetValue("data oddania", typeof(DateTime));
            rodzajZdarzenia = (string)info.GetValue("rodzaj zdarzenia", typeof(string));
        }
        public Zdarzenie()
        {
        }
    }
}
