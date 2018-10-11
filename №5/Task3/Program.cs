using System;


namespace Task3
{

    public class Triangle
    {
        public double a, b, c;
        double P, S;

        public double A
        {
            get => a;
            private set
            {
                if (value > 0)        
                {
                    a = value;
                }
                else
                {
                    throw new Exception("Неположительные значения недопустимы!");
                }
            }
        }

        public double B
        {
            get => b;
            private set
            {
                if (value > 0)
                {
                    b = value;
                }
                else
                {
                    throw new Exception("Неположительные значения недопустимы!");
                }
            }
        }

        public double C
        {
            get => c;
            private set
            {
                if ((value > 0) & (a + b > c) & (b + c > a) & (a + c > b)) 
                {
                    c = value;
                }
                else
                {
                    throw new Exception("Неположительные значения недопустимы! Сумма длин двух сторон треугольника всегда превышает длину третьей стороны! ");
                }
            }
        }

        public Triangle(int a, int b, int c)
        {
            A = a;
            B = b;
            C = c;
        }

        public double getP()
        {
            P = A + B + C;
            return P;
        }
        public double getS()
        {
            double p;
            p = P / 2;
            S = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            return S;
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            Triangle triangle = new Triangle(0, 2, 4);
            Console.WriteLine("Дан треугольник с длинами сторон: " + triangle.A + ", " + triangle.B + ", " + triangle.C);
            Console.WriteLine("Периметр: " + triangle.getP());
            Console.WriteLine("Площадь: " + triangle.getS());
            Console.ReadLine();
        }
    }

}
