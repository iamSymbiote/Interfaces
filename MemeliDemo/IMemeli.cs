using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_Interfaces.Extras.MemeliExample
{
    interface IMemeli
    {
        string Ad { get; set; }
        int Yas { get; set; }
        CinsiyetEnum Cinsiyet { get; set; }

        void Kos();
        void Uyu();
        void Ye();
        //void Konus(); // sadece insan konuşur, köpek ve kedi konuşmaz
    }
}
