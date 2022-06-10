using System;
using System.Collections.Generic;
using System.Linq;

namespace KryptographBibliothek
{
    public class TabelleAuslesen
    {
        public static Dictionary<string, double> Auslesen(string Pfad)
        {
            
            string[] lines = System.IO.File.ReadAllLines(Pfad);
            


            var dictionary = new Dictionary<string, double>();
           
            foreach(string rows in lines)
            {
                string[] row_items = rows.Split('\t',' ','%');
                                              
                    dictionary.Add((row_items[0]), Convert.ToDouble(row_items[1]));
                    //Console.WriteLine(row_items[0] + " und " + row_items[1]);
                    
               
                 
            }
            return dictionary;
        }
    }
} 
