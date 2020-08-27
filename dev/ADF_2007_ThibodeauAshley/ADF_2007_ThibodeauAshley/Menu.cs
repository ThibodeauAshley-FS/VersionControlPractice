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
    public class Menu
    {
        //Fields
        private string _title;
        private List<string> _menuItems = new List<string>();

        //Update the private member fields title and menuItems
        public void Init(string[] items)
        {
            _title = items[0].ToUpper();

            for (int i = 0; i < items.Length; i++)
            {
               _menuItems.Add(items[i]);
            }

        }

        //Prints out to console the menu title and list of menu items
        public void Display()
        {
            Format.Header(" "+ _title);

            for (int i = 1; i < _menuItems.Count-1; i++)
            {
                Format.AccentNumber(" [",i,$"] {_menuItems[i]}");

            }

            int index = _menuItems.IndexOf("Exit");
            Format.AccentNumber("\r\n [",0,$"] {_menuItems[index]}");
            Format.Separator();
        }
    }
}
