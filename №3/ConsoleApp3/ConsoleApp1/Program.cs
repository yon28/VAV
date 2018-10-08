using ClassLibrary1;
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
            int i = 1;
            int im = Min(A, i);
            Console.WriteLine("Минимальное значение: ");
            Console.WriteLine(A[im]);
            Sorted(A);
            Console.WriteLine("Максимальное значение: ");
            Console.WriteLine(A[9]);
            Console.WriteLine("Сортированный массив: ");
            Write(A);
            Console.Read();
            ArrayHelper.Sort();
            ArrayHelper.Sort();
        }

        static void Сreate(int[] A)
        {
            Random rand = new Random();
            for (int i = 0; i < A.Length; i++)
                A[i] = rand.Next(-100, 100);
        }

        static int Min(int[] A, int i)
        {
            int im = i;
            for (int j = i + 1; j < A.Length; j++)
            {
                if (A[j] < A[im])
                {
                    im = j;
                }
            }
            return im;
        }

        static void Sorted(int[] A)
        {
            for (int i = 0; i < A.Length - 1; i++)
            {
                int im = Min(A, i);
                int x = A[i];
                A[i] = A[im];
                A[im] = x;
            }
        }

        static void Write(int[] A)
        {
            for (int i = 0; i < A.Length; i++)
                Console.Write(A[i] + " ");
            Console.WriteLine(); 
        }
    }
}

