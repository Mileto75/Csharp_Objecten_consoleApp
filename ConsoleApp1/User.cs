using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class User
    {
        protected string Naam;
        protected string Vnaam;
        protected string Email;
        protected string Password;
        public Adres Uadres; 

        public override string ToString()
        {
            return Naam;
        }

    }
}
