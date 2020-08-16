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

        public string Name { get; set; }
        public int ID { get; set; }
        public string Password { get; set; }

        //Constructor
        public User(string name, int userId, string password)
        {
            Name = name;
            ID = userId;
            Password = password;

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
