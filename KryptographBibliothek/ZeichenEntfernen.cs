using System;

namespace KryptographBibliothek
{
    public class ZeichenEntfernen
    {
        public static string Zeichenentfernen()
        {
            bool wiederholen = true;
            string chiffre = "Kly ulbl KbhsZluzl Jvuayvssly pza pu Mburapvuzbtmhun buk Clyhyilpabun lpul rshyl Clyilzzlybun gbt KbhsZovjr 4, hsslykpunz mpls tpy kpl nlypunl Hrrb-Shbmglpa däoyluk klz Alzaz ulnhapc hbm, kpl cvy hsslt Jvyl Nhtly zaöylu küymal. Lilumhssz upjoa glpanltäß pza kpl Nyößl kly pualyulu Mlzawshaal, dlsjol upjoa 1 AI, zvuklyu uby 825 NI nyvß pza, cvu klulu dplklybt uby 667 NI nlubaga dlyklu röuulu, kh kly Ylza cvt Zfzalt ilslna dpyk. Pu Glpalu, pu klulu Zwplsl hbjo zjovuths ipz gb 100 NI nyvß zpuk, dlyklu oply zjoulss Wshagwyvisltl luazalolu. Kpl Rvuzvsl bualyzaüaga lydlpalyal Zwlpjolytönspjorlpalu pu Mvyt cvu BZI-Shbmdlyrlu, hsslykpunz röuulu oply uby WZ4-Zwplsl hbznlshnlya dlyklu. Kly pualyul Zwlpjoly rhuu müy WZ5-Zwplsl tpa ZZK-Lydlpalybunzrhyalu (khur T.2.-Zjoupaazalssl) clynyößlya dlyklu, hsslykpunz dpyk kplzlz Mlahbyl ilp Ylslhzl uvjo upjoa gby Clymünbunz zalolu, kluu lz pza lyza müy lpu gbrüumapnlz Bwkhal nlwshua. Lz islpia higbdhyalu, dpl zpjo kpl WZ5 pt Shunglpaalza zjoshnlu dpyk. Khur Hidäyazrvtwhapipspaäa, klu Shbujo-Apalsu buk klu Lersbzpc-Zwplslu khym hily qlaga zjovu nlyul tpa Zvufz Ulea-Nlu-Rvuzvsl nlspliäbnlsa dlyklu.";
            do
            {
                string wiederholenauswahl;
                string entfernenauswahl;
                wiederholen = true;
                string chiffrebuffer = chiffre;

                Console.WriteLine(chiffre + "\n\n");

                Console.WriteLine("Welche Zeichen möchten Sie entfernen? \n\n");
                entfernenauswahl = Console.ReadLine();



                chiffre = chiffre.Replace(entfernenauswahl, "");

                


                Console.WriteLine("Möchten Sie noch etwas entfernen?");
                wiederholenauswahl = Console.ReadLine();
                if (wiederholenauswahl == "Ja")
                {
                    wiederholen = true;
                }

                else if (wiederholenauswahl == "Nein")
                {
                    wiederholen = false;
                }





            } while (wiederholen == true);



            Console.Write(chiffre);

            string chiffre_gefiltert = chiffre;

            return chiffre_gefiltert;
         
        }
    }
}