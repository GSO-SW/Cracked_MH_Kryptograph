using System;

namespace KryptographBibliothek
{
    public class ZeichenEntfernen
    {
        public static string Zeichenentfernen(string chiffre)
        {
            bool wiederholen = true;
            bool falscheeingabe = false;
            
            do
            {
                string wiederholenauswahl;
                string entfernenauswahl;
                wiederholen = true;
              
                string chiffrebuffer = chiffre;

                Console.WriteLine(chiffre + "\n\n");

                Console.WriteLine("Welche Zeichen möchten Sie entfernen? \n\n");
                entfernenauswahl = Console.ReadLine();
                Console.WriteLine();

                string[] immer_ent = { "Ü", "Ä", "Ö", "'", "!", "%", " " };

                chiffre = chiffre.Replace(entfernenauswahl, "");

                Console.WriteLine(chiffre + "\n\n");

                do
                {
                    falscheeingabe = false;
                    Console.WriteLine("Möchten Sie noch etwas entfernen? Bitte antworten Sie mit 'Ja' oder 'Nein'.");
                    wiederholenauswahl = Console.ReadLine();
                    Console.WriteLine();
                    if (wiederholenauswahl == "Ja")
                    {
                        wiederholen = true;
                        Console.WriteLine("Die neue Chiffre lautet:\n\n");
                    }

                    else if (wiederholenauswahl == "Nein")
                    {
                        wiederholen = false;
                        Console.WriteLine("Die neue Chiffre:\n\n");
                    }

                    else
                    {
                        falscheeingabe = true;
                        Console.WriteLine("Bitte benutzen Sie als Antwort entweder 'Ja' oder 'Nein'.\n\n Bitte drücken Sie eine beliebige Taste um es erneut zu versuchen.");
                        Console.ReadKey();
                    }

                } while (falscheeingabe == true);



            } while (wiederholen == true);



            Console.Write(chiffre);

            Console.WriteLine("\n\n");

            string chiffre_gefiltert = chiffre;

            return chiffre_gefiltert;
         
        }
    }
}