using System;

namespace KryptographBibliothek
{
    public class ZeichenAusgeben
    {
        public static void AusgebenZeichen()
        {

            string chiffre = "Kal, ";
            string klartext = "Das, ";


            Console.WriteLine("Ergebnis");
            Console.WriteLine("__________________________");

            Console.WriteLine(chiffre, "\n");

            Console.WriteLine("--------------------------");

            for (int i = 0; i < chiffre.Length; i++)
            {
                if (chiffre[i] != klartext[i])
                {
                    Console.BackgroundColor
                    = ConsoleColor.Red;
                    Console.Write(klartext[i]);
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Write(klartext[i]);
                }

                //Huier ist dfer Hintergrund entweder Rot oder Schwarz




            }

            Console.BackgroundColor = ConsoleColor.Black;

           
        }
        
    }
}

