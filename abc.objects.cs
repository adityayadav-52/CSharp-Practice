using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp1
{
   
    class Employee
    {
        private string name;
        private int salary;
        private int empId;

        public void setDeatil(string name, int salary, int emiId)
        {
            this.name = name;
            this.salary = salary;
            this.empId = empId;

        }
       public  void getDetail()
        {
            Console.WriteLine("Name {0}  Salary {1}  Emp ID{2}", name, salary, empId);
        }
     
    }



    class Program
    {
        static void Main(string[] args)
        {
            Employee obj1 = new Employee();
            Console.WriteLine();
            obj1.setDeatil("Amit Kumar",4000, 123);
            obj1.getDetail();

            Console.ReadLine();

        }
    }
}
