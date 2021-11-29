using _010_Interfaces.Extras.MemeliExample;
using System;

namespace MemeliDemo
{
    internal class Kedi : IMemeli
    {
        public string Ad { get; set; }
        public int Yas { get; set; }
        public CinsiyetEnum CinsiyetEnum { get; set; }
        public CinsiyetEnum Cinsiyet { get ; set ; }

        public void Kos()
        {
            Console.WriteLine("{0} ({1}, {2}) kedi koşar.", Ad, Yas, Cinsiyet);
        }

        public void Uyu()
        {
            Console.WriteLine("{0} ({1}, {2}) kedi uyur.", Ad, Yas, Cinsiyet);
        }

        public void Ye()
        {
            Console.WriteLine("{0} ({1}, {2}) kedi yer.", Ad, Yas, Cinsiyet);
        }
    }
}