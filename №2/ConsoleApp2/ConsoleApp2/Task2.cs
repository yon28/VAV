using System;


namespace ConsoleApp2
{
    class Task2
    {
        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.WriteLine("Введи натуральное число, пожалуйста!");
            }
            while (!(int.TryParse(Console.ReadLine(), out n) & (n > 0)));
            Console.WriteLine("Вывод в форме прямоугольного треугольника:");
            string s = "";
            for (int i = 1; i <= n; i++)
            {
                s = s + "*";
                Console.WriteLine(s);
            }
            Console.ReadLine();
        }
    }
}
