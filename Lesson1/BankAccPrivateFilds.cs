using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnRandomFloat._003_base_OOP.HoweWork
{
    /*1. Создать класс счет в банке с закрытыми полями: номер счета, баланс, тип банковского счета (использовать перечислимый тип).
     * Предусмотреть методы для доступа к данным – заполнения и чтения. Создать объект класса, 
     * заполнить его поля и вывести информацию об объекте класса на печать.*/
    class BankAccPrivateFilds
    {
        private int _accID;
        private double _balance;
        private AccType _accType;

        public void GetID()
        {
            Console.WriteLine(_accID);
        }
        public void SetID(int n)
        {
            _accID=n;
        }
        public void GetBalance()
        {
            Console.WriteLine(_balance); 
        }
        public void SetBalance(int n)
        {
           _balance= n;
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
