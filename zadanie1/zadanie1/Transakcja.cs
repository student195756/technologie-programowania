﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie1
{
    class Transakcja : Zdarzenie
    {
        private Klient wypozyczajacy;
        private Gra gra;
        private DateTime dataWypozyczenia;
        private DateTime dataOddania;

        public Transakcja(Gra gra, Klient wypozyczajacy, DateTime dataWypozyczenia, DateTime dataOddania)
        {
            this.wypozyczajacy = wypozyczajacy;
            this.gra = gra;
            this.dataWypozyczenia = dataWypozyczenia;
            this.dataOddania = dataOddania;
        }

        public void wypozyczGre(StanGry gra, Klient klient)
        {
            int liczbaEgzemplarzy = gra.zwrocLiczbeEgzemplarzy();

            if(liczbaEgzemplarzy > 0)
            {
                gra.ustawLiczbeEgzemplarzy(liczbaEgzemplarzy - 1);
                dataWypozyczenia = DateTime.UtcNow.ToLocalTime();
                dataOddania = DateTime.UtcNow.ToLocalTime().AddDays(14);
            }
            else
            {
                Console.Write("Transakcja niemozliwa - brak gry na stanie");
            }
        }
    }
}
