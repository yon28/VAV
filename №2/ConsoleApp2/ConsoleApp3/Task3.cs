using System;


namespace ConsoleApp3
{
    class Task3
    {
        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.WriteLine("Введи натуральное число, пожалуйста!");
            }
            while (!(int.TryParse(Console.ReadLine(), out n) & (n > 0)));
            Console.WriteLine("Вывод в форме равностороннего треугольника:");

           /* string s = ""; string p = "";
            for (int i = 2; i <= n; i++)
            {
                p = p + " ";
            }
            if (!(n == 0))
            {
                Console.WriteLine(p + "*");
            }
            for (int i = 2; i <= n; i++)
            {
                s = s + "*";
                p = p.Remove(0, 1);
                Console.WriteLine(p + s + "*" + s);
            }*/

            // todo test it
            var s1 = "*";
            for (int i = 1; i <= n; i++)
            {
                var s = new string(' ', n - i) + s1;
                Console.WriteLine(s);
                s1 += "**";
            }
            
            Console.ReadLine();
        }
    }
}
