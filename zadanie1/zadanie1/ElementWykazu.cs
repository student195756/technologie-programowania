using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie1
{
    class ElementWykazu
    {
        private Klient klient;
        private int id;

        ElementWykazu(string imie, string nazwisko, string numerDowodu)
        {
            klient = new Klient(imie, nazwisko, numerDowodu);
        }
    }
}
