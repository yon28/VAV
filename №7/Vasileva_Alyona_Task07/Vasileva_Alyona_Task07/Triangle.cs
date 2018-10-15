using System;


namespace Vasileva_Alyona_Task07
{
    public class Triangle : Figure
    {
        private double a, b, c;
        double P, S;

        bool ValidateValue(double value, out double b)
        {
            if (value > 0)
            {
                b = value;
                return true;
            }
            else
            {
                throw new Exception("Неположительные значения недопустимы!");
            }
        }
        public double A
        {
            get => a;
            private set
            {
                ValidateValue(value, out a);
            }
        }

        public double B
        {
            get => b;
            private set
            {
                ValidateValue(value, out b);
            }
        }

        public double C
        {
            get => c;
            private set
            {
                ValidateValue(value, out c);
            }
        }
        //Сумма длин двух сторон треугольника всегда превышает длину третьей стороны! 
        private bool ValidateTriangle(double a, double b, double c)
        {
            if ((a + b > c) & (b + c > a) & (a + c > b))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Triangle(int a, int b, int c)
        {
            if (ValidateTriangle(a, b, c))
            {
                A = a;
                B = b;
                C = c;
            }
            else
            {
                throw new Exception("В треугольнике сумма длин двух сторон всегда превышает длину третьей стороны!");
            }
        }
        public double Length()
        {
            P = A + B + C;
            return P;
        }
        public double Area()
        {
            double p;
            p = P / 2;
            S = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            return S;
        }
        public virtual string Draw()
        {
            return "Нарисовал треугольник";
        }
        public override string ToString() => string.Format("Треугольник. Длины сторон: {0}, {1}, {2}; периметр  {3}, площадь  {4}",
                A , B, C, Length(), Area());
    }
}
