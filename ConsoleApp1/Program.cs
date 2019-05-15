using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            klant k = new klant("12","Di Marco","Mileto","mileto@mil.com","qsdkljfh45");
            ManowarPlaat m1 = new ManowarPlaat("Lords of metal", 5000);
            Console.WriteLine(k.ToString());
            Console.WriteLine(m1.ToString());
            //klant bekijkt plaat
            k.bekijkPlaat(m1);
            //klant koopt plaat
            k.aangekochtePlaten.Add(m1);
            //klant haalt klantenkaart uit voor korting
            Console.WriteLine(k.Kkaart.ToString());

           
            Adres v1Adres = new Adres("Langestraat", "67", "8370", "Blankenberge");
            Verkoper v1 = new Verkoper("Bouchouaram", "Kim");
            v1.Uadres = v1Adres;
            Console.WriteLine(v1.Uadres.ToString());
            v1 = null;
            Console.WriteLine(v1Adres.ToString());
            //end the program
            Console.ReadKey();
        }
    }
}
