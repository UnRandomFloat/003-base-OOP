using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnRandomFloat._003_base_OOP.HoweWork
{
    class BankAccProp : MenuAndChoice
    {
        static string[] menuRows =
         {"1. Установить ID",
            "2. Показать ID",
            "3. Установить баланс",
            "4. Показать баланс",
            "5. Показать тип счета",
            "6. Вывести информацию о счете"};
        private static int _accID = 1;
        public int curentAccID { get; set; }
        public double Balance { get; set; }
        protected AccType AccType { get; set; }

        public BankAccProp() : this(0)
        {
            _Menu = new Menu(menuRows);
        }
        public BankAccProp(double balance) : this(balance, AccType.Депозит)
        {
        }
        public BankAccProp(double balance, AccType accType)
        {
            NextID();
            Balance = balance;
            AccType = accType;
        }

        void NextID()
        {
            _accID += 100;
            curentAccID = _accID;
        }
        public override void GetStart()
        {
            while (!selected.Item2)
            {
                switch (selected.Item1)
                {
                    case 1:
                        curentAccID=choice.FromRandom(1,int.MaxValue).Item1;
                        PrepareСonsole("ID счета установлен!");
                        PrintMenuAndSelect(false);
                        break;
                    case 2:
                        PrepareСonsole($"ID текущего счета - {curentAccID}");
                        PrintMenuAndSelect(false);
                        break;
                    case 3:
                        Balance=choice.FromRandom(1, int.MaxValue).Item1;
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
              
                }
            }
          
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Номер счета - {curentAccID}");
            Console.WriteLine($"Баланс счета - {Balance}");
            Console.WriteLine($"Тип счета - {AccType}");
        }
    }
}
