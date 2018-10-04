
using System;

namespace ConsoleApp3
{
    class Task1
    {
        static void Main(string[] args)
        {
            int[,,] A = new int[5, 5, 5];
            Console.WriteLine("Привет!");
            Console.WriteLine("Сформирован трехмерный массив целых чисел: ");
            Сreate(A);
            Write(A);
            Zeroize(A);
            Console.WriteLine("Новый трехмерный массив: ");
            Console.WriteLine();
            Write(A);
            Console.Read();
        }

        static int[,,] Сreate(int[,,] A)
        {
            Random rand = new Random();
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                    for (int g = 0; g < 5; g++)
                        A[i,j,g] = rand.Next(-50, 50);
            return A;
        }

        static int[,,] Zeroize(int[,,] A)
        {
            int S = 0;
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                    for (int g = 0; g < 5; g++)
                        if (A[i,j,g] > 0)
                        {
                            A[i, j, g] = 0;
                        }
            return A;
        }

        static int[,,] Write(int[,,] A)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    for (int g = 0; g < 5; g++)
                        Console.Write("{0,5}", A[i, j, g]);
                    Console.WriteLine();
                }
            Console.WriteLine();
            }
            Console.WriteLine();
            return A;
        }
    }
}

