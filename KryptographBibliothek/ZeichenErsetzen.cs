using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Text;

namespace KryptographBibliothek
{
    public class ZeichenErsetzen
    {
        public static string ZeichenersetzenMethode(string chiffre, Dictionary<string, double> chiffre_tabelle, Dictionary<string, double> sprache_tabelle)
        {
            chiffre = chiffre.ToUpper();


            sprache_tabelle = sprache_tabelle.OrderByDescending(u => u.Value).ToDictionary(z => z.Key, y => y.Value);
            chiffre_tabelle = chiffre_tabelle.OrderByDescending(u => u.Value).ToDictionary(z => z.Key, y => y.Value);

            StringBuilder ch = new StringBuilder(chiffre);


            int index = 0;

            for (int i = 0; i < chiffre.Length; i++)
            {
                for (int r = 0; r < chiffre_tabelle.Count; r++)
                {
                    if (chiffre_tabelle.Keys.ElementAt(r) == chiffre[i].ToString())
                    {
                        index = r;

                        ch[i] = sprache_tabelle.Keys.ElementAt(index).ToCharArray()[0];

                    }



                }
            }





            return ch.ToString();
        }




    }
}