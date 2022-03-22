using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnRandomFloat._003_base_OOP.HoweWork
{
    class Bank_Accaunt : BankAccPutWith
    {
        public Bank_Accaunt():base()
        {
            
        }
        public static bool operator ==(Bank_Accaunt b1, Bank_Accaunt b2)
        {
            if (b1.curentAccID == b2.curentAccID)
            { return true; }
            return false;
        }
        public static bool operator !=(Bank_Accaunt b1, Bank_Accaunt b2)
        {
            if (b1.curentAccID != b2.curentAccID)
            { return true; }
            return false;
        }
        public override bool Equals(object obj)
        {
            Bank_Accaunt b = obj as Bank_Accaunt;
            if (b != null && b.curentAccID == this.curentAccID)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override int GetHashCode()
        {
            return this.curentAccID;
        }
        public override string ToString()
        {
            return $"Номер счета - {curentAccID}; \n" +
                      $"Баланс счета - {Balance}; \n" +
                      $"Тип счета - {AccType}";
        }
    }
}
