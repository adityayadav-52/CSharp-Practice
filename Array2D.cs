using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array2D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[3, 3];
            Console.WriteLine("Enter matrix 3x3 ");
            for(int i=0; i<=2; i++)
            {
                for(int j=0; j<=2; j++)
                {
                    arr[i,j]=int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Matrix Is :");
            for (int i = 0; i <= 2; i++)
            {
                for (int j = 0; j <= 2; j++)
                {
                    Console.Write(arr[i,j]+" ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
