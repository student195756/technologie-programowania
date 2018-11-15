using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie1
{
    abstract class WypelnienieDanymi
    {
        public BazaDanych wypelnij()
        {
            BazaDanych baza = new BazaDanych();
            baza.wykazKlientow = null;
            baza.katalogGier = null;
            baza.transakcje = null;
            baza.stanGier = null;
            return baza;
        }
    }
}