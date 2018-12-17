using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace zadanie1
{
    [Serializable()]
    public class Klient : ISerializable
    {
        private string imie;
        private string nazwisko;
        private string numerDowodu;

        public Klient(string imie, string nazwisko, string numerDowodu)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.numerDowodu = numerDowodu;
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("imie klienta", imie);
            info.AddValue("nazwisko klienta", nazwisko);
            info.AddValue("numer dowodu klienta", numerDowodu);
        }

        public Klient(SerializationInfo info, StreamingContext context)
        {
            imie = (string)info.GetValue("imie klienta", typeof(string));
            nazwisko = (string)info.GetValue("nazwisko klienta", typeof(string));
            numerDowodu = (string)info.GetValue("numer dowodu klienta", typeof(string));
        }

        public string zwrocImie()
        {
            return this.imie;
        }

        public string zwrocNazwisko()
        {
            return this.nazwisko;
        }

        public string zwrocNumerDowodu()
        {
            return this.numerDowodu;
        }

    }
}
