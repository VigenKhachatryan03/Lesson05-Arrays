using System;

namespace Lesson05_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] a = { { 11, 12, 13, 14 }, { 15,16, 17, 18 }, { 19, 20, 21, 22 }, { 23, 24, 25, 26 } };

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (i == j)
                    {
                        for (int y = 0; y < i; y++)
                        {
                            Console.Write("   ");
                        }
                        Console.WriteLine(a[i, j] + " ");
                    }
                }

            }
            Console.WriteLine();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (i < j)
                    {
                        Console.Write(a[i, j] +  " ");
                    }

                    if (i >= j)
                    {
                        Console.Write("   ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
