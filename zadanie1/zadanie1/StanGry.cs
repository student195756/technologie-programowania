using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace zadanie1
{
    [Serializable()]
    public class StanGry : ISerializable
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

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("nazwa gry", nazwaGry);
            info.AddValue("liczba egzemplarzy gry", liczbaEgzemplarzy);
            info.AddValue("cena wypozyczenia gry", cenaWypozyczenia);
        }

        public StanGry(SerializationInfo info, StreamingContext context)
        {
            nazwaGry = (string)info.GetValue("nazwa gry", typeof(string));
            liczbaEgzemplarzy = (int)info.GetValue("liczba egzemplarzy gry", typeof(int));
            cenaWypozyczenia = (float)info.GetValue("cena wypozyczenia gry", typeof(float));
        }
    }
}
