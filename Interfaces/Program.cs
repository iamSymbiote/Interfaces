using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person()
            {
                Id = 1,
                FirstName = "Burak",
                LastName = "Guvenc",
            };
            IPerson person2 = new Person();
            person2.FirstName = "Nihan";
            person2.LastName = "Guvenc";
            person2.Id = 2;

            Customer customer1 = new Customer()

            {
                Id = 3,
                FirstName = "Ilay",
                LastName = "Guvenc",
                Address = "Ankara",
            };
            Console.WriteLine(customer1.Id + customer1.FirstName + customer1.LastName + customer1.Address);

            IPerson customer2 = new Customer()
            {
                Id = 4,
                FirstName = "Rainbow",
                LastName = "Dash",
                Address = "Equestria",
            };
            Console.WriteLine(customer2.Id + customer2.FirstName + customer2.LastName);
            Console.WriteLine(((Customer)customer2).Address);

            IPerson customer3 = new Customer();
            customer3.Id = 5;
            customer3.FirstName = "Twilight";
            customer3.LastName = "Sparkle";

            IPerson student1 = new Student()
            {
                Id = 10,
                FirstName = "Rarity",
                LastName = "Pony",
                Department = "Fashion Designer"
            };
            //string department = ((Student)student1).Department;*/ // alttaki bunun farkli yazimi.
            string department = (student1 as Student).Department;


        }
    }
    interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }

    class Person : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Customer : IPerson   //customer'i ozel bir insana implement ettik IPerson interfaceine.
    {
        public int Id { get ; set ; }
        public string FirstName { get ; set ; }
        public string LastName { get ; set ; }
        public string Address { get; set; }

    }

    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
    }

}
