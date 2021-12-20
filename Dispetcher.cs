using System;

namespace UnRandomFloat._003_base_OOP.HoweWork
{
    /// <summary>
    /// Класс для организации меню практических заданий к соответствующему уроку.
    /// </summary>
    public class Dispetcher : MenuAndChoice
    {
        MenuAndChoice[] homeWorks = {
              new _HomeWork1(),
              new _HomeWork2(),
              new _HomeWork3(),
              new _HomeWork4(),
              new _HomeWork5(),
              new _HomeWork6()
        };

        public Dispetcher(Menu menu)
        {
            _Menu = menu;
            items = homeWorks;
        }
        public Dispetcher(string[] menuRows) : base(menuRows)
        {
        }
    }
}

