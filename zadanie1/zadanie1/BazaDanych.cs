using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie1
{
    class BazaDanych
    {
        public WykazKlientow wykazKlientow;
        public KatalogGier katalogGier;
        public ObservableCollection<Transakcja> transakcje;
        public List<StanGry> stanGier;
    }
}
