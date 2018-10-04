using System;


namespace ConsoleApp3
{
    class Task1
    {
        static void Main1(string[] args)
        {
            int a;
            do
            {
                Console.WriteLine("Введи длину прямоугольника.");
                int.TryParse(Console.ReadLine(), out a);
            }
            while (!(a>0));
            int b;
            do
            {
                Console.WriteLine("Введи ширину прямоугольника.");
                int.TryParse(Console.ReadLine(), out b);
            }
            while (!(b > 0));

            Console.WriteLine("Площадь прямоугольника со сторонами " +a +" и "+ b + " равна " + a*b);
            Console.ReadLine();
          
        }
    }
}
