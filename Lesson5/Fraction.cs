using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnRandomFloat._003_base_OOP.HoweWork
{
    class Fraction
    {
        //private int _whole;
        private int _numerator;
        private int _denominator;
        public int Numerator
        {
            get { return _numerator; }
            set { _numerator = value; }
        }
        public int Denominator
        {
            get { return _denominator; }
            set { _denominator = value; }
        }
        public Fraction(int a, int b, bool reduction = false)
        {

            if (reduction)
            {
                int nod = NOD(a, b);
                _numerator = Convert.ToInt32(a / (float)nod);
                _denominator = Convert.ToInt32(b / (float)nod);
            }
            else
            {
                _numerator = a;
                _denominator = b;
            }

        }

        public static bool operator ==(Fraction f1, Fraction f2)
        {
            return f1._numerator / (float)f1._denominator == f2._numerator / (float)f2._denominator;
        }
        public static bool operator !=(Fraction f1, Fraction f2)
        {
            return f1._numerator / f1._denominator != f2._numerator / f2._denominator;
        }
        public static bool operator >(Fraction f1, Fraction f2)
        {
            return f1._numerator / f1._denominator > f2._numerator / f2._denominator;
        }
        public static bool operator <(Fraction f1, Fraction f2)
        {
            return f1._numerator / f1._denominator < f2._numerator / f2._denominator;
        }
        public static bool operator >=(Fraction f1, Fraction f2)
        {
            return f1._numerator / f1._denominator >= f2._numerator / f2._denominator;
        }
        public static bool operator <=(Fraction f1, Fraction f2)
        {
            return f1._numerator / f1._denominator <= f2._numerator / f2._denominator;
        }
        public static Fraction operator +(Fraction f1, Fraction f2)
        {

            Fraction f3 = new Fraction(f1._numerator * f2._denominator + f2._numerator * f1._denominator, f1._denominator * f2._denominator);

            return f3;
        }
        public static Fraction operator -(Fraction f1, Fraction f2)

        {
            Fraction f3 = new Fraction(f1._numerator * f2._denominator - f2._numerator * f1._denominator, f1._denominator * f2._denominator);

            return f3;
        }
        public static Fraction operator ++(Fraction f)
        {

            f._numerator = f._numerator + f._denominator;


            return f;
        }
        public static Fraction operator --(Fraction f)
        {

            f._numerator = f._numerator - f._denominator;
            return f;
        }
        public static Fraction operator /(Fraction f1, Fraction f2)
        {
            Fraction f3 = new Fraction(f1._numerator * f2._denominator, f1._denominator * f2._numerator);
        
            return f3;
        }
        public static Fraction operator *(Fraction f1, Fraction f2)
        {
            Fraction f3 = new Fraction(f1._numerator * f2._numerator, f1._denominator * f2._denominator);

            return f3;
        }
        public static implicit operator float(Fraction f1)
        {
            return f1._numerator / (float)f1._denominator;
        }
        public static explicit operator int(Fraction f1)
        {
            return f1._numerator / f1._denominator;
        }
        public override bool Equals(object obj)
        {
            Fraction f1 = obj as Fraction;
            if((float)f1==(float)this)
             {
                return true;
            }
            return false;
        }
        public override string ToString()
        {
            int tempnum;
            float result;
            if (Math.Abs(_numerator) > _denominator)
            {

                result = Math.Abs(_numerator / (float)_denominator);
                int resultoint = Convert.ToInt32(MathF.Floor(result));
                if (_numerator > 0)
                {
                    tempnum = _numerator - resultoint * _denominator;
                }
                else
                {
            
                    tempnum = _numerator + resultoint * _denominator;
                    resultoint *= -1;
                    tempnum *= -1;
                }


                if (tempnum == 0)
                {
                    return resultoint.ToString();
                }
                else
                {
                    return resultoint + " " + tempnum + @"/" + _denominator;
                }
            }
            else if (_numerator == _denominator)
            {
    
                return "1";
            }
            else if (_numerator*-1 == _denominator)
            {

                return "-1";
            }
            else if (_numerator == 0)
            {

                return "0";
            }
            else
            {
                return _numerator + @"/" + _denominator;
            }

        }
        int NOD(int d1, int d2)
        {
            d1 = Math.Abs(d1);
            d2 = Math.Abs(d2);
            if (d1 != 0 && d2 != 0)
            {

                while (d1 != d2)
                {
                    if (d1 > d2)
                    {
                        d1 = d1 - d2;
                    }
                    else
                    {
                        d2 = d2 - d1;
                    }
                }
                return d2;
            }
            return 1;
        }
        public void Reductions()
        {
            if (_numerator != 0)
            {
                int n = NOD(_numerator, _denominator);
                _numerator /= n;
                _denominator /= n;
            }
        }
    }
}
