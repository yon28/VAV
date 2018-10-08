using System;
using System.Text;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введи первую строку.");
            string str1 = Console.ReadLine();
            Console.WriteLine("Введи вторую строку.");
            string str2 = Console.ReadLine();
            StringBuilder result = new StringBuilder();
            foreach (var ch in str1)
            {
                result.Append(ch);
                if (str2.Contains(ch.ToString()))
                {
                    result.Append(ch);
                }
            }
            Console.WriteLine("Модификация первой строки: ");
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
