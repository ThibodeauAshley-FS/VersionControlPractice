/*
    Name:       Ashley Thibodeau
    Date:       8.5.2020
    Class:      C202008 01
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
        public User(string name = "Ashley", int userId = 12345, string password = "password")
        {
            Name = name;
            ID = userId;
            Password = password;

        }

        public static bool Login(User user)
        {
            Console.Clear();
            Console.WriteLine("========================================");
            Console.WriteLine(" LOGIN");
            Console.WriteLine("========================================\r\n");
            int entryNumber = Validation.Number(" UserID: _");
            string entryString = Validation.String(" Password: _");

            if (entryNumber == user.ID && entryString == user.Password)
            {
                Console.WriteLine("\r\n--------------------");
                Console.WriteLine("User Found");
                return false;
            }
            else
            {
                Console.WriteLine("\r\n--------------------");
                Console.WriteLine("User login not recognized");
                Console.WriteLine("\r\nPress any key to continue… ");
                Console.ReadKey();
                return true;
            }
           
        }

    }
}
