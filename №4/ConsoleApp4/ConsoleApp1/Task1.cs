using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введи строку (например, предложение).");
            string str = Console.ReadLine();
            string[] A = str.Split(' ', '.', ';', ',', '(', ')', '[', ']', '<', '>', '+', '-', '}', '{', '/', '*', '=');
            int S = 0;
            foreach (var word in A)
            {
                S = S + word.Length;
            }
            Console.WriteLine("Средняя длина слов: " + S/A.Length +".");
            Console.ReadLine();
        }
    }
}
