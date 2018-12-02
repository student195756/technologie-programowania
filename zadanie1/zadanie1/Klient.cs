﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie1
{
    public class Klient
    {
        private string imie;
        private string nazwisko;
        private string numerDowodu;

        public Klient(string imie, string nazwisko, string numerDowodu)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.numerDowodu = numerDowodu;

            Console.Write("utworzono klienta o imieniu ");
            Console.WriteLine(imie);
            Console.Write("nazwisku ");
            Console.WriteLine(nazwisko);
            Console.Write("numerze dowodu ");
            Console.WriteLine(numerDowodu);
        }

        public string zwrocImie()
        {
            return this.imie;
        }

        public string zwrocNazwisko()
        {
            return this.nazwisko;
        }

        public string zwrocNumerDowodu()
        {
            return this.numerDowodu;
        }

    }
}
