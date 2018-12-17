using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace zadanie1
{
    public class WypelnienieZPliku : WypelnienieDanymi
    {
        private string sciezkaPliku;
        public WypelnienieZPliku(string sciezkaPliku)
        {
            this.sciezkaPliku = sciezkaPliku;
        }

        public override BazaDanych wypelnij()
        {
            BazaDanych baza = new BazaDanych();
            Stream strumien = File.Open(sciezkaPliku, FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();

            baza = (BazaDanych) bf.Deserialize(strumien);
            strumien.Close();

            return baza;
        }
    }
}
