using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rows & columns");
            int r1=int.Parse(Console.ReadLine());

            
            int c1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter rows & columns");
            int r2 = int.Parse(Console.ReadLine());
            
            int c2 = int.Parse(Console.ReadLine());

            int[,]a=new int[r1,c1];
            int[,]b=new int[r2,c2];
            int[,]c=new int[r1,c2];
            Console.WriteLine("Enter rows & colummns of MatrixA");
            for(int i = 0; i < r1; i++)
            {
                for(int j = 0; j < c1; j++)
                {
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Enter rows & columns of MatrixB");
            for (int i = 0; i < r2; i++)
            {
                for (int j = 0; j < c2; j++)
                {
                    b[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < r1; i++)
            {
                for (int j = 0; j < c2; j++)
                {
                    c[i, j] = 0;
                    c[i, j] = c[i, j] + a[i, j] * b[i, j];
                }
            }
            Console.WriteLine("After multiplication");
            for (int i = 0; i < r1; i++)
            {
                for (int j = 0; j < c2; j++)
                {
                    Console.Write(c[i, j]+" ");
                }
                Console.WriteLine();
            }

        }
    }
}
