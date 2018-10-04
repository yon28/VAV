using System;


namespace ConsoleApp4
{
    class Task4
    {
        static void Main(int j, int n)
        {


            string s = ""; string p = "";
            for (int i = 2; i <= n; i++)
            {
                p = p + " ";
            }
            if (!(n == 0))
            {
                Console.WriteLine(p + "*");
            }
            for (int i = 2; i <= j; i++)
            {
                s = s + "*";
                p = p.Remove(0, 1);
                Console.WriteLine(p + s + "*" + s);

            }
        }

        static void Main4(string[] args)
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
                Main3(j, n);
            }
            Console.ReadLine();
        }
    }
}
