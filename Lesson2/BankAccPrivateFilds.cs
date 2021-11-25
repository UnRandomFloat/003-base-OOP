using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnRandomFloat._003_base_OOP.HoweWork
{
    class BankAccPrivateFilds : MenuAndChoice
    {
        static string[] menuRows =
            {"1. Установить ID",
            "2. Показать ID",
            "3. Установить баланс",
            "4. Показать баланс",
            "5. Показать тип счета",
            "6. Вывести информацию о счете"};
        private int _accID;
        private double _balance;
        private AccType _accType;

        public BankAccPrivateFilds()
        {
            _Menu = new Menu(menuRows);
        }
        public override void GetStart()
        {
            while (!selected.Item2)
            {
                switch (selected.Item1)
                {
                    case 0:
                        return;
                        
                    case 1:
                        SetID(choice.FromRandom(1, int.MaxValue, "Введите ID в диапозоне").Item1);
                        PrepareСonsole("ID установлен!"+_accID);
                        PrintMenuAndSelect(false);
                        break;
                    case 2:
                        GetID();
                        PrepareСonsole();
                        PrintMenuAndSelect(false);
                        break;
                    case 3:
                        SetBalance(choice.FromRandom(1, int.MaxValue, "Введите баланс, в диапозоне").Item1);
                        PrepareСonsole();
                        PrintMenuAndSelect(false);
                        break;
                    case 4:
                        GetBalance();
                        PrepareСonsole();
                        PrintMenuAndSelect(false);
                        break;
                    case 5:
                        GetTypeAcc();
                        PrepareСonsole();
                        PrintMenuAndSelect(false);
                        break;
                    case 6:
                        PrintInfo();
                        PrepareСonsole();
                        PrintMenuAndSelect(false);
                        break;
                }
                
            }
            return;
        }
        void GetID()
        {
            Console.WriteLine("Текущий ID: " + _accID);
        }
        void SetID(int n)
        {
            _accID = n;
        }
        void GetBalance()
        {
            Console.WriteLine("Текущий баланс: " + _balance);
        }
        void SetBalance(int n)
        {
            _balance = n;
            Console.WriteLine($"Баланс установлен ({n})!!!");
        }
        void GetTypeAcc()
        {
            Console.WriteLine("Тип счета - " + _accType);
        }
        void SetType(AccType accType)
        {
            _accType = accType;
        }
        void PrintInfo()
        {
            Console.WriteLine($"Номер счета - {_accID}");
            Console.WriteLine($"Баланс счета - {_balance}");
            Console.WriteLine($"Тип счета - {_accType}");
        }

    }
}
