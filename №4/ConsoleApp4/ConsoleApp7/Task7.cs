using System;
using System.Text.RegularExpressions;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введи текст, чтобы программа определила, сколько раз в нём встречается время: ");
            string str = Console.ReadLine();
            int s = Counting_time(str);
            if ((s % 10 == 2) | (s % 10 == 3) | (s % 10 == 4))
            {
                Console.WriteLine("Время в тексте присутствует " + s + " разa.");
            }
            else
            {
                Console.WriteLine("Время в тексте присутствует " + s + " раз.");
            }
            Console.ReadLine();
        }

        static int Counting_time(string str)
        {
            Regex regex = new Regex(@"(([0,1]?\d)|(2[0-3])):[0-5]\d");
            int s = regex.Matches(str).Count;
            return s;
        }
    }
}
