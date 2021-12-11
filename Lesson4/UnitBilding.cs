using System;
using System.Collections.Generic;
using UnRandomFloat._003_base_OOP.HoweWork;

class UnitBilding : MenuAndChoice
{
    private static int nextBildingNumber = 1;
    private int _currentbildNumber = 0;
    private double _height;
    private int _floors;
    private byte _approach;
    private int _flatRooms;
    static string[] menuRows =
      {   "1. Получить номер текущего здания и вывести в консоль.",
          "2. Получить и вывести в консоль высоту текущего здания.",
          "3. Задать высоту здания.",
          "4. Получить и вывести количество этажей.",
          "5. Задать количество этажей текущего здания.",
          "6. Получить и вывести количество подъездов.",
          "7. Задать количество подъездов текущего здания.",
          "8. Получить и вывести количество квартир.",
          "9. Задать количество квартир.",
          "10. Получить и вывести количество квартир в подъезде.",
          "11. Получить и вывести высоту этажа.",
               };
    internal UnitBilding()
    {
        _height = 27;
        _floors = 9;
        _approach = 3;
        _flatRooms = 81;
        nextBild();
        _Menu = new Menu(menuRows);
    }
    public int BildNumber
    {
        get { return _currentbildNumber; }
    }
    public double Height
    {
        get { return _height; }
        set
        {
            if (value / _floors < 2.4 || value / _floors > 3.2)
            {
                loger($"При указанной высоте, высота одного этажа составит - " +
                $"{value / _floors}! Согласно нормам высота этажа должная быть в диапозоне 2,4-3,2 м");
                _height = value;
            }
            else
            {
                _height = value;
            }
        }
    }
    public int Floors
    {
        get { return _floors; }
        set
        {
            if (_height / value > 3.2 || _height / value < 2.4)
            {
                loger($"Некорректное количество этажей." +
                    $"Получившаяся высота этажа должна быть в диапозоне 2,4-3,2 м. " +
                    $"При заданом количестве этажей высота - {_height / value}." +
                    $"Рекомендую увеличить высоту здания до {value*3} м.") ;
                _floors = value;
            }
            else
            {
                _floors = value;
            }
        }
    }
    public byte Approach
    {
        get { return _approach; }
        set { _approach = value; }
    }
    public int FlatRooms
    {
        get { return _flatRooms; }
        set { _flatRooms = value; }
    }
    public double GetFloorHeight()
    {
        return _height / _floors;
    }

    public int GetFlatsPerApproach()
    {
        return _flatRooms / _approach;
    }
    private void nextBild()
    {
        _currentbildNumber = nextBildingNumber;
        nextBildingNumber++;
    }
    public override void GetStart()
    {
        while (!selected.Item2)
        {
            switch (selected.Item1)
            {
                case 1:
                    Console.WriteLine($"Номер текущего здания - {BildNumber}");
                    break;
                case 2:
                    Console.WriteLine($"Высота здания - {Height} м");
                    break;
                case 3:
                    Height = choice.FromRandom(3, 830, "Введите высоту здания (м) в диапозоне").Item1;
                    break;
                case 4:
                    Console.WriteLine($"Количество этажей - {Floors}");      
                    break;
                case 5:
                    Floors = choice.FromRandom(1, 164, "Введите количество этажей").Item1;
                    break;
                case 6:
                    Console.WriteLine($"Количество подъездов - {Approach}");
                    break;
                case 7:
                    Approach = (byte)choice.FromRandom(1, 20, "Введите количество подъездов").Item1;
                    break;
                case 8:
                    Console.WriteLine($"Количество подъездов - {FlatRooms}");
                    break;
                case 9:
                    FlatRooms = choice.FromRandom(2 * Floors * Approach, 5 * Floors * Approach, "Введите количество квартир").Item1;
                    break;
                case 10:
                    Console.WriteLine($"Количество квартир в подъезде - {GetFlatsPerApproach()}");
                    break;
                case 11:
                    Console.WriteLine($"Высота одного этажа - {GetFloorHeight()}");
                    break;

            }
            AcceptAndReChoice();
        }
    }
    void AcceptAndReChoice()
    {
        PrepareСonsole();
        PrintMenuAndSelect(false);
    }
    void loger(string s)
    {
        Console.WriteLine(s);
    }
}

