using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnRandomFloat._003_base_OOP.HoweWork
{
    public class ValidChoice
    {
        public (int, bool) FromMenu(Menu menu, string mainMess = "Выберите пункт меню", string errMess = "Некорректное выбор. Повторите ввод:")
        {
            return MakeChoice(1, menu.MenuRows.Length, mainMess, errMess);
        }
        public (int, bool) FromRandom(int minVal=int.MinValue, int maxVal=int.MaxValue, string mainMessage = "Введите значение в диапозоне", string errMassage = "Некорректное значение. Повторите ввод:")
        {
            return MakeChoice(minVal, maxVal, mainMessage, errMassage);
        }
        (int, bool) MakeChoice(int minVal, int maxVal, string mainMessage, string errMassage)
        {
            Console.WriteLine(mainMessage + $" от {minVal} до {maxVal} или введите out для выхода:");
            string _choice = Console.ReadLine();
            int selected;
            bool exit = false;
            while (!int.TryParse(_choice, out selected) || selected < minVal || selected > maxVal)
            {
                if (_choice == "out")
                {
                    exit = true;
                    break;

                }
                Console.WriteLine(errMassage + $" (от {minVal} до {maxVal})");
                _choice = Console.ReadLine();
            }
            return (selected, exit);
        }
        public (int, bool) FromList(params int[] list)
        {
            Console.Write("Выберите значение из списка:");
            foreach (int n in list)
            {
                Console.Write(" "+n+",");
            }
            Console.WriteLine();
            string _choice = Console.ReadLine();
            int selected;
            bool exit = false;
            while (!int.TryParse(_choice, out selected) || !list.Contains(selected))
            {
                if (_choice == "out")
                {
                    exit = true;
                    break;

                }
                Console.WriteLine("Некорректный выбор, повторите попытку");
                _choice = Console.ReadLine();
            }
            return (selected, exit);
        }

        public (int, bool) FromHashtable(Hashtable ht)
        {
            string _choice = Console.ReadLine();
            int selected;
            bool exit = false;
            while (!int.TryParse(_choice, out selected) || !ht.Contains(selected))
            {
                if (_choice == "out")
                {
                    exit = true;
                    break;

                }
                Console.WriteLine("Некорректный выбор, повторите попытку");
                _choice = Console.ReadLine();
            }
            return (selected, exit);
        }






    }
}
