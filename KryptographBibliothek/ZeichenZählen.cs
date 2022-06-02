using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace KryptographBibliothek
{
    public class ZeichenZählen
    {
        public static Dictionary<string, double> Zaehlen(string gef_chiffre)
        {
            
            bool keyExists = false;

            Dictionary<string, double> Zeichenzahl = new Dictionary<string, double>();

            gef_chiffre = gef_chiffre.ToUpper();
            for (int i =0; i < gef_chiffre.Length; i++)
            {
             
                int count = gef_chiffre.Count(a => a == gef_chiffre[i]);
                
                keyExists = Zeichenzahl.ContainsKey(gef_chiffre[i].ToString());
                
                if (!keyExists)
                {
                    Zeichenzahl.Add(gef_chiffre[i].ToString(),count/gef_chiffre.Length);
                    Console.WriteLine();            
                }
                //Zeile in Dictionary hinzufügen, wenn Zeichen nicht bereits vorhanden
            }
            Console.WriteLine(" ");
            return Zeichenzahl;
        }
    }
}
