/*
    Name:       Ashley Thibodeau
    Date:       8.27.2020
    Class:      PROJECT AND PORTFOLIO I: APPLICATION DEVELOPMENT FUNDAMENTALS 
    Assignment: 2.6 Data Integration 1
 
 */
using System;
namespace ADF_2007_ThibodeauAshley
{
    public class Validation
    {

        
        public static string UserStringEntry(string inputMessage)
        {
            string userResponse = Refactor.Input(inputMessage);
            
            while(string.IsNullOrWhiteSpace(userResponse))
            {
                //Error Message
                Format.Error("Sorry! This input requires an entry and cannot be left blank.");
                Console.Write($"\r\n{inputMessage}");
                userResponse = Console.ReadLine();
            }

            return userResponse;
        }

        
        public static int UserNumberEntry(string inputMessage)
        {
            string userResponse = Refactor.Input(inputMessage);
            int userResponseNumber;

            while(!(int.TryParse(userResponse.Trim(),out userResponseNumber)) || userResponseNumber < 0)
            {
                //Error Message
                Format.Error("Sorry! This input requires a number.");
                Console.Write($"\r\n{inputMessage}");
                userResponse = Console.ReadLine();
            }

            return userResponseNumber;
        }

        
        public static int WithinRange(int maxRangeAmount, string inputMessage)
        {
            string userResponse = Refactor.Input(inputMessage);
            int userResponseNumber;

            while(!(int.TryParse(userResponse.Trim(),out userResponseNumber)) && (userResponseNumber < 0 && userResponseNumber > maxRangeAmount))
            {
                //Error Message
                Format.Error("Sorry! The entry isn't within range.");
                Console.Write($"\r\n{inputMessage}");
                userResponse = Console.ReadLine();
            }

            return userResponseNumber;
        }

        
    }
}