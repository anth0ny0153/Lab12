using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("John", "Sterling Heights");
            Console.WriteLine(person1.ToString());
            Student student1 = new Student("James", "Troy", 2015, 10000);
            Console.WriteLine("\n"+student1.ToString());
            Staff staff1 = new Staff("Anthony", "Rochester Hills", "Rochester High", 50000);
            Console.WriteLine("\n"+staff1.ToString());
        }
    }
}
