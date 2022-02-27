using System;
namespace ConsoleApp6
{
    class Employee
    {
        public  static bool check<T>(T a, T b)
        {
            bool x = a.Equals(b);
            return x;
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Employee.check(2, 2));
            Console.WriteLine(Employee.check("abc", "Abc"));
           



        }
    }
}
