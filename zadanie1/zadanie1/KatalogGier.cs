using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie1
{
    class KatalogGier
    {
                        // tytuł gry, opis
        private Dictionary<string, string> slownikKatalogu = new Dictionary<string, string>();

        public void dodajWpis(string tytulGry, string opis)
        {
            slownikKatalogu.Add(tytulGry, opis);
        }

        public string zwrocOpisGry(string tytulGry)
        {
            return slownikKatalogu[tytulGry];
        }
    }
}
