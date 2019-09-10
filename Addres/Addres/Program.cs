using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addres
{
    class Program
    {
        static void Main(string[] args)
        {
            String Name = "";
            Console.WriteLine("Enter You Name Please");
            Name = Console.ReadLine();
            String Age = "";
            Console.WriteLine("Enter You Age Please");
            Age = Console.ReadLine();
            String Address = "";
            Console.WriteLine("Enter You Address Please");
            Address = Console.ReadLine();
            String Contact = "";
            Console.WriteLine("Enter You Contact Please");
            Contact = Console.ReadLine();
            Console.WriteLine("Profile Details");
            Console.WriteLine("Name:" +Name);
            Console.WriteLine("Age:" +Age);
            Console.WriteLine("Address:" +Address);
            Console.WriteLine("Contact:" +Contact);
            Console.ReadKey();
        }
    }
}
