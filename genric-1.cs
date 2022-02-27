using System;
namespace ConsoleApp6
{
    class Employee
    {
        public static void showDeatil<T>(T[] arr)
        {
            foreach (T getvalue in arr)
            {

                Console.WriteLine(getvalue);
            }

        }
    }
    class Program
    {

        static void Main(string[] args)
        {

            int[] data = new int[4];
            data[0] = 23;
            data[1] = 60;
            data[2] = 50;
            data[3] = 70;

            string [] data1 = new string[4];
            data1[0] = "AmitKumar";
            data1[1] = "Md Mehndi";
            data1[2] ="Surya";
            data1[3] = "ASumit Kumar";

            Employee obj1 = new Employee();


            Employee.showDeatil(data);
            Employee.showDeatil(data1);

            Console.WriteLine("Hello World!");


        }
    }
}
