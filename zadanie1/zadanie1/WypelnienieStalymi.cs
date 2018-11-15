﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie1
{
    class WypelnienieStalymi : WypelnienieDanymi
    {
        new BazaDanych wypelnij()
        {
            BazaDanych baza = new BazaDanych();
            baza.wykazKlientow.dodajKlienta("Lukasz", "Baczyk", "ABC123");
            baza.katalogGier.dodajWpis("magia i miecz", "fajna gra");
            baza.stanGier.Add( new StanGry("magia i miecz", 2, 30.0f) );
            baza.transakcje.Add(new Transakcja( new Gra("magia i miecz", "fajna gra"),
                                                new Klient("Zbigniew", "Paleta", "XYZ789"),
                                                new DateTime(2018, 11, 15),
                                                new DateTime(2018, 11, 29)
                                               ));

            return baza;
        }
    }
}
