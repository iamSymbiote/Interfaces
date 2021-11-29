using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesWithMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            IService service = new StudentService();
            service.Add("Burak");
            service.Update("Tosun", 1);
            service.Delete(2);
            string[] students = service.Read();
            foreach (string student in students)
            {
                Console.WriteLine(student);
            }
            Console.ReadKey();
        }
    }

    interface IService
    {
        string[] Read();
        void Add(string ogrenci);
        void Update(string ogrenci, int index);
        void Delete(int index);
    }

    class StudentService : IService
    {
        public void Add(string ogrenci)
        {
            Console.WriteLine("Student " + ogrenci + " added to database.");
        }

        public void Delete(int index)
        {
            Console.WriteLine("Student " + index + " deleted.");
        }

        public string[] Read()
        {
            string[] students = new string[3]  //string[] yerine 'var' da kullanilabilirdi.
           {
                "Ali",
                "Veli",
                "Ahmet",
           };
            return students;
        }

        public void Update(string ogrenci, int index)
        {
            Console.WriteLine("Student " + ogrenci + " deleted.");
        }
    }
}
