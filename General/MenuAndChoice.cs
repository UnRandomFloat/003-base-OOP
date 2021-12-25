using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnRandomFloat._003_base_OOP.HoweWork
{
    abstract public class MenuAndChoice
    {

        protected Menu _Menu { get; set; }
        protected ValidChoice choice = new ValidChoice();
        protected (int, bool) selected=(0,false);
        protected MenuAndChoice[] items;
        public MenuAndChoice()
        {
        }
        public MenuAndChoice(string[] menuRows)
        {
            _Menu = new Menu(menuRows);
        }

        public MenuAndChoice(string[] menuRows, params MenuAndChoice[] items)
        {
            _Menu = new Menu(menuRows);
            this.items = items;
        }
        public virtual void PrintMenu()
        {
            _Menu?.PrintMenu();
        }
        public virtual void PrintMenuAndSelect(bool letsStart=true)
        {
            Console.Clear();
            PrintMenu();
            selected=choice.FromMenu(_Menu);
            if (letsStart)
            {
                GetStart();
            }
        }
        public virtual void GetStart()
        {
            while (!selected.Item2 && selected.Item1 - 1 <= items.Length - 1)
            {
                items[selected.Item1 - 1].PrintMenuAndSelect();
                PrintMenuAndSelect(false);
            }
            if (selected.Item2)
            {
                return;
            }
            PrepareСonsole("Задание не готово!");
            PrintMenuAndSelect();
       
        }
        public void PrepareСonsole(string s="Готово.", bool needAccept = true)
        {
            if (needAccept)
            {
                Console.WriteLine(s);
                Console.WriteLine("Для продолжения нажмите Enter");
                Console.ReadLine();
            }
            
            Console.Clear();
        }
    }
}
