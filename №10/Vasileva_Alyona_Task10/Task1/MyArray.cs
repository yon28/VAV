using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    //Написать программу, выполняющую сортировку массива строк по возрастанию длины.
    public class MyArray
    {
        public delegate bool ECompare(string arrj, string arrim);
        public ECompare compare = OnCompare;
        public static bool OnCompare(string arrj, string arrim) //Метод, сравнивающий строки
        {
            bool b = true;
            if (arrj.Length < arrim.Length)
            {
                b = false;
            }
            else if (arrj.Length == arrim.Length)
            {
                if (arrj.CompareTo(arrim) < 0)
                {
                    b = false;    /*Если строки состоят из равного числа символов, их следует отсортировать по алфавиту.*/
                }
            }
            return b;
        }

        static int IndexMin(string[] arr, int i, ECompare compare)  //Метод, находящий меньшую строку //compare
        {
            int im = i;
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (!compare(arr[j], arr[im]))       //compare
                {
                    im = j;
                }
            }
            return im;
        }

        public static void SortMin(string[] arr,ECompare compare)  //compare
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int im = IndexMin(arr, i, compare);
                string x = arr[i];
                arr[i] = arr[im];
                arr[im] = x;
            }
        }

        public static string[] Create()
        {
            Random rand = new Random();
            string[] arr = new string[rand.Next(3, 10)];

            for (int i = 0; i < arr.Length; i++)
                arr[i] = rand.Next(-3000, 3000).ToString();
            return arr;
        }
        public static void Write(string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + "  ");
            Console.WriteLine();
        }
    }
}
