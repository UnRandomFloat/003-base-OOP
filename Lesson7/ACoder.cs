using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnRandomFloat._003_base_OOP.HoweWork
{
    class ACoder : MenuAndChoice, ICoder
    {
        string whatToEncode;
        string encodied;
        string decodied;
        string message;
        string[] menuRows =
        {
         "1. Ввести строку для шифрования",
         "2. Получить шифрованную строку",
         "3. Расшифровать шифрованную строку",

        };

        public ACoder()
        {
            _Menu = new Menu(menuRows);
        }
        public override void PrintMenu()
        {
            Console.WriteLine("Введенная строка - {0}; \n",whatToEncode!=null? whatToEncode :"<Пусто>");
           base.PrintMenu();
        }
   

        public override void GetStart()
        {
            while (!selected.Item2)
            {
                switch (selected.Item1)
                {
                    case 1:
                        Console.WriteLine("Введите строку:");
                        whatToEncode = Console.ReadLine();
                        message = "Строка введена!";
                        encodied = Encode(whatToEncode);
                        decodied = Decode(encodied);
                        break;
                    case 2:
                        if (whatToEncode != null)
                        { 
                            Console.WriteLine("Закодированная строка - {0}", encodied);
                            message = "Готово";
                        }
                        else 
                        { 
                            message = "Сначала введите строку:";
                        }
                        break;
                    case 3:
                        if (whatToEncode != null)
                        {
                            Console.WriteLine("Раскодированная строка - {0}",decodied);
                            message = "Готово";
                        }
                        else
                        {
                            message = "Сначала введите строку:";
                        }
                        break;
                }
                PrepareСonsole(message);
                PrintMenuAndSelect(false);
            }
        }
        public string Encode(string s)
        {
            return CodeDecode(s,false);
        }
        public string Decode(string s)
        {
            return CodeDecode(s, true);
        }

        public virtual string CodeDecode(string s, bool needDecode = true)
        {
            char[] charArray = s.ToCharArray();
            for (int i = 0; i < charArray.Length; i++)
            {
  
                if (needDecode)
                {
                    charArray[i] = --charArray[i];
                }
                else
                {
                    charArray[i] = ++charArray[i];
                }
            }
           return new string(charArray);
        }
    }
}
