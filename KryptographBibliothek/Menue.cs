using System;
using Figgle;
using System.IO;
using System.Collections;
using System.Collections.Generic;


namespace KryptographBibliothek
{
    public class Menue
    {
       
        public static void MainMenue()
        {
            // Verbesserung der Benutzerfreundlichkeit

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();
            bool Exit = false;
            Console.WriteLine("progammiert von Deniz Dersim Kest, Samir Yusuf Muric, Deniz Mehmet Ali Kartal, Raphael Hoeck, Emre Can Zeren, Nico Billig, Murtaza Bezhad und Chahine Djobbi \n\n\n");
            Console.WriteLine();
            Console.WriteLine(FiggleFonts.Slant.Render("Cracked MH"), "\n");
            Console.WriteLine("Drücken sie eine beliebige Taste um fortzufahren");
            bool flag=false;
            string chiffre = "";
            string dateipfad = "";
            //Dictionary<string, double> Tabelle;
            do
            {
                (int, int) cPosBM = Console.GetCursorPosition();
                Console.ReadKey();
                Console.Clear();
                //ASCII art Logo wird erzeugt.  
                Console.WriteLine
                    (FiggleFonts.Slant.Render("Kryptograph"));
                //Konsolentitel wird geändert.
                Console.Title = "BFTMultiTool";
                Console.WriteLine("------------------------------------------------------------------------------------\n" +
                                  "                              >>> Hauptmenü <<<\n" +
                                  "------------------------------------------------------------------------------------\n\n");
                Console.WriteLine("Eingabe: exit\t->\tbeendet das Programm");
                //Beschreibung der Software.               
                //Eingabeaufforderung 
                bool pfadwert = false;
                do
                {
                    Console.WriteLine("Bitte geben Sie den Pfad der Chiffre an.:\n");
                    Console.Write("Eingabe:");
                    dateipfad = Console.ReadLine();

                    if (Pfadprüfer(dateipfad))
                    {                      
                        pfadwert = true;
                    }
                } while (!pfadwert);
                //fragt dateipfad ab
                switch (dateipfad)
                {       
                    case "exit":
                        Exit = true;
                        break;                   
                    default:
                        
                        
                            var tabella = new Dictionary<string, double>();
                            
                                chiffre = KryptographBibliothek.Auslesen.AuslesenChiffre(dateipfad);
                                Console.Clear();
                                Console.WriteLine("geben sie den Pfad der Tabelle an");                               
                                var pfadtabelle = Console.ReadLine();
                            //Fragt Pfad der tabelle ab
                          do
                            {
                            pfadtabelle = Console.ReadLine();
                            if (Pfadprüfer(pfadtabelle))
                                {
                                    tabella = KryptographBibliothek.TabelleAuslesen.Auslesen(dateipfad);
                                flag = true;
                                }
                            else if (pfadtabelle == "exit")
                            { 
                            Exit = true;
                                break;
                            }
                            
                                else
                                {
                                    flag = false;
                                    Console.WriteLine("Geben sie bitte einen Richtigen Pfad an");
                                    
                                
                                }
                            } while (!flag);
                           string gef_chiff = KryptographBibliothek.ZeichenEntfernen.Zeichenentfernen(chiffre);

                            var chiffre_tabella = new Dictionary<string, double>();
                            chiffre_tabella = KryptographBibliothek.ZeichenZählen.Zaehlen(gef_chiff);
                            string fertig_chiff = KryptographBibliothek.ZeichenErsetzen.ZeichenersetzenMethode(gef_chiff, tabella, chiffre_tabella);
                            KryptographBibliothek.ZeichenAusgeben.AusgebenZeichen(chiffre, fertig_chiff);
                        
                       
                        break;
                }



            } while (!flag);           
            if (Exit)
            { 
                Environment.Exit(0);
            }
        }
        public static bool Pfadprüfer(string pfad)
        {
            if (File.Exists(pfad))
            {
                Console.WriteLine("der Pfad '{0}'existiert.", pfad);
                return true;
            }
            else
            {
                Console.WriteLine("{0} ist kein richtig angegebener Pfad.", pfad);
                return false;
            }



        }
    }
}
