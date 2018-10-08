using System;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введи число: ");
            string str = Console.ReadLine();
            if (Check_Ordinary(str))
            {
                Console.WriteLine("Это число в обычной нотации.");
            }
            else if (Check_Sinse(str))
            {
                Console.WriteLine("Это число в научной нотации.");
            }
            else
            {
                Console.WriteLine("Разве это число?");
            }
            Console.WriteLine("Проверка окончена.");
            Console.ReadLine();
        }

        static bool Check_Ordinary(string str)
        {
            Regex regex = new Regex(@"^-?\d*([\.,\,]\d)?\d*$");
            bool b = regex.IsMatch(str);
            return b;
        }

        static bool Check_Sinse(string str)
        {
            Regex regex = new Regex(@"^-?\d([\.,\,]\d)?\d*[e,е]-?\d*$");    //5.75e-5
            //ненормализованная форма (@"^-?\d*(...
            bool b = regex.IsMatch(str);
            return b;
        }
    }
}
