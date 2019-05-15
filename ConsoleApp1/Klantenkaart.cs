using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Klantenkaart
    {
        private int klantNr;
        private int klantKorting;

        public Klantenkaart(int Nr, int korting)
        {
            klantNr = Nr;
            klantKorting = korting;
        }

        public override string ToString()
        {
            return "Klantnr:" + klantNr.ToString() + ", korting:" + klantKorting.ToString();
        }
    }
}
