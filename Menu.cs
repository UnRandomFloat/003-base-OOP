using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnRandomFloat._003_base_OOP.HoweWork
{
    public class Menu
    {
        public string[] MenuRows { get; private set; }
        public Menu(int howmenyRows, string menuItem)
        {
            MenuRows = new string[howmenyRows];
            for (int i = 0; i < howmenyRows; i++)
            {
                MenuRows[i] = (i + 1) + " - " + menuItem + (i + 1);
            }
        }
        public Menu(string[] rowsArray)
        {
            MenuRows = rowsArray;
        }

        public void PrintMenu()
        {
            for (int i = 0; i < MenuRows.Length; i++)
            {
                Console.WriteLine(MenuRows[i]);
            }
        }
    }
}
