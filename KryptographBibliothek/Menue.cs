using System;
using Figgle;

namespace KryptographBibliothek
{
    public class Menue
    {
        public static void MainMenue()
        {
            bool Exit = false;

            do
            {

                (int, int) cPosBM = Console.GetCursorPosition();

                Console.WriteLine();

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
                Console.WriteLine("\n\nMit der Software 'BFTMulti-Tool' sollen wiederkehrende oder besonders aufwendige\n" +
                                  "Aufgabenaus dem schulischen Kontext erleichtert oder gelöst werden. Diese Aufgaben\n" +
                                  "ergeben sich aus den Problemstellungen aus dem Unterricht der Berufsfachschule für Technik.\n\n");

                string HauptAusw;




                //Eingabeaufforderung 
                Console.WriteLine("Bitte geben Sie den Pfad der Chiffre an.:\n");
                Console.Write("Eingabe:");
                HauptAusw = Console.ReadLine().ToLower();

                switch (HauptAusw)
                {


                    case "exit":
                        Exit = true;
                        break;
                    default:

                        Console.WriteLine("Ungültige Eingabe");
                        Console.ReadKey();

                        (int, int) cPosAM = Console.GetCursorPosition();

                        KonsolenExtrasBibliothek.ConsoleExtras.ClearCurrentConsoleLine(cPosBM.Item2, cPosAM.Item2);

                        break;
                }

            } while (!Exit);

            if (Exit)
                Environment.Exit(0);


        }
    }
}
