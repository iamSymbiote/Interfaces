using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Database sql = new SqlDatabase()
            {
                Company = "Microsoft",
                Name = "SQL Server",
            };
            sql.List();
            sql.Add();

            Console.ReadKey();

        }


    }
    class Database
    {
        public string Name { get; set; }
        public string Company;  //eger bir alan public degilse basina `_` konur  // "_company" gibi.


        public void Add()
        {
            Console.WriteLine("Added by " + Name);
        }

        public void Update()
        {
            Console.WriteLine("Updated by " + Name);
        }

        public void Delete()
        {
            Console.WriteLine("Deleted by " + Name);
        }

        public void List()
        {
            Console.WriteLine("Listed by " + Name);
        }
    }

    class SqlDatabase : Database
    { 
    
    }
}
