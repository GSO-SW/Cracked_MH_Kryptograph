using System;

namespace KryptographBibliothek
{
    public class ZeichenEntfernen
    {
        public static string Zeichenentfernen(string chiffre)
        {
            bool wiederholen = true;
            do
            {
                string wiederholenauswahl;
                string entfernenauswahl;
                wiederholen = true;
              
                string chiffrebuffer = chiffre;

                Console.WriteLine(chiffre);

                Console.WriteLine("Welche Zeichen möchten Sie entfernen?");
                entfernenauswahl = Console.ReadLine();










                Console.WriteLine("Möchten Sie noch etwas entfernen?");
                wiederholenauswahl = Console.ReadLine();
                if (wiederholenauswahl == "Ja")
                {
                    wiederholen = true;
                }

                else if (wiederholenauswahl == "Nein")
                {
                    wiederholen = false;
                }





            } while (wiederholen == true);



            Console.Write(chiffre);
                
            string chiffre_neu;
                return chiffre_neu;
         
        }
    }
}