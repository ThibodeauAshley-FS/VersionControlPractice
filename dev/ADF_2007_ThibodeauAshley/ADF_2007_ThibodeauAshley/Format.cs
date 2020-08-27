/*
    Name:       Ashley Thibodeau
    Date:       8.27.2020
    Class:      PROJECT AND PORTFOLIO I: APPLICATION DEVELOPMENT FUNDAMENTALS 
    Assignment: 2.6 Data Integration 1
 
 */
using System;
namespace ADF_2007_ThibodeauAshley
{
    public class Format
    {
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

            public static void Footer(string text)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("\r\n=====================================");
                Console.ResetColor();
                Console.WriteLine(text);
            }

            public static void Separator()
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("--------------------");
                Console.ResetColor();
                
            }

            public static void AccentNumber (string start, int number, string end)
            {
                Console.Write(start);
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write(number);
                Console.ResetColor();
                Console.Write($"{end}\r\n");
            }

            public static void AccentString (string start, string accent)
            {
                Console.Write(start);
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write(accent);
                Console.ResetColor();
                Console.WriteLine("\r\n");
            }

            public static string Capitalization(string text)
            {
                text = char.ToUpper(text[0]) + text.Substring(1);

                return text;
            }

            public static void Error(string text)
            {
                
                Separator();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(text);
                Console.ResetColor();
            }

            public static void ProfileLayout(string name, string loc, string city)
            {
                ProfilePictureColor("\r\n╔═══◦✿◦═══╗",$"  {name}");
                ProfilePictureColor("‖ ","ᕱ___ᕱ  ");            
                ProfilePictureColor(" ‖ \r\n|","(=^ᴥ^=) ");
                ProfilePictureColor(" | ",$"{loc}");
                ProfilePictureColor("‖ ","((￣))/)");
                ProfilePictureColor("‖ ",$"{city}");
                ProfilePictureColor("╚═══◦✿◦═══╝","\r\n\r\n");
                
            }

            
            private static void ProfilePictureColor(string colorText, string normText)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write(colorText);
                Console.ResetColor();
                Console.Write(normText);
            }
        
    }



}
