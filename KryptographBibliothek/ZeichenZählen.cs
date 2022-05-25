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
            string gef_chiffre = "kyubii";

         
            Dictionary<string, double> Zeichenzahl = new Dictionary<string, double>();

            
            gef_chiffre = gef_chiffre.ToUpper();
            for (int i =0; i < gef_chiffre.Length; i++)
            {
             
                int count = gef_chiffre.Count(a => a == gef_chiffre[i]);
                Console.WriteLine($"{gef_chiffre[i]}\t{count}");

                bool keyExists = Zeichenzahl.ContainsKey(gef_chiffre);
                if (!keyExists) 
                {
                    Zeichenzahl.Add(gef_chiffre[i],count/gef_chiffre.Length);
                    Console.WriteLine();            
                }
                //Zeile in Dictionary hinzufügen, wenn Zeichen nicht bereits vorhanden
            }
        }
    }
}
