using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Adres
    {
        private string Straat;
        private string Nummer;
        private string Postcode;
        private string Gemeente;

        public Adres(string Ustraat, string Unummer, string UPostcode, string Ugemeente)
        {
            Straat = Ustraat;
            Nummer = Unummer;
            Postcode = UPostcode;
            Gemeente = Ugemeente;
        }

        public override string ToString()
        {
            return "Adres=" + Straat + " " + Nummer + ", " + Postcode + " " + Gemeente;
        }
    }

}
