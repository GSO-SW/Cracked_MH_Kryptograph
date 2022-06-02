using System;
using System.IO;

namespace KryptographBibliothek
{
    public class Auslesen
    {
        public static string AuslesenChiffre(string pfad)
        {   
            Console.WriteLine(pfad);


            string chiffre = System.IO.File.ReadAllText(pfad);


            return chiffre;
        }
    }
}
