using System;

namespace KryptographBibliothek
{
    public class ZeichenEntfernen
    {
        public static string Zeichenentfernen(string chiffre)
        {
            bool wiederholen = true;
            bool falscheeingabe = false;
            Console.WriteLine(chiffre + "\n");
            do
            {
                string wiederholenauswahl;
                string entfernenauswahl;
                wiederholen = true;


                Console.WriteLine("\nWelche Zeichen möchten Sie entfernen?\n");
                entfernenauswahl = Console.ReadLine();


                chiffre = chiffre.Replace(entfernenauswahl, "");

                Console.WriteLine("\n\n--------------------------------------------------------------------------------------\n\nDie neue Chiffre lautet:\n\n");
                Console.WriteLine(chiffre + "\n\n");

                do
                {
                    falscheeingabe = false;
                    Console.WriteLine("Möchten Sie noch etwas entfernen? Bitte antworten Sie mit 'Ja' oder 'Nein'.\n");
                    wiederholenauswahl = Console.ReadLine();
                    if (wiederholenauswahl == "Ja")
                    {
                        wiederholen = true;                    
                    }

                    else if (wiederholenauswahl == "Nein")
                    {
                        wiederholen = false;
                    }

                    else
                    {
                        falscheeingabe = true;
                        Console.WriteLine("\nFalsche Eingabe. Bitte benutzen Sie als Antwort entweder 'Ja' oder 'Nein'.\n");
                    }

                } while (falscheeingabe == true);



            } while (wiederholen == true);

            Console.WriteLine("\n\n");

            string chiffre_gefiltert = chiffre;

            return chiffre_gefiltert;
         
        }
    }
}