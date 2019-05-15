using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class ManowarPlaat
    {
        private string naam;
        private int waarde;

        public ManowarPlaat(String nNaam,int nWaarde)
        {
            naam = nNaam;
            waarde = nWaarde;
        }

        public override string ToString()
        {
            return naam;
        }

    }

}
