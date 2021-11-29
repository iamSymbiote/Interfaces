using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_Interfaces.Extras.MemeliExample
{
    class Insan : IMemeli
    {
        public string Ad { get; set; }
        public int Yas { get; set; }
        public CinsiyetEnum Cinsiyet { get; set; }

        public void Kos()
        {
            Console.WriteLine("{0} ({1}, {2}) insan koşar.", Ad, Yas, Cinsiyet);
        }

        public void Uyu()
        {
            Console.WriteLine("{0} ({1}, {2}) insan uyur.", Ad, Yas, Cinsiyet);
        }

        public void Ye()
        {
            Console.WriteLine("{0} ({1}, {2}) insan yer.", Ad, Yas, Cinsiyet);
        }

        public void Konus()
        {
            Console.WriteLine($"{Ad}, {Yas}, {Cinsiyet} insan konuşur.");           //dolarli yazim daha kolay buna alis!!!
        }
    }
}
