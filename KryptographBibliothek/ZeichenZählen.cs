using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace KryptographBibliothek
{
    public class ZeichenZählen
    {
        public static void Zaehlen()
        {
            string gef_chiffre = "Klyulbl";

            //Dictionary deklarieren
            Dictionary<string, Int16> Dictionary = new Dictionary<string, Int16>();
            
            gef_chiffre = gef_chiffre.ToUpper();
            for (int i =0; i < gef_chiffre.Length; i++)
            {
             
                int count = gef_chiffre.Count(a => a == gef_chiffre[i]);
                Console.WriteLine($"{gef_chiffre[i]}\t{count}");

                bool keyExists = Dictionary.ContainsKey(gef_chiffre);
                if (Dictionary.ContainsKey(char.ToString(gef_chiffre[i])));
                {
                    Console.WriteLine();            
                }
                //Zeile in Dictionary hinzufügen, wenn Zeichen nicht bereits vorhanden
            }
        }
    }
}
