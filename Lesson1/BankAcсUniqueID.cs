using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnRandomFloat._003_base_OOP.HoweWork
{
    /* Изменить класс счет в банке из упражнения таким образом, чтобы номер счета генерировался сам и был уникальным. 
     * Для этого надо создать в классе статическую переменную и метод, который увеличивает значение этого переменной.*/
    class BankAcсUniqueID
    {
        private static int _accID=1;
        private int curentAccID;
        private double _balance;
        private AccType _accType;

        public BankAcсUniqueID()
        {
            NextID();
        }
        public void GetID()
        {
            Console.WriteLine(curentAccID);
        }
        public void NextID()
        {
            _accID +=100;
            curentAccID = _accID;
        }
        public void GetBalance()
        {
            Console.WriteLine(_balance);
        }
        public void SetBalance(int n)
        {
            _balance = n;
        }
        public void GetType()
        {
            Console.WriteLine(_accType);
        }
        public void SetType(AccType accType)
        {
            _accType = accType;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Номер счета - {_accID}");
            Console.WriteLine($"Баланс счета - {_balance}");
            Console.WriteLine($"Тип счета - {_accType}");
        }
    }
}
