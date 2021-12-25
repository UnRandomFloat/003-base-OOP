using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnRandomFloat._003_base_OOP.HoweWork
{
    interface ICoder
    {
        string Encode(string s);
        string Decode(string s);
    }
}
