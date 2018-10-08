
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

        static void Сreate(int[,,] A)
        {
            Random rand = new Random();
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                    for (int g = 0; g < 5; g++)
                    {
                        A[i, j, g] = rand.Next(-50, 50);
                    }
        }

        static void Zeroize(int[,,] A)
        {
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                    for (int g = 0; g < 5; g++)
                        if (A[i, j, g] > 0)
                        {
                            A[i, j, g] = 0;
                        }
        }

        static void Write(int[,,] A)
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
        }
    }
}

