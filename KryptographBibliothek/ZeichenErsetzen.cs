using System;
using System.Collections.Generic;
using System.Linq;

namespace KryptographBibliothek
{
    public class ZeichenErsetzen
    {
        public static string ZeichenErsetzenMethode(string chiffre, Dictionary<string, double> Z_W_Chiffre, Dictionary<string, double> Z_W_Deutsch)
        {
            //man kann nicht direkt den string 
            char[] ChiffreInArray;
            string konvertierteChiffre = "fortnighte";
            ChiffreInArray = chiffre.ToCharArray();


            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("------------------------------------------------------------------------------------\n" +
            " >>> Schlüssel <<<\n" +
            "------------------------------------------------------------------------------------\n\n");
            //wird konvertiert
            Z_W_Chiffre = Z_W_Chiffre.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            Z_W_Deutsch = Z_W_Deutsch.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            ///beide Dictionarys sortieren
            ///
            var sortedDict_chiffre = from entry in Z_W_Chiffre orderby entry.Value ascending select entry;
            var sortedDict_deutsch = from entry in Z_W_Deutsch orderby entry.Value ascending select entry;


            


            for (int i = 0; i < chiffre.Length; i++)
            {

                if (sortedDict_chiffre.ToString().Contains(chiffre[i]))
                {
                    //CS0200 C# Für die Eigenschaft oder den Indexer "string.this[int]" ist eine Zuweisung nicht möglich. Sie sind schreibgeschützt.
                    int indexzwischenspeicher = sortedDict_deutsch.ToString().IndexOf(chiffre[i]);
                    //ChiffreInArray[i] = sortedDict_deutsch.ToString().ElementAt(indexzwischenspeicher);
                    Console.WriteLine(ChiffreInArray[i] = sortedDict_chiffre.ToString().ElementAt(indexzwischenspeicher));
                    konvertierteChiffre = new string(ChiffreInArray);
                   
                }
            }
            Console.WriteLine(konvertierteChiffre);
            return konvertierteChiffre;
        }

        
            
        
    }
}