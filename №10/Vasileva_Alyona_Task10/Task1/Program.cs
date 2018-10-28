using System;


namespace Task1
{
    //Написать программу, выполняющую сортировку массива строк по возрастанию длины.

    public class Task_1
    {
        static void Main(string[] args)
        {
            string[] arr = Create();
            Console.WriteLine("Сформирован массив строковых переменных: ");
            Write(arr);
            Array.Sort(arr);

            Sorted( arr);
            Console.WriteLine("Отсортированный массив строковых переменных: ");
            Write(arr);
            Console.Read();
        }

       // public event EComparer Сomparer;
        public delegate bool EComparer(string arrj, string arrim);

        public static bool OnComparer(string arrj, string arrim) 
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

        static int IMin( string[] arr, int i)  //Метод, сравнивающий строки, находящий меньшую
        {
            int im = i;
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (!OnComparer(arr[j],arr[im]))
                {
                    im = j;
                } 
            }
            return im;
        }

        public static string[] Create()
        {
            Random rand = new Random();
            string[] arr = new string[rand.Next(3, 10)];

            for (int i = 0; i < arr.Length; i++)
                arr[i] = rand.Next(-3000, 3000).ToString();
            return arr;
        }

        public static void Sorted(string[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int im = IMin( arr, i);
                string x = arr[i];
                arr[i] = arr[im];
                arr[im] = x;
            }
        }

        public static void Write(string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + "  ");
            Console.WriteLine();
        }
    }
}
