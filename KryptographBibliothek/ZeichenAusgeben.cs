using System;

namespace KryptographBibliothek
{
    public class ZeichenAusgeben
    {
        public static void AusgebenZeichen(string chiffre, string fertig_chiff)
        {

           
            


            Console.WriteLine("Ergebnis");
            Console.WriteLine("__________________________");

            Console.WriteLine(chiffre, "\n");

            Console.WriteLine("--------------------------");

            for (int i = 0; i < chiffre.Length; i++)
            {
                if (chiffre[i] != fertig_chiff[i])
                {
                    Console.BackgroundColor
                    = ConsoleColor.Red;
                    Console.Write(fertig_chiff[i]);
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Write(fertig_chiff[i]);
                }

                //Huier ist dfer Hintergrund entweder Rot oder Schwarz




            }

            Console.BackgroundColor = ConsoleColor.Black;

           
        }
        
    }
}

