using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnRandomFloat._003_base_OOP.HoweWork
{
    class BankAccWithTransfer : MenuAndChoice
    {

        static string[] menuRows =
       {"1. Выбрать другой счет",
        "2. Показать баланс текущего счета",
        "3. Вывести информацию о счете",
        "4. Положить сумму на счет",
        "5. Снять сумму со счета",
        "6. Вывести список доступных счетов",
        "7. Перевести на другой счет"
        };
        static BankAccPutWith acc1 = new BankAccPutWith(2500, AccType.Депозит);
        static BankAccPutWith acc2 = new BankAccPutWith(5000, AccType.Депозит);
        static BankAccPutWith acc3 = new BankAccPutWith(1250, AccType.Депозит);
        static BankAccPutWith acc4 = new BankAccPutWith(850, AccType.Депозит);

        static BankAccPutWith[] bankAccaunts = { acc1, acc2, acc3, acc4 };
        static BankAccPutWith currentAccaunt = bankAccaunts[3];
        public BankAccWithTransfer()
        {

            _Menu = new Menu(menuRows);
            items = bankAccaunts;
        }
    
        public override void PrintMenuAndSelect(bool letsStart = true)
        {
            PrepareСonsole("", false);
            Console.WriteLine("Номер текущего счета");
            Console.WriteLine(currentAccaunt.curentAccID);
            Console.WriteLine();
            PrintMenu();
            selected = choice.FromMenu(_Menu);
            if (letsStart)
            {
                GetStart();
            }
        }
        public override void GetStart()
        {
            while (!selected.Item2)
            {
                switch (selected.Item1)
                {
                    case 1:
                        ChangeAcc(choice.FromList(acc1.curentAccID, acc2.curentAccID, acc3.curentAccID, acc4.curentAccID).Item1);
                        PrepareСonsole($"Счет №{currentAccaunt.curentAccID} утсановлен текущим");
                        PrintMenuAndSelect(false);
                        break;
                    case 2:
                        PrepareСonsole($"Баланс текущего счета - {currentAccaunt.Balance}");
                        PrintMenuAndSelect(false);
                        break;
                    case 3:
                        currentAccaunt.PrintInfo();
                        PrepareСonsole();
                        PrintMenuAndSelect(false);
                        break;
                    case 4:
                        currentAccaunt.Putin(choice.FromRandom(1, int.MaxValue).Item1);
                        PrepareСonsole();
                        PrintMenuAndSelect(false);
                        break;
                    case 5:
                        currentAccaunt.Putout(choice.FromRandom(1, int.MaxValue).Item1);
                        PrepareСonsole("");
                        PrintMenuAndSelect(false);
                        break;
                    case 6:
                        printAccs();
                        PrepareСonsole("");
                        PrintMenuAndSelect(false);
                        break;
                    case 7:
                        Console.WriteLine("Укажите номер счета получателя:");
                        BankAccPutWith accTotransfer =findAcc(choice.FromList(acc1.curentAccID, acc2.curentAccID, acc3.curentAccID, acc4.curentAccID).Item1);
                        Console.WriteLine("Укажите сумму которую надо перевести:");
                        int summToTransfer = choice.FromRandom(0, Convert.ToInt32(currentAccaunt.Balance)).Item1;
                        Transaction(accTotransfer, summToTransfer);
                        PrepareСonsole("");
                        PrintMenuAndSelect(false);
                        break;
                }
            }
        }
        void printAccs()
        {
            Console.WriteLine("Список доступных счетов:");
            foreach (BankAccPutWith b in bankAccaunts)
            {
                if (currentAccaunt.curentAccID == b.curentAccID)
                {
                    Console.WriteLine(b.curentAccID + "- текущий");
                }
                else
                {
                    Console.WriteLine(b.curentAccID);
                }
            }
        }
        void Transaction(BankAccPutWith accTotransfer, int summToTransfer)
        {
            if (currentAccaunt.Balance >= summToTransfer)
            {
                accTotransfer.Putin(summToTransfer);
                currentAccaunt.Putout(summToTransfer);
            }
           
        }
        BankAccPutWith findAcc(int n)
        {
            foreach (BankAccPutWith b in bankAccaunts)
            {
                if (b.curentAccID == n)
                {
                    return b;
                }
            }
            return null;
        }
        void ChangeAcc(int n)
        {
            foreach (BankAccPutWith b in bankAccaunts)
            {
                if (b.curentAccID == n)
                {
                    currentAccaunt = b;
                    return;
                }
            }
        }
    }
}
