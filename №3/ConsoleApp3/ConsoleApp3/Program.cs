
using System;

namespace ConsoleApp3
{
    class Task1
    {
        static void Main(string[] args)
        {
            int[] A = new int[10];
            Console.WriteLine("Привет!");
            Console.WriteLine("Сформирован массив из 10 случайных чисел: ");
            Сreate(A);
            Write(A);
            int S = Sum(A);
            Console.WriteLine("Сумма неотрицательных элементов: ");
            Console.WriteLine(S);
            Console.Read();
        }

        static void Сreate(int[] A)
        {
            Random rand = new Random();
            for (int i = 0; i < A.Length; i++)
                A[i] = rand.Next(-100, 100);
        }

        static int Sum(int[] A)
        {
            int S = 0;
            for (int i = 0; i < A.Length ; i++)
            {
                if (A[i] >= 0)
                {
                    S = S + A[i];
                }
            }
            return S;
        }

        static void Write(int[] A)
        {
            for (int i = 0; i < A.Length; i++)
                Console.Write("{0,5}", A[i]);
            Console.WriteLine();
        }
    }
}

