using System;


namespace ConsoleApp4
{
    class Task4
    {
        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.WriteLine("Введи натуральное число, пожалуйста!");
            }
            while (!(int.TryParse(Console.ReadLine(), out n) & (n > 0)));
            Console.WriteLine("Вывод в форме елочки:");
            for (int j = 1; j <= n; j++)
            {
                var s1 = "*";
                for (int i = 1; i <= j; i++)        // i<= j
                {
                    var s = new string(' ', n - i) + s1;
                    Console.WriteLine(s);
                    s1 += "**";
                }
            }
            Console.ReadLine();
        }
    }
}
