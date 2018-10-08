using System;


namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle(7, 8, 4);
            Console.WriteLine("Дан треугольник с длинами сторон: " + triangle.a + ", " + triangle.b + ", " + triangle.c);
            Console.WriteLine("Периметр: " + triangle.getP());
            Console.WriteLine("Площадь: " + triangle.getS());
            Console.ReadLine();
        }
    }

    public class Triangle
    {
        public int a,b,c; 
        double P, S; 
        // числа положительные, сумма двух превышает третью
        public Triangle(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double getP()
        {
            P = a + b + c;
            return P;
        }
        public double getS()
        {
            double p;
            p = P / 2;
            S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return S;
        }
    }
}
