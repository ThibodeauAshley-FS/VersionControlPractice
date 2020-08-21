﻿/*
    Name:       Ashley Thibodeau
    Date:       8.16.2020
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
        private string _path ="../../../Output/";
        private string _file ="UserInformation.txt";
        private User _activeUser;
        private bool _loggedIn = false;

        Dictionary<int, List<User>> _userData = new Dictionary<int, List<User>>();

        //Constructor
        public App()
        {
            using(StreamReader sr = new StreamReader(_path + _file))
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

                    _userData.Add(userKey,new List<User>());
                    _userData[userKey].Add(userInfo);
                    
                }
            }
                Menu menu = new Menu();
                menu.Init
                (new string[] {  "Main Menu", "Create User", "Login", "About", "Exit" }); 
                menu.Display();

                Selection(menu);
        }


        //Asks the user to make a selection, user selection is then used in a switch statement
        private void Selection(Menu menu)
        {
            int choice = Validation.UserNumberEntry("Select a Menu Option: _");

            if(_loggedIn == false)
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
                        _loggedIn = false;
                        menu.Init
                        (new string[] {  "Main Menu", "Create User", "Login", "About", "Exit" });
                        break;
                    default:
                        Console.WriteLine("\r\nOption not available");
                        Continue(menu);
                        break;
                   
                }
            }

            

        }

        //The CreateUser method will clear the console, and then ask the user to type in a name and password.
        private User CreateUser(Menu menu)
        {
            UI.Header("Create User");

            string newUsername = Validation.UserStringEntry(" Name: _");
            
            string newPassword = Validation.UserStringEntry(" Password: _");

            _activeUser = new User(newUsername,12345,newPassword);

            UI.Separator();
            UI.AccentString("\r\n New UserID: ",$"{_activeUser.ID}");

            Continue(menu);

            return _activeUser;
        }

        private void SignIn(Menu menu)
        {

            if(_userData.Count >= 0)
            {
                    //check to see if User.Login(activeUser) returns back a boolean value of true
                       bool vaildUser = User.Login(_activeUser);
                    
                    //If true, the Menu.Init method is run
                    if(vaildUser == true)
                    {
                        _loggedIn = vaildUser;

                        menu = new Menu();
                        menu.Init
                        ( new string [] {$"Welcome {_activeUser.Password}!", "About","Show Profile", "Logout", "Exit"});
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
        }

        //Prints message to console, waits for users response to clear
        private void Continue(Menu menu)
        {
            UI.KeyPause();

            menu.Display();
            Selection(menu);
        }
        
    }
}
