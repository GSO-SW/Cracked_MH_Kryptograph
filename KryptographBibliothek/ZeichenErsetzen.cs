using System;
using System.Collections.Generic;
using System.Linq;

namespace KryptographBibliothek
{
    public class ZeichenErsetzen
    {
        public static string ZeichenErsetzenMethode()
        {



            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("------------------------------------------------------------------------------------\n" +
            " >>> Schlüssel <<<\n" +
            "------------------------------------------------------------------------------------\n\n");
            string chiffre = "Kly ulbl";



            //K 1/7
            //L 3/7
            //Y 1/7
            //U 1/7
            //B 1/7




            Dictionary<string, double> tabelle_zeichen_deutsch = new Dictionary<string, double>();



            // Deutsch Wahrschenilichkeiten buchstaben



            tabelle_zeichen_deutsch.Add("A", 0.0558);
            tabelle_zeichen_deutsch.Add("Ä", 0.0054);
            tabelle_zeichen_deutsch.Add("B", 0.0196);
            tabelle_zeichen_deutsch.Add("C", 0.0316);
            tabelle_zeichen_deutsch.Add("D", 0.0498);
            tabelle_zeichen_deutsch.Add("E", 0.1693); // 0.14 = U
            tabelle_zeichen_deutsch.Add("F", 0.0149); // 0.14 = Y
            tabelle_zeichen_deutsch.Add("G", 0.0302);
            tabelle_zeichen_deutsch.Add("H", 0.0498); // 0.43 = L
            tabelle_zeichen_deutsch.Add("I", 0.0802);
            tabelle_zeichen_deutsch.Add("J", 0.0024);
            tabelle_zeichen_deutsch.Add("K", 0.0132); // 0.14 = K
            tabelle_zeichen_deutsch.Add("L", 0.0360);
            tabelle_zeichen_deutsch.Add("M", 0.0255);
            tabelle_zeichen_deutsch.Add("N", 0.1053);
            tabelle_zeichen_deutsch.Add("O", 0.0224);
            tabelle_zeichen_deutsch.Add("Ö", 0.0030);
            tabelle_zeichen_deutsch.Add("P", 0.0067);
            tabelle_zeichen_deutsch.Add("Q", 0.0002);
            tabelle_zeichen_deutsch.Add("R", 0.0689);
            tabelle_zeichen_deutsch.Add("ß", 0.0037);
            tabelle_zeichen_deutsch.Add("S", 0.0642);
            tabelle_zeichen_deutsch.Add("T", 0.0579);
            tabelle_zeichen_deutsch.Add("U", 0.0383);
            tabelle_zeichen_deutsch.Add("Ü", 0.0065);
            tabelle_zeichen_deutsch.Add("V", 0.0084);
            tabelle_zeichen_deutsch.Add("W", 0.0178);
            tabelle_zeichen_deutsch.Add("X", 0.0005);
            tabelle_zeichen_deutsch.Add("Y", 0.0005);
            tabelle_zeichen_deutsch.Add("Z", 0.0121); // 0.14 = B



            Dictionary<string, double> tabelle_zeichen_englisch = new Dictionary<string, double>();



            // Englich Wahrschenilichkeiten buchstaben
            tabelle_zeichen_englisch.Add("A", 0.0834);
            tabelle_zeichen_englisch.Add("B", 0.0154); // 0.14 = K
            tabelle_zeichen_englisch.Add("C", 0.0273);
            tabelle_zeichen_englisch.Add("D", 0.0414);
            tabelle_zeichen_englisch.Add("E", 0.1260); // 0.14 = U
            tabelle_zeichen_englisch.Add("F", 0.0203);
            tabelle_zeichen_englisch.Add("G", 0.0192);
            tabelle_zeichen_englisch.Add("H", 0.0611);
            tabelle_zeichen_englisch.Add("I", 0.0671);
            tabelle_zeichen_englisch.Add("J", 0.0023);
            tabelle_zeichen_englisch.Add("K", 0.0087);
            tabelle_zeichen_englisch.Add("L", 0.0424);
            tabelle_zeichen_englisch.Add("M", 0.0253);
            tabelle_zeichen_englisch.Add("N", 0.0680);
            tabelle_zeichen_englisch.Add("O", 0.0770);
            tabelle_zeichen_englisch.Add("P", 0.0166); // 0.14 = Y
            tabelle_zeichen_englisch.Add("Q", 0.0009);
            tabelle_zeichen_englisch.Add("R", 0.0568); // 0.43 = L
            tabelle_zeichen_englisch.Add("S", 0.0611);
            tabelle_zeichen_englisch.Add("T", 0.0937);
            tabelle_zeichen_englisch.Add("U", 0.0285);
            tabelle_zeichen_englisch.Add("V", 0.0106);
            tabelle_zeichen_englisch.Add("W", 0.0234); // 0.14 = B
            tabelle_zeichen_englisch.Add("X", 0.0020);
            tabelle_zeichen_englisch.Add("Y", 0.0204);
            tabelle_zeichen_englisch.Add("Z", 0.0006);



            Dictionary<string, double> tabelle_zeichen_chiffre = new Dictionary<string, double>();



            tabelle_zeichen_chiffre.Add("K", 0.14);
            tabelle_zeichen_chiffre.Add("L", 0.43);
            tabelle_zeichen_chiffre.Add("Y", 0.14);
            tabelle_zeichen_chiffre.Add("U", 0.14);
            tabelle_zeichen_chiffre.Add("B", 0.14);



            ///beise Dictionarys sortieren
            ///



            var sortedDict_chiffre = from entry in tabelle_zeichen_chiffre orderby entry.Value ascending select entry;
            var sortedDict_deutsch = from entry in tabelle_zeichen_deutsch orderby entry.Value ascending select entry;



            //tabelle_zeichen_chiffre = tabelle_zeichen_chiffre.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);






            for (int i = 0; i < tabelle_zeichen_chiffre.Count; i++)
            {



                chiffre.Replace(sortedDict_chiffre.ElementAt(sortedDict_chiffre.Count() - i - 1).Key, sortedDict_deutsch.ElementAt(sortedDict_deutsch.Count() - i - 1).Key);



                Console.WriteLine(chiffre);
            }




            return "";
        }
    }
}
