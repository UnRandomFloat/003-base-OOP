using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnRandomFloat._003_base_OOP.HoweWork
{
    /* Изменить класс счет в банке из упражнения таким образом, чтобы номер счета генерировался сам и был уникальным. 
     * Для этого надо создать в классе статическую переменную и метод, который увеличивает значение этого переменной.*/
    class BankAcсUniqueID : MenuAndChoice
    {
        static string[] menuRows =
           {"1. Показать ID",
            "2. Установить баланс",
            "3. Показать баланс",
            "4. Показать тип счета",
            "5. Вывести информацию о счете"};
        private static int _accID = 1;
        private int curentAccID;
        private double _balance;
        private AccType _accType = AccType.Депозит;

        public BankAcсUniqueID()
        {
            _Menu = new Menu(menuRows);
            NextID();
        }
        public override void GetStart()
        {
            while (!selected.Item2)
            {
                switch (selected.Item1)
                {
                    case 1:
                        GetID();
                        PrepareСonsole();
                        PrintMenuAndSelect(false);
                        break;
                    case 2:
                        SetBalance(choice.FromRandom(1, int.MaxValue, "Введите баланс:").Item1);
                        PrepareСonsole();
                        PrintMenuAndSelect(false);
                        break;
                    case 3:
                        GetBalance();
                        PrepareСonsole();
                        PrintMenuAndSelect(false);
                        break;
                    case 4:
                        GetTypeAcc();
                        PrepareСonsole();
                        PrintMenuAndSelect(false);
                        break;
                    case 5:
                        PrintInfo();
                        PrepareСonsole();
                        PrintMenuAndSelect(false);
                        break;
                }
            }
        }
        void GetID()
        {
            Console.WriteLine("Номер текущего счета: " + curentAccID);
        }
        void GetBalance()
        {
            Console.WriteLine("Баланс текущего счета: " + _balance);
        }
        void SetBalance(int n)
        {
            _balance = n;
        }
        void GetTypeAcc()
        {
            Console.WriteLine("Тип текущего счета: " + _accType);
        }
        void SetType(AccType accType)
        {
            _accType = accType;
        }
        void NextID()
        {
            _accID += 100;
            curentAccID = _accID;
        }
        void PrintInfo()
        {
            Console.WriteLine($"Номер счета - {curentAccID}");
            Console.WriteLine($"Баланс счета - {_balance}");
            Console.WriteLine($"Тип счета - {_accType}");
        }
    }
}
