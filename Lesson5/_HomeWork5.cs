using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnRandomFloat._003_base_OOP.HoweWork
{
    class _HomeWork5 : MenuAndChoice
    {
        List<Fraction> listFractions = new List<Fraction>();

        Fraction oneFractions = null;
        Fraction twoFractions = null;
        Fraction resultFraction = null; //для хранения результата арифметических действий с дробями 1 и 2
        string lastOperation;

        static string[] menuRows =
            {   "1. Создать(или редактировать) первую дробь",
                "2. Создать(или редактировать) вторую дробь",
                "3. Равны ли дроби (==)",
                "4. Первая дробь больше чем вторая? (>)",
                "5. Первая дробь меньше чем вторая? (<)",
                "6. Первая дробь больше или равна второй? (>=)",
                "7. Первая дробь меньше или равна второй? (<=)",
                "8. Сложить первую и вторую дробь (+). Результат сохранить",
                "9. Вычесть вторую дробь из первой (-). Результат сохранить",
                "10. Перемножить дроби (*). Результат сохранить",
                "11. Разделить перую дробь на вторую(/). Результат сохранить",
                "12. Инкрементировать первую дробь(++)",
                "13. Инкрементировать вторую дробь(++)",
                "14. Декрементировать первую дробь(--)",
                "15. Декрементировать вторую дробь(--)",
                "16. Сократить дроби по возможности",
                       "17. Equals",

               };
        public _HomeWork5()
        {
            _Menu = new Menu(menuRows);
            oneFractions =new Fraction(1,2);
            twoFractions =new Fraction(1,2);
            lastOperation = " (сложение)";
            resultFraction = oneFractions + twoFractions;

        }
        public override void PrintMenu()
        {
            Console.WriteLine("Первая дробь - {0} \nВторая дробь - {1} \nРезультат последней операции - {2}{3}", oneFractions.ToString(), twoFractions.ToString(), resultFraction.ToString(), lastOperation);
            base.PrintMenu();
        }
        public override void GetStart()
        {
            while (!selected.Item2)
            {
                switch (selected.Item1)
                {
                    case 1:
                        int a = choice.FromRandom(int.MinValue / 100, int.MaxValue / 100, "Введите числитель").Item1;
                        int b = choice.FromRandom(1, int.MaxValue / 100, "Введите знаменатель").Item1;
                        Fraction tempFraction=new Fraction(a, b);
                        oneFractions = tempFraction;
                        break;
                    case 2:
                        int a1 = choice.FromRandom(int.MinValue / 100, int.MaxValue / 100, "Введите числитель").Item1;
                        int b1 = choice.FromRandom(1, int.MaxValue / 100, "Введите знаменатель").Item1;
                        
                        twoFractions = new Fraction(a1, b1);
                        break;
                    case 3:
                        if (oneFractions == twoFractions)
                        {
                            Console.WriteLine("Дроби равны");
                        }
                        else
                        {
                            Console.WriteLine("Дроби не равны");
                        }
                        break;
                    case 4:
                        if (oneFractions > twoFractions)
                        {
                            Console.WriteLine("Первая дробь больше второй");
                            break;
                        }
                        Console.WriteLine("Первая дробь НЕ больше второй");
                        break;
                    case 5:
                        if (oneFractions < twoFractions)
                        {
                            Console.WriteLine("Первая дробь меньше второй");
                            break;
                        }
                        Console.WriteLine("Первая дробь НЕ меньше второй");
                        break;
                    case 6:
                        if (oneFractions >= twoFractions)
                        {
                            Console.WriteLine("Первая дробь больше или равна второй");
                            break;
                        }
                        Console.WriteLine("Первая дробь НЕ больше и НЕ равна второй");
                        break;
                    case 7:
                        if (oneFractions <= twoFractions)
                        {
                            Console.WriteLine("Первая дробь меньше или равна второй");
                            break;
                        }
                        Console.WriteLine("Первая дробь НЕ меньше и НЕ равна второй");
                        break;
                    case 8:
                        lastOperation = " (сложение)";
                        resultFraction = oneFractions + twoFractions;
                        break;
                    case 9:
                        lastOperation = " (вычетание)";
                        resultFraction = oneFractions - twoFractions;
                        break;
                    case 10:
                        lastOperation = " (умножение)";
                        resultFraction = oneFractions * twoFractions;
                        break;
                    case 11:
                        lastOperation = " (деление)";
                        resultFraction = oneFractions / twoFractions;
                        break;
                    case 12:
                        oneFractions++;
                        break;
                    case 13:
                        twoFractions++;
                        break;
                    case 14:
                        oneFractions--;
                        break;
                    case 15:
                        twoFractions--;
                        break;
                    case 16:
                        oneFractions.Reductions();
                        twoFractions.Reductions();
                        resultFraction.Reductions();
                        break;
                    case 17:
                        Console.WriteLine(oneFractions.Equals(twoFractions));
                        break;
                }
                PrepareСonsole();               
                PrintMenuAndSelect(false);
            }
            void sdsw()
            {
                Console.WriteLine(twoFractions.ToString());
            }
        }
    }
}
