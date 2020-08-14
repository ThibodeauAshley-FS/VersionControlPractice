/*
    Name:       Ashley Thibodeau
    Date:       8.5.2020
    Class:      C202008 01
    Assignment: 2.6 Data Integration 1
 
 */
using System;
using System.Threading;

namespace ADF_2007_ThibodeauAshley
{
    public class UI
    {

            //Displays header Layout
            public static void Header(string text)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("========================================");
                Console.ResetColor();
                Console.WriteLine($" {text.ToUpper()}");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("========================================");
                Console.ResetColor();

            }

            //Displays footer text
            public static void Footer(string text)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("\r\n=====================================");
                Console.ResetColor();
                Console.WriteLine(text);
            }

            //Displays a separator line with text
            public static void Separator()
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("--------------------");
                Console.ResetColor();
                
            }
            //Accent a number in a color string
            public static void AccentNumber (string start, int number, string end)
            {
                Console.Write(start);
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write(number);
                Console.ResetColor();
                Console.Write($"{end}\r\n");
            }
            //Accent a number in a color string
            public static void AccentString (string start, string accent, string end)
            {
                Console.Write(start);
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write(accent);
                Console.ResetColor();
                Console.Write(end);
            }

            //Error
            public static void Error(string text)
            {
                
                Separator();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(text);
                Console.ResetColor();
            }

        
    }



}
