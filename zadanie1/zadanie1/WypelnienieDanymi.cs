using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace zadanie1
{
    public abstract class WypelnienieDanymi
    {
        protected BazaDanych baza;

        public virtual BazaDanych wypelnij()
        {
            baza = new BazaDanych();
            baza.wykazKlientow = null;
            baza.katalogGier = null;
            baza.stanGier = null;
            return baza;
        }
    }
}