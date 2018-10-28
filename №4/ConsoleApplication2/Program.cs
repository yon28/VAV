using System;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введи строку (например, предложение).");
            string str = Console.ReadLine();
            Regex regex = new Regex(@"\W");
            string[] words = regex.Split(str);
            int sum = 0;
            foreach (var word in words)
            {
                sum = sum + word.Length;
            }
            Console.WriteLine("Средняя длина слов: " + sum / words.Length + ".");
            Console.ReadLine();
        }
        //https://docs.microsoft.com
        //Cплитить через регулярки, а не массив раздел символов. /w или /W
        
    }
}
