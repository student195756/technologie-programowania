﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie1
{
    public class BazaDanych
    {
        public WykazKlientow wykazKlientow = new WykazKlientow();
        public KatalogGier katalogGier = new KatalogGier();
        public ObservableCollection<Zdarzenie> zdarzenia = new ObservableCollection<Zdarzenie>();
        public List<StanGry> stanGier = new List<StanGry>();
    }
}
