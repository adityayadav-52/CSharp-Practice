using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticConstructor
{
    class person
    {
        public static string personName;
        public static int age;
        static person()
        {
            personName = "Aditya";
            age = 19;
            Console.WriteLine("Static constructor invoked..!!");
        }
        public person()
        {
            Console.WriteLine("Default constructor invoked..!!");
        }
        public static void getDetails()
        {
            Console.WriteLine("Person name is : {0}",personName);
            Console.WriteLine("Person age is : {1}", age);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            person aadi = new person();
            person sanju = new person();
            Console.ReadLine();
        }
    }
}
