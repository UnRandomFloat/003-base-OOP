using System;

namespace UnRandomFloat._003_base_OOP.HoweWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Dispetcher mainDispetcher = new Dispetcher(new Menu(8, "Домашняя работа к уроку №"));
            mainDispetcher.TransferControlToLesson();

        }
      
    }
}
