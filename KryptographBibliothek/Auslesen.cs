using System;

namespace KryptographBibliothek
{
    public class Auslesen
    {
        public static void AuslesenChiffre(string pfad)
        {
            Console.WriteLine("wir sind beim Auslesen");


            string text = System.IO.File.ReadAllText(@"C:\Users\emrecan.z2\source\repos\Cracked_MH_Kryptograph\Chiffre.txt");
            
           System.Console.WriteLine("Inhalt der Datei Textlesen.txt = {0}", text);

            
        
        }
    }
}
