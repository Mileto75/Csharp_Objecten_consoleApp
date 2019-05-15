using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Verkoper : User
    {
        public Verkoper(string vnaam, string vvnaam)
        {
            Naam = vnaam;
            Vnaam = vvnaam;
        }
    }
}
