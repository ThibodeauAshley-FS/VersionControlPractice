/*
    Name:       Ashley Thibodeau
    Date:       8.21.2020
    Class:      PROJECT AND PORTFOLIO I: APPLICATION DEVELOPMENT FUNDAMENTALS 
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
            public static void AccentString (string start, string accent)
            {
                Console.Write(start);
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write(accent);
                Console.ResetColor();
                Console.WriteLine("\r\n");
            }

            //Capitalize the first letter of a word
            public static string Cap(string text)
            {
                text = char.ToUpper(text[0]) + text.Substring(1);

                return text;
            }

            //Blocks Password
            public static void HiddenPassword(string text)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;

                for (int i = 0; i < text.Length; i++)
                {
                    Console.Write("*");
                }

                Console.ResetColor();
            }

            //Error
            public static void Error(string text)
            {
                
                Separator();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(text);
                Console.ResetColor();
            }

            //Displays an Avatar
            public static void AvatarBunny(string name, string loc, string city)
            {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write("\r\n|========|");
            Console.ResetColor();
                Console.Write($"{name}");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write("| ");
            Console.ResetColor();
            
                Console.Write("(|_/) ");
            
            Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write(" | \r\n"); 
                Console.Write("|");
            Console.ResetColor();
                Console.Write("(>^ᴥ^<) ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write("| ");
            Console.ResetColor();
            Console.Write($"{loc}");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write("| ");
            Console.ResetColor();
            
                Console.Write("(u u)o ");

            Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write("| ");
            Console.ResetColor();
            Console.Write($"{city}");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("|========|\r\n");
            Console.ResetColor();
                
            }

            //Pause key entry to continue
            public static void KeyPause(string text)
            {
                Separator();
                Console.Write(text);
                Console.ReadKey();
                Console.Clear();
            }
            //"Press any key to continue_ "
            //"Return to Home Menu: _"
        
    }



}
