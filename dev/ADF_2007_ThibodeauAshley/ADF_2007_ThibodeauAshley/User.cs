/*
    Name:       Ashley Thibodeau
    Date:       8.16.2020
    Class:      PROJECT AND PORTFOLIO I: APPLICATION DEVELOPMENT FUNDAMENTALS 
    Assignment: 2.6 Data Integration 1
 
 */
using System;

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

        public static bool Login(User user)
        {
            UI.Header( "Login");

            int entryNumber = Validation.UserNumberEntry(" UserID: _");
            string entryString = Validation.UserStringEntry(" Password: _");

            if ((entryNumber == user.ID && entryString == user.Password))
            {
                UI.Separator();
                Console.WriteLine("User Found");
                UI.KeyPause();

                return true;
            }
            else
            {
                UI.Separator();
                Console.WriteLine("User login not recognized");
                

                return false;
            }

           
        }

    }
}
