using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введи первую строку.");
            string s1 = Console.ReadLine();
            Console.WriteLine("Введи вторую строку.");
            string s2 = Console.ReadLine();
            string s3="";
            foreach (var c in s1)
            {
                s3 = s3 + c;
                if (s2.Contains(c))
                {
                    s3 = s3 + c;
                }
            }
            Console.WriteLine("Модификация первой строки: ");
            Console.WriteLine(s3);
            Console.ReadLine();
        }
    }
}
