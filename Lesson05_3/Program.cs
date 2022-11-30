using System;

namespace Lesson05_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] a = { { 11, 12, 13, 14 }, { 15, 16, 17, 18 }, { 19, 20, 21, 22 }, 
                { 23, 24, 25, 26 }, { 27, 28, 28, 29 }, { 30, 31, 32, 33 } };

            int[,] b = { { 11, 12, 13, 14 }, { 15, 16, 17, 18 }, { 19, 20, 21, 22 },
                { 23, 24, 25, 26 }, { 27, 28, 28, 29 }, { 30, 31, 32, 33 } };
           
            int[,] c = new int[a.GetLength(0), a.GetLength(1)];

            Console.WriteLine("First Matrix");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("First Matrix");
            Console.WriteLine();
            for (int i = 0; i < b.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    Console.Write(b[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(c[i, j] = a[i, j] + b[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }

        }
    }
}
