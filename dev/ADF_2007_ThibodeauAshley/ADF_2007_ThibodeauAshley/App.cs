/*
    Name:       Ashley Thibodeau
    Date:       8.21.2020
    Class:      PROJECT AND PORTFOLIO I: APPLICATION DEVELOPMENT FUNDAMENTALS 
    Assignment: 2.6 Data Integration 1
 
 */
using System;
using System.Collections.Generic;
using System.IO;

namespace ADF_2007_ThibodeauAshley
{
    public class App
    {
        //Fields
        private readonly string _path = "../../../Output/";
        private readonly string _file = "UserInformation.txt";
       
        private User _activeUser;
        private bool _loggedIn = false;

        Dictionary<int, List<User>> _userData = new Dictionary<int, List<User>>();

        //Constructor
        public App()
        {
            //Reads text file and stores the information in dictionary
            using (StreamReader sr = new StreamReader(_path + _file))
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    string[] data = line.Split('|');

                    int userKey = int.Parse(data[0].Trim());

                    User userInfo = new User
                    (
                        data[1].Trim(),            // First Name
                        data[2].Trim(),            // Last Name
                        data[3].Trim(),            // Password 
                        data[4].Trim(),            // City
                        data[5].Trim()             // State
                    );

                    _userData.Add(userKey, new List<User>());
                    _userData[userKey].Add(userInfo);

                }
            }

            //Instantiate new Menu
            Menu menu = new Menu();

            menu.Init
            (new string[] { "Main Menu", "Create User", "Login", "About", "Exit" });
            menu.Display();
            Selection(menu);
        }


        //Asks the user to make a selection, user selection is then used in a switch statement
        private void Selection(Menu menu)
        {
            int choice = Validation.UserNumberEntry("Select a Menu Option: _");

            if (_loggedIn == false && _activeUser == null)
            {
                switch (choice)
                {
                    case 0:
                        Exit();
                        break;
                    case 1:
                        CreateUser(menu);
                        break;
                    case 2:
                        SignIn(menu);
                        break;
                    case 3:
                        About(menu);
                        break;
                    default:
                        Console.WriteLine("\r\nOption not available");
                        Continue(menu);
                        break;

                }
            }
            else
            {
                switch (choice)
                {
                    case 0:
                        Exit();
                        break;
                    case 1:
                        About(menu);
                        break;
                    case 2:
                        ShowProfile(_activeUser, menu);
                        break;
                    case 3:
                        _loggedIn = false;
                        _activeUser = null;
                        menu = new Menu();
                        menu.Init
                        (new string[] { "Main Menu", "Create User", "Login", "About", "Exit" });
                        menu.Display();

                        Selection(menu);
                        break;
                    default:
                        Console.WriteLine("\r\nOption not available");
                        Continue(menu);
                        break;

                }
            }



        }

        //The CreateUser method will clear the console, and then ask the user to type in their information and add it to text file.
        private void CreateUser(Menu menu)
        {
            //Generate Random Unique ID
            Random random = new Random();
            int rnd = random.Next(11111, 99999);

            UI.Header("Create User");

            //User Input Information
            string newUserFirstName = Validation.UserStringEntry(" First Name: _");
            string newUserLastName = Validation.UserStringEntry(" Last Name: _");
            string newPassword = Validation.UserStringEntry(" Password: _");
            string newCity = Validation.UserStringEntry(" City: _");
            string newState = Validation.UserStringEntry(" State: _");

            User newUser = new User(newUserFirstName, newUserLastName, newPassword, newCity, newState);
            _userData.Add(rnd, new List<User>());
            _userData[rnd].Add(newUser);

            //Write new user to text file
            using (StreamWriter sw = File.AppendText(_path + _file))
            {
                sw.WriteLine($"{rnd} | {newUser.FirstName.ToLower()} | {newUser.LastName.ToLower()} | {newUser.Password} | {newUser.City.ToLower()} | {newUser.State}");
            }


            UI.Separator();
            UI.AccentString("\r\n New UserID: ", $"{rnd}");

            Continue(menu);

        }

        //Requests UserId and Password to login. If correct information assigns the active user
        private void SignIn(Menu menu)
        {
            if (_userData.Count > 0)
            {
                //check to see if User.Login(activeUser) returns back a boolean value of true
                _activeUser = User.Login(_activeUser, _userData);

                if (_activeUser != null)
                {
                    _loggedIn = true;

                    menu = new Menu();
                    menu.Init
                    (new string[] { $"Welcome {_activeUser.FirstName}!", "About", "Show Profile", "Logout", "Exit" });
                    menu.Display();

                    Selection(menu);

                }

            }
            else
            {
                UI.Error("There are currently no active users. Please create a user account");
                Selection(menu);
            }

            Continue(menu);

        }

        //Displays user profile
        private void ShowProfile(User user, Menu menu)
        {
            UI.Header($"Profile {user.FirstName}");

            //Display Name
            UI.AvatarKitty($"  {UI.Cap(user.FirstName)} {UI.Cap(user.LastName)} \r\n", " Location: \r\n", $" {UI.Cap(user.City)},{user.State} \r\n");

            Continue(menu);
        }


        //Clears the console and prints out a short message to the console
        private void About(Menu menu)
        {
            Console.Clear();
            UI.Header($" About");

            Console.WriteLine("\r\nThis is the about section\r\n");

            Continue(menu);
        }

        //Clears the console and prints out a short message to the console
        private static void Exit()
        {
            UI.Header("Exiting....");
            Environment.Exit(0);
        }

        //Prints message to console, waits for users response to clear
        private void Continue(Menu menu)
        {
            UI.KeyPause("Press any key to continue_ ");

            menu.Display();
            Selection(menu);
        }

    }
}
