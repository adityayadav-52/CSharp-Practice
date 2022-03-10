using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorOverloading
{
    class Program
    {
        public Program()
        {
            Console.WriteLine("This is the first constructor...!");
        }
        public Program(int a, int b)
        {
            Console.WriteLine("This is the second constructor...!  {0}", (a + b));
        }
        public Program(int a, int b, int c)
        {
            Console.WriteLine("This is the third constructor...!  {0}", (a + b + c));
        }
        public Program(string a, string b, string c)
        {
            Console.WriteLine("This is the fourth constructor...!   {0}", (a + b + c));
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            Program obj1 = new Program(1,2);
            Console.ReadKey();
        }
    }
}
