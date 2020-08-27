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
        Dictionary<int, List<User>> _userData = new Dictionary<int, List<User>>();

        //Fields
        private User _activeUser;
        private bool _loggedIn = false;
        private Menu _menu;

        private static string _name = " ";

        private static readonly string _path = "../../../Output/";
        private static readonly string _file = "UserInformation.txt";
        private static readonly string[] mainMenu = new string[] { "Main Menu", "Create User", "Login", "About", "Exit" };
        private readonly string[] profileMenu = new string[] { $"Welcome", "About", "Show Profile", "Users", "Logout", "Exit" };
        
        

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

            _menu = new Menu();

            _menu.Init(mainMenu, _name);
            _menu.Display();

            Selection(_menu);

        }


        //Asks the user to make a selection, user selection is then used in a switch statement
        public void Selection(Menu menu)
        {
            int choice = 0;

            if(_loggedIn == false)
            {
                choice = Validation.WithinRange(Validation.UserNumberEntry("Select a Menu Option: _"), mainMenu.Length-1);
            }
            else
            {
                choice = Validation.WithinRange(Validation.UserNumberEntry("Select a Menu Option: _"), profileMenu.Length-1);
            }

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
                        Format.Error("Option not available");
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
                        Users(menu);
                        break;
                    case 4:
                        _loggedIn = false;
                        _activeUser = null;
                        _name = " ";

                        _menu = new Menu();
                        _menu.Init(mainMenu, _name);
                        _menu.Display();

                        Selection(_menu);
                        break;
                    default:
                        Format.Error("Option not available");
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

            Format.Header("Create User");

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


            Format.Separator();
            Format.AccentString("\r\n New UserID: ", $"{rnd}");

            Continue(menu);

        }

        
        private void SignIn(Menu menu)
        {
            if (_userData.Count > 0)
            {
                //check to see if User.Login(activeUser) returns back a boolean value of true
                _activeUser = User.Login(_activeUser, _userData);

                if (_activeUser != null)
                {
                    _loggedIn = true;
                    _name = _activeUser.FirstName.ToString();

                    _menu = new Menu();
                    _menu.Init(profileMenu, _name);
                    _menu.Display();

                    Selection(_menu);

                }

            }
            else
            {
                Format.Error("There are currently no active users. Please create a user account");
                Selection(menu);
            }

            Continue(menu);

        }

        private void ShowProfile(User user, Menu menu)
        {
            Format.Header($"Profile {user.FirstName}");

            Format.ProfileLayout($"{Format.Capitalization(user.FirstName)} {Format.Capitalization(user.LastName)} \r\n", " Location: \r\n", $" {Format.Capitalization(user.City)},{user.State} \r\n");

            Continue(menu);
        }

        private void Users(Menu menu)
        {
            Format.Header($"Profile {_activeUser.FirstName}");
            foreach(KeyValuePair<int,List<User>> accounts in _userData)
            {
                foreach(User userItem in accounts.Value)
                {
                    Format.ProfileLayout($"{Format.Capitalization(userItem.FirstName)} {Format.Capitalization(userItem.LastName)} \r\n", " Location: \r\n", $" {Format.Capitalization(userItem.City)},{userItem.State} \r\n");
                }
                
            }

            Continue(menu);
        }


        private void About(Menu menu)
        {

            Console.Clear();
            Format.Header($" About");

            Console.WriteLine("\r\nThis is the about section\r\n");

            Continue(menu);
        }

        
        private static void Exit()
        {
            Format.Header("Exiting....");
            Environment.Exit(0);
        }

        private void Continue(Menu menu)
        {
            Refactor.Pause("Press any key to continue_ ");

            menu.Display();

            
            Selection(menu);
        }

    }
}
