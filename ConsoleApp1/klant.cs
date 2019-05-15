using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class klant : User
    {

        //toegevoegd aan klasse klant
        private string klantnr;

        //Aggregatie: platen worden hier gedefinieerd en van buitenaf toegevoegd
        public List<ManowarPlaat> aangekochtePlaten;
        //compositie object klantenkaart leeft intern
        //en sterft wanneer hoofdobject klant stopt met bestaan
        public Klantenkaart Kkaart = new Klantenkaart(11, 10);

        public klant(string Knummer,string Klnaam,string Kvnaam, string Kemail, string Kpaswoord)
        {
            Naam = Klnaam;
            Vnaam = Kvnaam;
            klantnr = Knummer;
            Email = Kemail;
            Password = Kpaswoord;
            //aggregatie: intern initialiseren en van buitenaf toevoegen
            aangekochtePlaten = new List<ManowarPlaat>();
            Uadres = new Adres("Langestraat", "67", "8370", "Blankenberge");
        }

        public override string ToString()
        {
            return Naam+": "+Uadres.ToString();    
        }


        //associatie 1 op 1
        public void bekijkPlaat(ManowarPlaat mp)
        {
            Console.WriteLine("Ik bekijk deze plaat:" + mp.ToString());
        }

        public void bekijkPlaten(List<ManowarPlaat> platen)
        {
            Console.WriteLine("Ik bekijk deze platen:");
            foreach (ManowarPlaat plaat in platen)
            {
                Console.WriteLine(plaat.ToString());
            }
        }
            
    }
}
