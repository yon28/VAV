using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public static class Class1
    {
        //Реализовать библиотеку, содержащую математические функции: факториал и возведение в степень. 
        //Библиотека должна создаваться в отдельном проекте с типом «Class Library».
        public static int Factorial(this int n)
        {
            if (n <= 1)
            {
                return n;
            }
            else
            {
                return n * Factorial(n - 1);
            }
        }
        public static int Power(this int a, int n)
        {
            int power = 1;
            for (int i = 1; i <= n; i++)
            {
                power = power*a;
            }
            return power;
        }
    }
}
