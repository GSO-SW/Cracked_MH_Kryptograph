using System;

namespace KryptographBibliothek
{
    public class Auslesen
    {
        public static void AuslesenChiffre()
        {
            Console.WriteLine("wir sind beim Auslesen");


            string text = System.IO.File.ReadAllText(@"\\BK175055\emrecan.z2\Download\Chiffre.txt");
            
           System.Console.WriteLine("Inhalt der Datei Textlesen.txt = {0}", text);

            
        
        }
    }
}
