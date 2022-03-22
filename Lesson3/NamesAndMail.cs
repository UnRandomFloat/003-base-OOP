using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace UnRandomFloat._003_base_OOP.HoweWork
{
    class NamesAndMail : MenuAndChoice
    {
        string path = "";
        string[] fromFile;
        string[] extractedEmails;
        static string[] menuRows =
        {
            "1.Выберите файл для чтения.",
            "2.Введите путь файла для сохрания E-mail.",
            "3.Вывести информацию из файла."
        };
        public NamesAndMail()
        {
            _Menu = new Menu(menuRows);
        }

        public void ReadInfoFromFile()
        {
            Console.WriteLine("Введите путь и имя файла с рисширением(только .txt)");
            path = Console.ReadLine();
            if (File.Exists(path))
            {
                fromFile = File.ReadAllLines(path);
                Console.WriteLine("Файл успешно прочтен!");
            }
            else if (string.IsNullOrEmpty(path))
            {
                Console.WriteLine("Введена пустая строка. Повторите ввод");
            }
            else
            {
                Console.WriteLine("Файл с расширением txt по указанному пути не найден");
            }
        }
        public void WriteMailToFile()
        {
            if (fromFile == null)
            {
                Console.WriteLine("Для начала нужно считать информацию с файла...\n");
                return;
            }
            extractEmail(fromFile);
            Console.WriteLine("Введите путь и имя файла с рисширением(только .txt)");
            string path = Console.ReadLine();
            if (!path.EndsWith(".txt"))
            {
                Console.WriteLine("Путь указан не правильно. Или не указано расширение .txt");
                return;
            }
            string[] menuRows =
                {
                "1. Перезаписать существующий файл.",
                "2. Дописать в существующий файл.",
                "3. Указать другой путь или имя файла.",
                };
            Menu writeMenu = new Menu(menuRows);
            while (true)
            {
                if (File.Exists(path))
                {
                    Console.WriteLine("Файл по указанному пути существует:");
                    writeMenu.PrintMenu();
                    switch (choice.FromMenu(writeMenu).Item1)
                    {
                        case 1:
                            File.Delete(path);
                            File.AppendAllLines(path, extractedEmails);
                            Console.WriteLine("Файл по указанному пути перезаписан!");
                            return;
                        case 2:
                            File.AppendAllLines(path, fromFile);
                            Console.WriteLine("Файл дополнен!");
                            break;
                        case 3:
                            Console.WriteLine("Введите путь и имя файла с рисширением(только .txt)");
                            path = Console.ReadLine();
                            continue;
                    }

                }
                else if (string.IsNullOrEmpty(path))
                {
                    Console.WriteLine("Введена пустая строка. Повторите ввод");
                    break;
                }
                else
                {
                    File.AppendAllLines(path, extractedEmails);
                    Console.WriteLine("Файл по указанному пути создан!");
                    break;
                }
            }

        }

        public override void GetStart()
        {
            while (!selected.Item2)
            {
                switch (selected.Item1)
                {
                    case 1:
                        ReadInfoFromFile();
                        PrepareСonsole("");
                        PrintMenuAndSelect(false);
                        break;
                    case 2:
                        WriteMailToFile();
                        PrepareСonsole("");
                        PrintMenuAndSelect(false);
                        break;
                    case 3:
                       PrintArray(extractedEmails);
                        PrepareСonsole("");
                        PrintMenuAndSelect(false);
                        break;
                }

            }
        }

        public void extractEmail(string[] arrayToExtract)
        {
            extractedEmails = new string[arrayToExtract.Length];
            for (int i = 0; i < arrayToExtract.Length; i++)
            {
                    extractedEmails[i] = arrayToExtract[i].Split(new char[] { '&' }, StringSplitOptions.RemoveEmptyEntries)[1];
            }            
        }
        void PrintArray(string[] array)
        {
            if (array == null)
            {
                Console.WriteLine("Для начала нужно извлечь емаилы из файла");
                return;
            }
            foreach (string s in array)
            {
                Console.WriteLine(s);
            }
        }
    }
}
