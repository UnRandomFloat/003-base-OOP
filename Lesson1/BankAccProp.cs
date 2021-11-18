using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnRandomFloat._003_base_OOP.HoweWork
{
    class BankAccProp
    {
        private static int _accID = 1;
        public int curentAccID { get; set; }
        public double Balance { get; set; }
        private AccType AccType { get; set;}

        public BankAccProp() : this(0)
        {
        }
        public BankAccProp(double balance) : this(balance, AccType.Current)
        {
        }
        public BankAccProp(double balance, AccType accType)
        {
           Balance = balance;
            AccType = accType;
        }
   
      void NextID()
        {
            _accID += 100;
            curentAccID = _accID;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Номер счета - {curentAccID}");
            Console.WriteLine($"Баланс счета - {Balance}");
            Console.WriteLine($"Тип счета - {AccType}");
        }
    }
}
