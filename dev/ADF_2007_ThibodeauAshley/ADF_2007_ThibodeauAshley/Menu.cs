/*
    Name:       Ashley Thibodeau
    Date:       8.5.2020
    Class:      C202008 01
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
            Console.WriteLine("========================================");
            Console.WriteLine(" "+ _title);
            Console.WriteLine("========================================\r\n");
            
            for (int i = 1; i < _menuItems.Count-1; i++)
            {
                Console.WriteLine($" [{i}] {_menuItems[i]}");

            }

            int index = _menuItems.IndexOf("Exit");
            Console.WriteLine($"\r\n [0] {_menuItems[index]}");

            Console.WriteLine("\r\n--------------------");
            
        }
    }
}
