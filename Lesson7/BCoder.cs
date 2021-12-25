using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnRandomFloat._003_base_OOP.HoweWork
{
    class BCoder : ACoder
    {
        public override string CodeDecode(string s, bool needDecode = true)
        {
            char[] charArray = s.ToCharArray();
            for (int i = 0; i < charArray.Length; i++)
            {
                if (needDecode)
                {
                    if (Char.IsLower(charArray[i]))
                    {
                        int x = charArray[i]- 'я';
                        charArray[i] = (char)((int)'я' - 31 - x);
                    }
                    else if (Char.IsUpper(charArray[i]))
                    {
                        int x = charArray[i]- 'Я';
                        charArray[i] = (char)((int)'Я' - 31 - x);
                    }
                }
                else
                {

                    if (Char.IsLower(charArray[i]))
                    {
                        int x = charArray[i] - 'а';
                        charArray[i] = (char)((int)'а' + (31 - x));
                    }
                    else if(Char.IsUpper(charArray[i]))
                    {
                        int x = charArray[i] - 'А';
                        charArray[i] = (char)((int)'А' + (31 - x));
                    }
                }
            }
            return new string(charArray);
        }
    }
}
