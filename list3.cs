
using System.Collections.Generic;
using System;

namespace ConsoleApp6
{
    class Employee
    {
      
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<int>   data= new List<int>();
            data.Add(23); 
            data.Add(67);  
            data.Add(100);  
            data.Add(56);
            /* foreach(int x in data)
              {
                  Console.WriteLine(x);
              } */

            /* data.Remove(67);

              foreach(int x in data)
           {
               Console.WriteLine(x);
           } */

            /* data.RemoveAt(1);

             foreach(int x in data)
          {
              Console.WriteLine(x);
          }  */

            if (data.Contains(70))
            {
                Console.WriteLine("Exist data");
            }
            else
            {
                Console.WriteLine(" Not Exist data");
            }


