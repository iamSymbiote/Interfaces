using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HasARelationshipDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Bilgisayar bilgisayar1 = new Bilgisayar()
            {
                Marka = "AMD",
                Model = "ROG",
                Islemci = new Islemci()
                {
                    GHz = 4,
                    IntelMi = true,
                    Modeli = "i9",
                },
                Hafiza = new Hafiza()
                {
                    GB = 64,
                    Marka = "Kingston",
                }

            };

            Console.WriteLine($"Marka: {bilgisayar1.Marka}, " +
                $"Model: {bilgisayar1.Model}  " +
                $"\nCPU: {(bilgisayar1.Islemci.IntelMi == true ? "Intel" : "AMD")} , {bilgisayar1.Islemci.GHz}, " +
                $"\nRAM: {bilgisayar1.Hafiza.GB}, " +
                $"\nMarka: {bilgisayar1.Hafiza.Marka}");
            Console.ReadKey();

        }
    }

    class Bilgisayar
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public Islemci CPU { get; set; }
        public Hafiza Ram { get; set; }
        public Islemci Islemci { get;  set; }
        public Hafiza Hafiza { get;  set; }
    }

    class Islemci
    {
        public double GHz { get; set; }
        public bool IntelMi{ get; set; }
        public string Modeli { get; set; }
    }

    class Hafiza
    {
        public short GB { get; set; }
        public string Marka { get; set; }
    }
}
