using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace zadanie1
{
    [Serializable()]
    public class BazaDanych : ISerializable
    {
        public List<Klient> wykazKlientow = new List<Klient>();
        public KatalogGier katalogGier = new KatalogGier();
        public ObservableCollection<Zdarzenie> zdarzenia = new ObservableCollection<Zdarzenie>();
        public List<StanGry> stanGier = new List<StanGry>();

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("wykaz klientow", wykazKlientow);
            info.AddValue("katalog gier", katalogGier);
            info.AddValue("zdarzenia", zdarzenia);
            info.AddValue("stanGier", stanGier);
        }

        public BazaDanych() { }
        public BazaDanych(SerializationInfo info, StreamingContext context)
        {
            wykazKlientow = ( List<Klient>) info.GetValue("wykaz klientow", typeof(List<Klient>) );
            katalogGier = (KatalogGier) info.GetValue( "katalog gier", typeof(KatalogGier) );
            zdarzenia = (ObservableCollection<Zdarzenie>) info.GetValue( "zdarzenia", typeof(ObservableCollection<Zdarzenie>) );
            stanGier = (List<StanGry>) info.GetValue( "stanGier", typeof(List<StanGry>) );
        }
    }
}
