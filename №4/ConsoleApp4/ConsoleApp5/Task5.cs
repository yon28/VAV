using System;
using System.Text.RegularExpressions;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введи HTML текст.");
            string str = Console.ReadLine();
            str = Replace(str);
            Console.WriteLine("Результат замены: ");
            Console.WriteLine(str);
            Console.ReadLine(); 
        }

        static string Replace(string str)
        {
            Regex regex = new Regex(@"<.[^<>]*>");
            str = regex.Replace(str, "_ ");
            return str;
        }
    }
}
