/*
    Name:       Ashley Thibodeau
    Date:       8.21.2020
    Class:      PROJECT AND PORTFOLIO I: APPLICATION DEVELOPMENT FUNDAMENTALS 
    Assignment: 2.6 Data Integration 1
 
 */
using System;
namespace ADF_2007_ThibodeauAshley
{
    public class Validation
    {

        //Validates a string entry
        public static string UserStringEntry(string inputMessage)
        {
            Console.Write(inputMessage);
            string userResponse = Console.ReadLine();

            while(string.IsNullOrWhiteSpace(userResponse))
            {
                //Error Message
                UI.Error("Sorry! This input requires an entry and cannot be left blank.");
                Console.Write($"\r\n{inputMessage}");
                userResponse = Console.ReadLine();
            }

            return userResponse;
        }

        //Validates a Number entry
        public static int UserNumberEntry(string inputMessage)
        {
            Console.Write(inputMessage);
            string userResponse = Console.ReadLine();
            int userResponseNumber;

            while(!(int.TryParse(userResponse.Trim(),out userResponseNumber)) || userResponseNumber < 0)
            {
                //Error Message
                UI.Error("Sorry! This input requires a number.");
                Console.Write($"\r\n{inputMessage}");
                userResponse = Console.ReadLine();
            }

            return userResponseNumber;
        }

        //Validates number is within range
        public static int WithinRange(int userEntry, string inputMessage)
        {
            Console.Write(inputMessage);
            string userResponse = Console.ReadLine();
            int userResponseNumber;

            while(!(int.TryParse(userResponse,out userResponseNumber)) || userResponseNumber < 0)
            {
                //Error Message
                UI.Error("Sorry! The entry isn't within range.");
                Console.Write($"\r\n{inputMessage}");
                userResponse = Console.ReadLine();
            }

            return userResponseNumber;
        }

        
    }
}