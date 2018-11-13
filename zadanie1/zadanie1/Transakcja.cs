using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie1
{
    class Transakcja
    {
        public void wypozyczGre(StanGry gra, Klient klient)
        {
            int liczbaEgzemplarzy = gra.zwrocLiczbeEgzemplarzy();
            DateTime dataWypozyczenia;
            DateTime dataOddania;

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
