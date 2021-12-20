using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnRandomFloat._003_base_OOP.HoweWork
{
    class _HomeWork6 : MenuAndChoice
    {
        private static Bank_Accaunt B_acc1 = new Bank_Accaunt();
        private static Bank_Accaunt B_acc2 = new Bank_Accaunt();
        private static Bank_Accaunt B_acc3 = new Bank_Accaunt();
        Bank_Accaunt[] Bank_accaunts = { B_acc1, B_acc2, B_acc3 };
        string[] menuRows =
        {
            "1. Создать или редактировать счет №1",
            "2. Создать или редактировать счет №2",
            "3. Создать или редактировать счет №3",
            "4. Равны ли счета?",
            "5. Не равны счета?",
            "6. Вывод информации о счете",

        };
        public _HomeWork6()
        {
            _Menu = new Menu(menuRows);
            this.items = Bank_accaunts;
        }

        public override void GetStart()
        {
            while (!selected.Item2)
            {
                switch (selected.Item1)
                {
                    case 1:
                        Bank_accaunts[0].PrintMenuAndSelect();
                        break;
                    case 2:
                        Bank_accaunts[1].PrintMenuAndSelect();
                        break;
                    case 3:
                        Bank_accaunts[2].PrintMenuAndSelect();
                        break;
                    case 4:
                        Console.WriteLine(IsEqualsAcc()? "Выбраные счета идентичны" : "Выбраные счета НЕ идентичны");
                        break;
                    case 5:
                        Console.WriteLine(IsEqualsAcc(false) ? "Выбраные счета НЕ идентичны" : "Выбраные счета идентичны");
                        break;
                    case 6:
                        Bank_Accaunt acc1 = BA(choice.FromList(Bank_accaunts[0].curentAccID, Bank_accaunts[1].curentAccID, Bank_accaunts[2].curentAccID).Item1);
                        Console.WriteLine(acc1.ToString());
                        break;

                }
                PrepareСonsole();
                PrintMenuAndSelect(false);
            }
        }
        bool IsEqualsAcc(bool eq=true)
        {
            Console.WriteLine("Выберите первый аккаунт:");
            selected=choice.FromList(Bank_accaunts[0].curentAccID, Bank_accaunts[1].curentAccID, Bank_accaunts[2].curentAccID);
            Bank_Accaunt acc1 = BA(selected.Item1);
            Console.WriteLine("Выберите второй аккаунт:");
            selected = choice.FromList(Bank_accaunts[0].curentAccID, Bank_accaunts[1].curentAccID, Bank_accaunts[2].curentAccID);
            Bank_Accaunt acc2 = BA(selected.Item1);
            if (eq)
            {
                if (acc1 == acc2)
                {
                    return true;
                }
                else
                    return false;
            }
            else 
            {
                if (acc1 != acc2)
                {
                    return true;
                }
                else
                    return false;
            }

        }
        
        Bank_Accaunt BA(int n)
        {
            foreach (Bank_Accaunt b in Bank_accaunts)
            {
                if (b.curentAccID == n)
                {
                    return b;
                }
            }
            return null;
        }
    }
}
