using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inhertince
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student()
            {
                Id = 1,
                FirstName = "Burak",
                Surname = "Guvenc",
                Department = "Software",
            };
            string department = student.Department;

            Person ogrenci = new Student()
            {
                Id = 2,
                FirstName = "Ilay",
                Surname = "Guvenc",
                Department = "Kiddo"
            };
            Student ogrenciabi = ogrenci as Student;

            Console.WriteLine($"{ogrenciabi.Id}, {ogrenciabi.FirstName}, {ogrenciabi.Surname}, {ogrenciabi.Department} ");


            Customer customer = new Customer()
            {
                Id = 3,
                FirstName = "Nihan",
                Surname = "Guvenc",
                Address = "Ankara"
            };

            Musteri musteri = new Musteri()
            {

                Id = 99,
                FirstName = "Darth",
                Surname = "Vader",
                CardNo = "1234",
                Sehir = new City()
                { 
                Id = 4,
                Name = "Ankara",
                }
            };
            Console.WriteLine($"{musteri.Id}, {musteri.FirstName}, {musteri.Surname}, {musteri.Sehir}, {musteri.CardNo} ");

            Musteri velinimet = new Musteri();
            velinimet.Id = 100;
            velinimet.FirstName = "Veli";
            velinimet.Surname = "Nimet";
            velinimet.CardNo = "9876";
            City sehir = new City()
            {
                Id = 34,
                Name = "Antalya"
            };

            velinimet.Sehir = sehir;

            Console.ReadKey();


        }
    }

    class Person //: Object  
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
    }

    interface IAge
    {
        int Age { get; set; }

    }

    interface ICreditCard
    {
        string CardNo { get; set; }
    }
    class Student : Person, IAge
    {
        public string Department { get; set; }
        public int Age { get; set; }
    }
    class Customer : Person, ICreditCard, IAge
    {
        public string Address { get; set; }
        public string CardNo { get ; set ; }
        public int Age { get; set ; }
    }

    class City
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }
    class Musteri : Person, ICreditCard
    {
        public City Sehir { get; set; }
        public string CardNo { get; set; }
    }
}
