/*
    Name:       Ashley Thibodeau
    Date:       8.5.2020
    Class:      C202008 01
    Assignment: 1.3 Project Initiation
 
 */
using System;
namespace ProjectInitiation
{
    public class App
    {
        //Fields
        private User _mainUser;

        //Constructor
        public App()
        {
            Menu menu = new Menu();
            menu.Init
            (new string[] { "Main Menu", "Login", "About", "Exit" });
            menu.Display();

            User user = new User();
            _mainUser = user;

            Selection();
        }


        //Asks the user to make a selection, user selection is then used in a switch statement
        private void Selection()
        {
            int choice = Validation.Number("Select a Menu Option: _");

            switch (choice)
            {
                case 0:
                    Exit();
                    break;
                case 1:
                    Login();
                    break;
                case 2:
                    About();
                    break;
                default:
                    Console.WriteLine("\r\nOption not available");
                    Continue();
                    break;
                   
            }
        }

        //Clears the console and then runs a static method of the User class
        private void Login()
        {
            bool loggedIn = true;

            while (loggedIn)
            {
                Console.Clear();
                loggedIn = User.Login(_mainUser);
                
            }

            Continue();

            

        }

        //Clears the console and prints out a short message to the console
        private static void About()
        {
            Console.Clear();
            Console.WriteLine("========================================");
            Console.WriteLine($" About");
            Console.WriteLine("========================================\r\n");

            Console.WriteLine("This is the about section");

            Continue();
        }

        //Clears the console and prints out a short message to the console
        private static void Exit()
        {
            Console.Clear();
            Console.WriteLine("Exiting");
        }

        //Prints message to console, waits for users response to clear
        private static void Continue()
        {
            Console.Write("\r\nPress any key to continue... ");
            Console.ReadKey();
            Console.Clear();
            _ = new App();
        }
        
    }
}
