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
    public class User
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        //Constructor
        public User(string fName, string lName, string password, string city, string state)
        {
            FirstName = fName;
            LastName = lName;
            Password = password;
            City = city;
            State = state;

        }

        //Asks user for login information, verifies then outputs a user
        public static User Login(User user, Dictionary<int, List<User>> userInfo)
        {
            bool userEntryAttempt = false;
            
            Format.Header( "Login");

            int userKeyEntry = Validation.NumberEntry(" UserID: _");
            string passwordEntry = Validation.StringEntry(" Password: _");

            while(userEntryAttempt != true)
            {
                if(!(userInfo.ContainsKey(userKeyEntry)))
                {
                    Format.Error("Sorry: UserId is invalid. Please try again");
                    Refactor.Pause("Press any key to continue _");

                    Format.Header( "Login");
                    userKeyEntry = Validation.NumberEntry(" UserID: _");
                    passwordEntry = Validation.StringEntry(" Password: _");
               
                }

                foreach(KeyValuePair<int,List<User>> userItem in userInfo)
                {
                    if (userKeyEntry == userItem.Key)
                    {

                        foreach(User userData in userItem.Value)
                        {
                            if(passwordEntry == userData.Password)
                            {
                                user = new User(userData.FirstName,userData.LastName,userData.Password,userData.City, userData.State);
                                userEntryAttempt = true;
                            }
                            else
                            {
                                Format.Error("Sorry: The password entered is not correct. Please try again");
                                Refactor.Pause("Press any key to continue _");

                                Format.Header( "Login");
                                userKeyEntry = Validation.NumberEntry(" UserID: _");
                                passwordEntry = Validation.StringEntry(" Password: _");
                            }
                        }
                           
                    }


                }


            }

            return user;
           
        }

    }
}
