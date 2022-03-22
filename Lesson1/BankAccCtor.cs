using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnRandomFloat._003_base_OOP.HoweWork
{
    class BankAccCtor
    {
        private static int _accID = 1;
        private int curentAccID;
        private double _balance;
        private AccType _accType;

        public BankAccCtor() : this (0)
        {
        }
        public BankAccCtor(double balance) : this(balance, AccType.Current)
        { 
        }
        public BankAccCtor(double balance, AccType accType)
        {
            _balance = balance;
            _accType = accType;
        }
        public void GetID()
        {
            Console.WriteLine(curentAccID);
        }
        public void NextID()
        {
            _accID += 100;
            curentAccID = _accID;
        }
        public void GetBalance()
        {
            Console.WriteLine(_balance);
        }
  
        public void GetType()
        {
            Console.WriteLine(_accType);
        }
    }
}
