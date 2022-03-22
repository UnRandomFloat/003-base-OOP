using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnRandomFloat._003_base_OOP.HoweWork
{
    public class _HomeWork2 :MenuAndChoice
    {
        static string[] lesson2Menu =
                 {   "1. Создать класс счет в банке с закрытыми полями...Предусмотреть методы для доступа к данным – заполнения и чтения и т.д.",
                        "2. Изменить класс счет в банке из упражнения таким образом, чтобы номер счета генерировался сам и был уникальным. ",
                        "3. В классе все методы для заполнения и получения значений полей заменить на свойства. Написать тестовый пример.",
                        "4. * Добавить в класс счет в банке два метода: снять со счета и положить на счет."
                    };
        MenuAndChoice[] taskOfLesson= { new BankAccPrivateFilds(), new BankAcсUniqueID(), new BankAccProp(), new BankAccPutWith() };
        public _HomeWork2()
        {
            _Menu = new Menu(lesson2Menu);
            items = taskOfLesson;
        }
    }
}
