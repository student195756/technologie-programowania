using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace zadanie1
{
    [Serializable()]
    public class KatalogGier : ISerializable
    {
                        // tytuł gry, opis
        private Dictionary<string, string> slownikKatalogu = new Dictionary<string, string>();

        public KatalogGier() { }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("slownik katalogu", slownikKatalogu);
        }

        public KatalogGier(SerializationInfo info, StreamingContext context)
        {
            slownikKatalogu = (Dictionary<string, string>)info.GetValue("slownik katalogu", typeof(Dictionary<string, string>));
        }

        public void dodajWpis(string tytulGry, string opis)
        {
            slownikKatalogu.Add(tytulGry, opis);
        }

        public string zwrocOpisGry(string tytulGry)
        {
            return slownikKatalogu[tytulGry];
        }

        public void ustawOpisGry(string tytulGry, string opis)
        {
            slownikKatalogu[tytulGry] = opis;
        }

        public Dictionary<string, string> zwrocSlownik()
        {
            return slownikKatalogu;
        }

        public void usunGre(string tytul)
        {
            slownikKatalogu.Remove(tytul);
        }
    }
}
