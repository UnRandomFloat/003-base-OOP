using System;

namespace UnRandomFloat._003_base_OOP.HoweWork
{
    /// <summary>
    /// Класс для организации главного меню и передачи управления в соотвтетствующий раздел.
    /// </summary>
    public class Dispetcher
    {
        Menu MainMenu;
        bool oneMoreTime = true;
        ValidChoice validChoice = new ValidChoice();
        public Dispetcher(Menu menu)
        {
            MainMenu = menu;
        }
        public void TransferControlToLesson()
        {
            MainMenu.PrintMenu();         
            while (oneMoreTime)
            {
                
                switch (validChoice.FromMenu(MainMenu))
                {
                    case (0, true):
                        oneMoreTime = false;
                       PrepareСonsole();
                        break;
                    case (1, false):
                        Console.WriteLine("Задание выполнено см: https://github.com/UnRandomFloat/003-base-OOP/pull/1");
                        PrepareСonsole();
                        break;
                    case (2, false):
                        Console.Clear();
                        HomeWorkTwo HomeWorkTwo = new HomeWorkTwo();
                        HomeWorkTwo.GetStarted();
                        PrepareСonsole();
                        break;
                    default:
                        Console.WriteLine("Практическое задание к этому уроку еще не выполнено, повторите выбор.");
                        break;
                }
            }
        }
        void PrepareСonsole()
        {
            Console.WriteLine("Для продолжения нажмите Enter");
            Console.ReadLine();
            Console.Clear();
            MainMenu.PrintMenu();
        }
    }
}

