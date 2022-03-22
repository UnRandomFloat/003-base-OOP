using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnRandomFloat._003_base_OOP.HoweWork
{
    class BankAccPutWith : BankAccProp
    {
  static string[] menuRows =
        {"1. Установить ID",
            "2. Показать ID",
            "3. Установить баланс",
            "4. Показать баланс",
            "5. Показать тип счета",
            "6. Вывести информацию о счете",
            "7. Положить сумму на счет",
            "8. Снять сумму со счета",
        };
        public BankAccPutWith()
        {
            _Menu = new Menu(menuRows);
        }
        public BankAccPutWith(double balance, AccType accType): base(balance, accType)
        {
            
        }
        public override void GetStart()
        {
      
            while (!selected.Item2)
            {
                switch (selected.Item1)
                {
                    case 1:
                        curentAccID = choice.FromRandom(1, int.MaxValue).Item1;
                        PrepareСonsole("ID счета установлен!");
                        PrintMenuAndSelect(false);
                        break;
                    case 2:
                        PrepareСonsole($"ID текущего счета - {curentAccID}");
                        PrintMenuAndSelect(false);
                        break;
                    case 3:
                        Balance = choice.FromRandom(1, int.MaxValue).Item1;
                        PrepareСonsole("Баланс счета установлен!");
                        PrintMenuAndSelect(false);
                        break;
                    case 4:
                        PrepareСonsole($"Баланс текущего счета - {Balance}");
                        PrintMenuAndSelect(false);
                        break;
                    case 5:
                        PrepareСonsole($"Тип текущего счета - {AccType}");
                        PrintMenuAndSelect(false);
                        break;
                    case 6:
                        PrintInfo();
                        PrepareСonsole();
                        PrintMenuAndSelect(false);
                        break;
                    case 7:
                        Putin(choice.FromRandom(1, int.MaxValue).Item1);
                        PrepareСonsole();
                        PrintMenuAndSelect(false);
                        break;
                    case 8:
                        Putout(choice.FromRandom(1, int.MaxValue).Item1);
                        PrepareСonsole("");
                        PrintMenuAndSelect(false);
                        break;

                }
            }

        }
        public void Putin(int n)
        {
            Balance += n;
            Console.WriteLine($"Сумма {n} добавлена на счет {curentAccID}");
        }
        public void Putout(int n)
        {
            if (n > Balance)
            {
                Console.WriteLine($"На счету не достаточно средств! Не хватает - {n - Balance}");
            }
            else
            {
                Balance -= n;
                Console.WriteLine($"Сумма {n} списана со счета {curentAccID}");
            }
        }
    }
}
