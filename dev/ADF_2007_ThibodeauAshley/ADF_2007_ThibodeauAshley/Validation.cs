/*
    Name:       Ashley Thibodeau
    Date:       8.27.2020
    Class:      PROJECT AND PORTFOLIO I: APPLICATION DEVELOPMENT FUNDAMENTALS 
    Assignment: 2.6 Data Integration 1
 
 */
using System;
using System.Collections.Generic;

namespace ADF_2007_ThibodeauAshley
{
    public static class Validation
    {

        
        public static string StringEntry(string inputMessage)
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

        
        public static int NumberEntry(string inputMessage)
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

        public static int WithinRange(string inputMessage, int maxRange)
        {
            int userResponseNumber = NumberEntry(inputMessage);

            while(!(userResponseNumber < 0 && userResponseNumber > maxRange))
            {
                //Error Message
                Format.Error("Sorry! The number you entered is not within a vaild range!");
                userResponseNumber = NumberEntry(inputMessage);
            }

            return userResponseNumber;
        }

        public static int KeyCheck(Dictionary<int, List<User>> dictionary, int rndNum)
        {
            bool NumberPresent = false;

            foreach(KeyValuePair<int, List<User>> item in dictionary)
            {
                if(item.Key == rndNum)
                {
                    NumberPresent = true;
                }
                else
                {
                    NumberPresent = false;
                }

            }

            rndNum = RndNumConditional(NumberPresent, dictionary, rndNum);

            return rndNum;
        }

        private static int RndNumConditional(bool NumPresent, Dictionary<int, List<User>> dictionary, int rndNum)
        {
            if(NumPresent == true)
            {
                Random random = new Random();
                rndNum = random.Next(11111, 99999);
                KeyCheck(dictionary, rndNum);
            }

            return rndNum;

        }
        
    }
}