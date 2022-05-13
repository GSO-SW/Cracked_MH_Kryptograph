using System;

namespace StartKryptograph
{
    class main
    {
        static void Main(string[] AuslesenChiffre)
        {


            string pfad = @"C:\Users\emrecan.z2\Source\Repos\GSO-SW\Cracked_MH_Kryptograph\Chiffre.txt";

           string Chiffre= KryptographBibliothek.Auslesen.AuslesenChiffre(pfad);
            Console.WriteLine(Chiffre);


        }
    }
}
