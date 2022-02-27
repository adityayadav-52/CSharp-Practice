using System;
namespace ConsoleApp6
{
    class Employee<T>
    {
        T x;
        T y;
        public Employee(T x, T y)
        {
            this.x = x;
            this.y = y;
            Console.WriteLine("A  {0}  B{1}", x, y);
        }
        public void showDeatil()
        {
           
        }
          
    }
    class Program
    {

        static void Main(string[] args)
        {

            Employee<int> obj = new Employee<int>(34, 67);
            Employee<string> obj1 = new Employee<string>("Amit Kumar", "Suresh Kumar");


            Console.WriteLine("Hello World!");


        }
    }
}
