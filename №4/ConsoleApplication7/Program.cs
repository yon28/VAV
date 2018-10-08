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
            int sum = Counting_time(str);
            if ((sum % 10 == 2) | (sum % 10 == 3) | (sum % 10 == 4))
            {
                Console.WriteLine("Время в тексте присутствует " + sum + " разa.");
            }
            else
            {
                Console.WriteLine("Время в тексте присутствует " + sum + " раз.");
            }
            Console.ReadLine();
        }
        //другие культуры не смотреть. Словесное описние 7 вечера тоже не считать. 
        //Пробелами время быть выделено не обязано.
        static int Counting_time(string str)
        {
            Regex regex = new Regex(@"\b(([0,1]?\d)|(2[0-3])):[0-5]\d");
            int sum = regex.Matches(str).Count;
            return sum;
        }
    }
}
