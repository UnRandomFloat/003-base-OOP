using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnRandomFloat._003_base_OOP.HoweWork
{
    class StringReverser:MenuAndChoice
    {
        string toRevers;
        static string[] menuRows =
        {
            "1.Ввести строку для отражения\n"
        };

        public StringReverser()
        {
            _Menu = new Menu(menuRows);
        }

        public override void GetStart()
        {
            while (!selected.Item2)
            {
                switch (selected.Item1)
                {
                    case 1:
                        Console.WriteLine("Введите строку для отражения");
                        toRevers = Console.ReadLine();
                        Reversed(ref toRevers);
                        Console.WriteLine("Отраженная строка - "+toRevers);
                        PrepareСonsole("");
                        PrintMenuAndSelect(false);
                        break;
                }
            }
        }
        void Reversed(ref string stringRevers)
        {
            string temp = "";
            for (int i = 0; i < stringRevers.Length; i++)
            {
                temp += stringRevers[stringRevers.Length-1-i];
                
            }
            stringRevers = temp;
        }
    }
}
