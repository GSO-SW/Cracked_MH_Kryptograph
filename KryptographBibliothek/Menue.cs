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
                Console.WriteLine("Bitte geben Sie den Pfad der Chiffre an.:\n");
                Console.Write("Eingabe:");
                dateipfad = Console.ReadLine();   
                //fragt dateipfad ab
                switch (dateipfad)
                {
                    case "exit":
                        Exit = true;
                        break;                   
                    default:
                        flag = Pfadprüfer(dateipfad);
                        if(flag)
                        {
                            Console.WriteLine("Ist der Text eine die auf Englisch entschlüsselt werden soll? \n wenn ja, geben sie ja ein");
                            var tabella = new Dictionary<string, double>();
                            var textenglisch = Console.ReadLine();
                            //Variierung zwischen Englisch und Deutsch
                            if (textenglisch == "ja")
                            {

                                dateipfad = @"C:\Users\49177\Source\Repos\GSO-SW\Cracked_MH_Kryptograph\EnglischTabelle.txt";
                                
                                do
                                {
                                    Console.WriteLine("Bitte geben sie die dazu gehörge Tabelle bzw Pfad an");
                                    dateipfad = Console.ReadLine();
                                    flag = Pfadprüfer(dateipfad);
                                    if (!flag) Console.WriteLine("Dateipfad nicht gefunden...");
                                    Console.ReadKey();
                                    Console.Clear();


                                } while (!flag);
                                flag = false;
                                tabella = KryptographBibliothek.TabelleAuslesen.Auslesen(dateipfad);

                            }
                            else
                            {
                                dateipfad = @"C:\Users\49177\Source\Repos\GSO-SW\Cracked_MH_Kryptograph\DeutschTabelle.txt";
                                flag = Pfadprüfer(dateipfad);
                                while (!flag)
                                {
                                    Console.WriteLine("Bitte geben sie die dazu gehörge Tabelle bzw Pfad an");
                                    dateipfad = Console.ReadLine();
                                    flag = Pfadprüfer(dateipfad);
                                    Console.ReadKey();
                                    Console.Clear();
                                }
                                tabella = KryptographBibliothek.TabelleAuslesen.Auslesen(dateipfad);
                            }
                            string gef_chiff = KryptographBibliothek.ZeichenEntfernen.Zeichenentfernen(chiffre);

                            var chiffre_tabella = new Dictionary<string, double>();
                            chiffre_tabella = KryptographBibliothek.ZeichenZählen.Zaehlen(gef_chiff);
                            string fertig_chiff = KryptographBibliothek.ZeichenErsetzen.ZeichenErsetzenMethode(gef_chiff, tabella, chiffre_tabella);
                            KryptographBibliothek.ZeichenAusgeben.AusgebenZeichen(chiffre, fertig_chiff);
                        }
                        else
                        {
                            Console.WriteLine("Detiepfad nicht gefunden");
                        }
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
