using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnRandomFloat._003_base_OOP.HoweWork
{
    class _HomeWork7 :MenuAndChoice
    {
        MenuAndChoice[] lessonItems =
        {
            new ACoder(),
            new BCoder(),
        };
        string[] menuRows =
            {
            "1.Метод шифровки со сдвигом на одну альфавитную позицию",
            "2.Метод шифровки со сдвигом на зеркальную сконца позицию"
            };
        public _HomeWork7()
        {
            _Menu = new Menu(menuRows);
            items = lessonItems;
        }
    }
}
