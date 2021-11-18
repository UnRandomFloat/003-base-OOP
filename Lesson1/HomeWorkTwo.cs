using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnRandomFloat._003_base_OOP.HoweWork
{
    public class HomeWorkTwo
    {
        bool oneMoreTime = true;
        ValidChoice validChoice = new ValidChoice();
        Menu homeWorkMenu;
        static string[] rowsMenu =
        {
            "1. Создать класс счет в банке с закрытыми полями...Предусмотреть методы для доступа к данным – заполнения и чтения и т.д.",
            "2. Изменить класс счет в банке из упражнения таким образом, чтобы номер счета генерировался сам и был уникальным. ",
            "3. В классе все методы для заполнения и получения значений полей заменить на свойства. Написать тестовый пример.",
            "4. * Добавить в класс счет в банке два метода: снять со счета и положить на счет."
        };
        public void GetStarted()
        {
            homeWorkMenu = new Menu(rowsMenu);
            while (oneMoreTime)
            {
                homeWorkMenu.PrintMenu();
                switch (validChoice.FromMenu(homeWorkMenu)) 
                {
                    case (0, true):
                        oneMoreTime = false;
                        break;
                    case (1, false):
                        Console.Clear();
                        BankAccPrivateFilds();
                        break;
                    case (2, false):
                        Console.Clear();
                        BankAcсUniqueID();
                        break;
                    case (3, false):
                        Console.Clear();
                        BankAcсProp();
                        break;
                    case (4, false):
                        break;
                    default:
                        break;
                }
            }

       
        }
        void BankAccPrivateFilds()
        {
            bool taskRepit = true;
            BankAccPrivateFilds BAPF = new BankAccPrivateFilds();
            string[] rowsArr = { "1-Установить ID", "2-Вывести ID", "3-Установить баланс", "4-Вывести баланс", "5-Вывести информацию о счете" };
            Menu taskOneMenu=new Menu(rowsArr);
            while (taskRepit)
            {
                taskOneMenu.PrintMenu();
                switch (validChoice.FromMenu(taskOneMenu))
                {
                    case (0, true):
                        taskRepit = false;
                        break;
                    case (1, false):
                        Console.WriteLine("Введите ID:");
                        BAPF.SetID(int.Parse(Console.ReadLine()));
                        break;
                    case (2, false):
                        Console.WriteLine("Текущий ID");
                        BAPF.GetID();
                        break;
                    case (3, false):
                        Console.WriteLine("Установите баланс:");
                        BAPF.SetBalance(int.Parse(Console.ReadLine()));
                        break;
                    case (4, false):
                        Console.WriteLine("Текущий Баланс");
                        BAPF.GetBalance();
                        break;
                    case (5, false):
                        BAPF.PrintInfo();
                        break;
                    default:
                        break;
                }
            }
        }
        void BankAcсUniqueID()
        {
            bool taskRepit = true;
            BankAcсUniqueID BAUI = new BankAcсUniqueID();
            string[] rowsArr = { "1-Вывести ID", "2-Установить баланс", "3-Вывести баланс", "4-Вывести информацию о счете" };
            Menu taskOneMenu = new Menu(rowsArr);
            while (taskRepit)
            {
                taskOneMenu.PrintMenu();
                switch (validChoice.FromMenu(taskOneMenu))
                {
                    case (0, true):
                        taskRepit = false;
                        break;
                    case (1, false):
                        Console.WriteLine("Текущий ID:");
                        BAUI.GetID();
                        break;
                    case (2, false):
                        Console.WriteLine("Установите баланс:");
                        BAUI.SetBalance(int.Parse(Console.ReadLine()));
                        break;
                    case (3, false):
                        Console.WriteLine("Текущий баланс:");
                        BAUI.GetBalance();
                        break;
                    case (4, false):
                        BAUI.PrintInfo();
                        break;
                    default:
                        break;
                }
            }
        }
        void BankAcсProp()
        {
            bool taskRepit = true;
            BankAccProp BAPP = new BankAccProp();
            string[] rowsArr = { "1-Установить ID", "2-Вывести ID", "3-Установить баланс", "4-Вывести баланс", "5-Вывести информацию о счете" };
            Menu taskOneMenu = new Menu(rowsArr);
            while (taskRepit)
            {
                taskOneMenu.PrintMenu();
                switch (validChoice.FromMenu(taskOneMenu))
                {
                    case (0, true):
                        taskRepit = false;
                        break;
                    case (1, false):
                        Console.WriteLine("Введите ID:");
                        BAPP.curentAccID = int.Parse(Console.ReadLine());
                        break;
                    case (2, false):
                        Console.WriteLine("Текущий ID:");
                        Console.WriteLine(BAPP.curentAccID);
                        break;
                    case (3, false):
                        Console.WriteLine("Установить баланс:");
                        BAPP.Balance = double.Parse(Console.ReadLine());
                        break;
                    case (4, false):
                        Console.WriteLine("Баланс - " + BAPP.Balance); 
                        break;
                    case (5, false):
                        BAPP.PrintInfo();
                        break;
                    default:
                        break;
                }
            }
        }

    }
}
