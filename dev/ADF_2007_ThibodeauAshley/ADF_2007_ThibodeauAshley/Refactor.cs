/*
    Name:       Ashley Thibodeau
    Date:       8.27.2020
    Class:      PROJECT AND PORTFOLIO I: APPLICATION DEVELOPMENT FUNDAMENTALS 
    Assignment: 2.6 Data Integration 1
 
 */
using System;
namespace ADF_2007_ThibodeauAshley
{
    public class Refactor
    {
            
            public static void Pause(string text)
            {
                Format.Separator();
                Console.Write(text);
                Console.ReadKey();
                Console.Clear();
            }

            public static string Input(string inputMessage)
            {
                Console.Write(inputMessage);
                string userResponse = Console.ReadLine();

                return userResponse;
            }

    }
}
