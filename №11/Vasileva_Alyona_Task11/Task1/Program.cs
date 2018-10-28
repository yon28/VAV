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
        
        /*Задание 2
        Модифицировать класс Employee (из первой темы по ООП) таким образом, чтобы он реализовывал интерфейс IEquatable<Employee>
        Задание 3
        Переопределить метод GetHashCode класса TwoDPointWithHash (из демо) таким образом,
        чтобы точки с координатами (1,1) и (10,10) возвращали разный хеш код.
        */
    }
}
