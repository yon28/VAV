
using System;

namespace ConsoleApp3
{
    class Task1
    {
        static void Main(string[] args)
        {
            int[,] A = new int[5, 5];
            Console.WriteLine("Привет!");
            Console.WriteLine("Сформирован двумерный массив  целых чисел: ");
            Сreate(A);
            Write(A);
            int S = Sum(A);
            Console.WriteLine("Сумма элементов массива, стоящих на четных позициях: ");
            Console.WriteLine(S);
            Console.Read();
        }

        static int[,] Сreate(int[,] A)
        {
            Random rand = new Random();
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                        A[i, j] = rand.Next(-50, 50);
            return A;
        }

        static int[,] Write(int[,] A)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                        Console.Write("{0,5}", A[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            return A;
        }

        static int Sum(int[,] A)
        {
            int S = 0;
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                if ((i+j) % 2 == 0)
                {
                    S = S + A[i,j];
                }

            return S;
        }  
    }
}

