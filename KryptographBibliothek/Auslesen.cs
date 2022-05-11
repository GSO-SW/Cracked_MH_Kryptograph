using System;
using System.IO;

namespace KryptographBibliothek
{
    public class Auslesen
    {
        public static  AuslesenChiffre(string pfad )
        {
            Console.WriteLine("wir sind beim Auslesen");


            string text = System.IO.File.ReadAllText(@"C:\Users\emrecan.z2\source\repos\Cracked_MH_Kryptograph\Chiffre.txt");
            
           System.Console.WriteLine("Inhalt der Datei Textlesen.txt = {0}", text);

            string pfad1 = (@"C:\Users\emrecan.z2\source\repos\Cracked_MH_Kryptograph\Chiffre.txt");
            




            

            //Übergebene Pfad wird nicht genutzt
            //Rückgabe der Chiffre in Methode umsetzen

           
        }
    }
}
