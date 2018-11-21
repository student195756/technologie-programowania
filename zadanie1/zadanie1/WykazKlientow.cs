using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie1
{
    public class WykazKlientow
    {
        public List<Klient> klienci = new List<Klient>();

        public void dodajKlienta(string imie, string nazwisko, string numerDowodu)
        {
            klienci.Add( new Klient(imie, nazwisko, numerDowodu) );
        }

    }
}
