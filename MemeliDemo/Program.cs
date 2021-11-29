using _010_Interfaces.Extras.MemeliExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemeliDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IMemeli[] aile = new IMemeli[3];
            aile[0] = new Insan()
            {
                Ad = "Burak",
                Yas = 35,
                Cinsiyet = CinsiyetEnum.Erkek
            };
            aile[1] = new Kopek()
            {
                Ad = "Leo",
                Yas = 7,
                Cinsiyet = CinsiyetEnum.Erkek
            };
            aile[2] = new Kedi()
            {
                Ad = "Muhtar",
                Yas = 2,
                CinsiyetEnum = CinsiyetEnum.Dişi
            };

            foreach (IMemeli uye in aile)
            {
                Console.WriteLine(uye.Ad);
                uye.Ye();
            }

            Insan insan = aile[0] as Insan;
            insan.Konus();
            Kopek kopek1 = aile[1] as Kopek;
            kopek1.Ye();
            IMemeli kedi = aile[2];
            CinsiyetEnum cinsiyet = kedi.Cinsiyet;
            Console.WriteLine(cinsiyet);

            Console.ReadKey();

        }
    }
}
