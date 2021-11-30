using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    class Program
    {
        static void Main(string[] args)
        {
            IWorker manager = new Manager();
            manager.Eat();
            Employee employee = new Employee();
            employee.GetSalary();
            Robot robot = new Robot();
            robot.Work();
            Console.ReadKey();

        }
    }
    public interface IWorker
    {
        void GetSalary();
        void Eat();
    }

    class Manager : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Manager works");
        }
        public void GetSalary()
        {
            Console.WriteLine("Manager gets salary");
        }
        public void Eat()
        {
            Console.WriteLine("Manager eats");
        }
    }
    public class Employee : IWorker
    {
        public void Eat()
        {
            Console.WriteLine("Employee eats");
        }

        public void GetSalary()
        {
            Console.WriteLine("Employee gets salary");
        }

        public void Work()
        {
            Console.WriteLine("Employee works");
        }
    }

    public class Robot : IWork  // alttakinden implement ediyoruz, sadece WORK  yapacagi icin. Diger komutlari sildik.
    {
 
        public void Work()
        {
            Console.WriteLine("Robot works");
        }
    }

    public interface IWork
    {
        void Work();
    }
}
