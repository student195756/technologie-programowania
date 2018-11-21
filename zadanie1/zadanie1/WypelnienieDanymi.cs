using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie1
{
    public abstract class WypelnienieDanymi
    {
        public virtual BazaDanych wypelnij()
        {
            BazaDanych baza = new BazaDanych();
            baza.wykazKlientow = null;
            baza.katalogGier = null;
            baza.stanGier = null;
            return baza;
        }
    }
}