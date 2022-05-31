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

         
            Dictionary<char, double> Zeichenzahl = new Dictionary<char, double>();

            
            gef_chiffre = gef_chiffre.ToUpper();
            for (int i =0; i < gef_chiffre.Length; i++)
            {
             
                int count = gef_chiffre.Count(a => a == gef_chiffre[i]);
                Console.WriteLine($"{gef_chiffre[i]}\t{count}");

              for(int ia = 0; ia <= gef_chiffre.Length;ia++)
              {
                                    
                bool keyExists = Zeichenzahl.ContainsKey(gef_chiffre[ia]);
                if (!keyExists) 
                {
                    Zeichenzahl.Add(gef_chiffre[i], count / gef_chiffre.Length);
                    Console.WriteLine("fortnite");            
                }
              }
            }
        }
    }
}
