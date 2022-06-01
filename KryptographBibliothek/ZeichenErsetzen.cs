using System;
using System.Collections.Generic;
using System.Linq;

namespace KryptographBibliothek
{
    public class ZeichenErsetzen
    {
        public static string ZeichenErsetzenMethode(string chiffre, Dictionary<string, double> Z_W_Chiffre, Dictionary<string, double> Z_W_Deutsch)
        {



            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("------------------------------------------------------------------------------------\n" +
            " >>> Schlüssel <<<\n" +
            "------------------------------------------------------------------------------------\n\n");


           
            ///beide Dictionarys sortieren
            ///
            var sortedDict_chiffre = from entry in Z_W_Chiffre orderby entry.Value ascending select entry;
            var sortedDict_deutsch = from entry in Z_W_Deutsch orderby entry.Value ascending select entry;
            
            //Z_W_Englisch = Z_W_Englisch.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            //for (int i = 0; i < Z_W_Deutsch.Count; i++)
            //{
            //    chiffre.Replace(sortedDict_chiffre.ElementAt(sortedDict_chiffre.Count() - i - 1).Key, sortedDict_deutsch.ElementAt(sortedDict_deutsch.Count() - i - 1).Key);

            //}



            for(int i =0; i < chiffre.Length; i++)
            {
                char zeichen = chiffre[i];

                if (sortedDict_chiffre.ToString().Contains(zeichen))
                {
                    bool erfolgsindikator = false;
                    int index = 0;
                    for (int f = 0; f < sortedDict_chiffre.Count(); f++)
                    {
                        erfolgsindikator = chiffre[i] == sortedDict_chiffre.;
                    }

                        




                }

            }
           
            Console.WriteLine(chiffre);
            return "";
        }
    }
}
