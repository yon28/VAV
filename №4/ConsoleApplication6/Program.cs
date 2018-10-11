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
            if (CheckOrdinary(str))
            {
                Console.WriteLine("Это число в обычной нотации.");
            }
            else if (CheckSinse(str))
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

        static bool CheckOrdinary(string str)
        {
            Regex regex = new Regex(@"^-?\d*([\.,\,]\d)?\d*$");
            bool b = regex.IsMatch(str);
            return b;
        }

        static bool CheckSinse(string str)
        {
            Regex regex = new Regex(@"^-?\d([\.,\,]\d)?\d*[e,е]-?\d*$");    //5.75e-5
            //ненормализованная форма (@"^-?\d*(...
            bool b = regex.IsMatch(str);
            return b;
        }
    }
}
