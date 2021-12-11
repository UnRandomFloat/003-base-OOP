using System;

using System.Collections;

namespace UnRandomFloat._003_base_OOP.HoweWork
{
    class _HomeWork4 : MenuAndChoice
    {
        UnitBilding currentBilding=null;
        static string[] creatorMenu =
            {   "1. Добавить новое здание.",
                "2. Редактировать текущее здание",
                "3. Выбрать другое здание",
                "4. Удалить здание",
               };
        static Hashtable databildings = new Hashtable();


        public _HomeWork4()
        {
            _Menu = new Menu(creatorMenu);
           
        }
        public override void PrintMenuAndSelect(bool letsStart = true)
        {
            Console.Clear();
            if (currentBilding != null)
            {
                Console.WriteLine("Текущее здание - " + currentBilding?.BildNumber);
            }
            else if (databildings.Count == 0)
            {
                Console.WriteLine("Нет никаких зданий. Для начала их надо добавить\n");
            }
            else 
            { 
                Console.WriteLine("Текущее здание удалено. Выберите другое\n"); 
            }
            PrintMenu();
            selected=choice.FromMenu(_Menu);
            if (letsStart)
            { GetStart(); }
        }
        static UnitBilding CreateBilding()
        {
            UnitBilding unitBilding = new UnitBilding();
            databildings.Add(unitBilding.BildNumber, unitBilding);
            return unitBilding;
        }
        public void DeleteBilding(int numberBildToDel)
        {
            if (databildings[numberBildToDel] == currentBilding)
            {
                databildings.Remove(numberBildToDel);
                currentBilding = null;
            }
            databildings.Remove(numberBildToDel);
        }
        public bool ShowBildingList(Hashtable ht)
        {
            if (ht.Count == 0)
            {
                Console.WriteLine("Нет доступных зданий!");
                return false;
            }
            else
            {
                foreach (DictionaryEntry de in ht)
                {
                    Console.Write("{0}, ", de.Key);
                }
                Console.WriteLine();
                return true;
            }
        }
        public override void GetStart()
        {
            while (!selected.Item2)
            {
                switch (selected.Item1)
                {
                    case 1:
                        currentBilding= CreateBilding();
                        PrepareСonsole("Здание создано!", false);
                        PrintMenuAndSelect(false);
                        break;
                    case 2:
                        if (currentBilding != null)
                        {
                            currentBilding.PrintMenuAndSelect();
                            PrepareСonsole("", false);
                        }
                        else
                        {
                            Console.WriteLine("Здание не выбрано или не создано! Создайте здание сначала.");
                            PrepareСonsole("", true);
                        }
                        PrintMenuAndSelect(false);
                        break;
                    case 3:
                        if (!ShowBildingList(databildings))
                        {
                            PrepareСonsole();
                            PrintMenuAndSelect(false);
                            continue;
                        }
                        else
                        {
                            currentBilding = (UnitBilding)databildings[choice.FromRandom(1, databildings.Count).Item1];
                            PrepareСonsole();
                            PrintMenuAndSelect(false);
                            break;
                        }
                    case 4:
                        ShowBildingList(databildings);
                        int numberBildToDel = choice.FromHashtable(databildings).Item1;
                        DeleteBilding(numberBildToDel);
                        PrepareСonsole();
                        PrintMenuAndSelect(false);
                        break;
                }
    
               
            }
        }
    }
}
