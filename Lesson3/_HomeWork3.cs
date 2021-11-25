using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnRandomFloat._003_base_OOP.HoweWork
{ 
    class _HomeWork3: MenuAndChoice
    {
        static string[] lesson3Menu =
            {
            "1. В класс банковский счет, созданный в упражнениях, добавить метод, который переводит деньги с одного счета на другой и т.д.",
            "2. Реализовать метод, который в качестве входного параметра принимает строку string, возвращает строку типа string, буквы в которой идут в обратном порядке. Протестировать метод",
            "3. *Дан текстовый файл, содержащий ФИО и e-mail адрес. Разделителем между ФИО и адресом электронной почты является символ &: Кучма Андрей Витальевич & Kuchma@mail.ru Мизинцев Павел Николаевич & Pasha@mail.ru Сформировать новый файл, содержащий список адресов электронной почты. Предусмотреть метод, выделяющий из строки адрес почты. Методу в качестве параметра передается символьная строка s, e-mail возвращается в той же строке s: public void SearchMail (ref string s)"
            };
        MenuAndChoice[] taskOfLesson = { new BankAccWithTransfer(), new StringReverser(), new NamesAndMail() };
        public _HomeWork3()
        {
            _Menu = new Menu(lesson3Menu);
            items = taskOfLesson;
        }

    }
}
