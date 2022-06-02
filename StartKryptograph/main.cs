using System;
using System.Collections.Generic;
using System.Linq;

namespace StartKryptograph
{
    class main
    {
        static void Main(string[] args)
        {
            string chiffre = "Kly ulbl KbhsZluzl Jvuayvssly pza pu Mburapvuzbtmhun buk Clyhyilpabun lpul rshyl Clyilzzlybun gbt KbhsZovjr 4, hsslykpunz mpls tpy kpl nlypunl Hrrb-Shbmglpa däoyluk klz Alzaz ulnhapc hbm, kpl cvy hsslt Jvyl Nhtly zaöylu küymal. Lilumhssz upjoa glpanltäß pza kpl Nyößl kly pualyulu Mlzawshaal, dlsjol upjoa 1 AI, zvuklyu uby 825 NI nyvß pza, cvu klulu dplklybt uby 667 NI nlubaga dlyklu röuulu, kh kly Ylza cvt Zfzalt ilslna dpyk. Pu Glpalu, pu klulu Zwplsl hbjo zjovuths ipz gb 100 NI nyvß zpuk, dlyklu oply zjoulss Wshagwyvisltl luazalolu. Kpl Rvuzvsl bualyzaüaga lydlpalyal Zwlpjolytönspjorlpalu pu Mvyt cvu BZI-Shbmdlyrlu, hsslykpunz röuulu oply uby WZ4-Zwplsl hbznlshnlya dlyklu. Kly pualyul Zwlpjoly rhuu müy WZ5-Zwplsl tpa ZZK-Lydlpalybunzrhyalu (khur T.2.-Zjoupaazalssl) clynyößlya dlyklu, hsslykpunz dpyk kplzlz Mlahbyl ilp Ylslhzl uvjo upjoa gby Clymünbunz zalolu, kluu lz pza lyza müy lpu gbrüumapnlz Bwkhal nlwshua. Lz islpia higbdhyalu, dpl zpjo kpl WZ5 pt Shunglpaalza zjoshnlu dpyk. Khur Hidäyazrvtwhapipspaäa, klu Shbujo-Apalsu buk klu Lersbzpc-Zwplslu khym hily qlaga zjovu nlyul tpa Zvufz Ulea-Nlu-Rvuzvsl nlspliäbnlsa dlyklu. ";
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
            var Buchstabe = new Dictionary<string, double>() 
            {   { "A", 0 },
                { "AE", 0 },
                { "B", 3 },
                { "C", 1 },
                { "D", 9 },
                { "E", 0 },
                { "F", 1 },
                { "G", 2 },
                { "H", 1 },
                { "I", 15}, 
                { "J", 1 },
                { "K", 2 },
                { "L", 0 },
                { "M", 5 },
                { "N", 5 },
                { "O", 0 },
                { "OE", 0 },
                { "P", 4 }, 
                { "Q", 6 },
                { "R", 0 },
                { "SZ", 0 },
                { "S", 0 },
                { "T", 1 },
                { "U", 9 },
                { "UE", 0 },
                { "V", 0 },
                { "W", 0 },
                { "X", 6 },
                { "Y", 1 },
                { "Z", 1 }
            };
            var Fortniter = new Dictionary<string, double>();
            Fortniter = Zaehlen(chiffre);
            KryptographBibliothek.ZeichenErsetzen.ZeichenErsetzenMethode(chiffre, Fortniter, tabelle_zeichen_deutsch);
            
           
            //Console.WriteLine(Fortniter);
            
        }
        static Dictionary<string, double> Zaehlen(string gef_chiffre)
        {

            bool keyExists = false;

            Dictionary<string, double> Zeichenzahl = new Dictionary<string, double>();

            gef_chiffre = gef_chiffre.ToUpper();
            for (int i = 0; i < gef_chiffre.Length; i++)
            {

                int count = gef_chiffre.Count(a => a == gef_chiffre[i]);

                keyExists = Zeichenzahl.ContainsKey(gef_chiffre[i].ToString());

                if (!keyExists)
                {
                    Zeichenzahl.Add(gef_chiffre[i].ToString(), count / gef_chiffre.Length);
                    
                }
                //Zeile in Dictionary hinzufügen, wenn Zeichen nicht bereits vorhanden
            }
            

            return Zeichenzahl;
        }
    }
}
