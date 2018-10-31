using System;
using ClassLibrary1;
namespace Task1
{
    public class Task_1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            int a = 5;
            int n = 2;
            Console.WriteLine($"{a}! = {a.Factorial()}");
            Console.WriteLine($"{a}^{n} = {a.Power(n)}");
            Console.Read();
        }
    }
}
