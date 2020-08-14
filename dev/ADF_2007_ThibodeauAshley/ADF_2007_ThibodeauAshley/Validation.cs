/*
    Name:       Ashley Thibodeau
    Date:       8.5.2020
    Class:      C202008 01
    Assignment: 2.6 Data Integration 1
 
 */
using System;
namespace ADF_2007_ThibodeauAshley
{
    public class Validation
    {

        //Validates a string entry
        public static string String(string inputMessage)
        {
            Console.Write(inputMessage);
            string userResponse = Console.ReadLine();

            while(string.IsNullOrWhiteSpace(userResponse))
            {
                //Error Message
                Console.WriteLine("\r\n--------------------");
                Console.WriteLine("Sorry! This input requires an entry and cannot be left blank.");
                Console.Write($"\r\n{inputMessage}");
                userResponse = Console.ReadLine();
            }

            return userResponse;
        }

        //Validates a Number entry
        public static int Number(string inputMessage)
        {
            Console.Write(inputMessage);
            string userResponse = Console.ReadLine();
            int userResponseNumber;

            while(!(int.TryParse(userResponse,out userResponseNumber)) || userResponseNumber < 0)
            {
                //Error Message
                Console.WriteLine("\r\n--------------------");
                Console.WriteLine("Sorry! This input requires a number.");
                Console.Write($"\r\n{inputMessage}");
                userResponse = Console.ReadLine();
            }

            return userResponseNumber;
        }

        
    }
}