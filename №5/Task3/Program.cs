﻿using System;


namespace Task3
{

    public class Triangle
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
        private bool ValidateTriangle(double a , double b, double c)
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
            Triangle triangle = new Triangle(3, 2, 4);
            Console.WriteLine("Дан треугольник с длинами сторон: " + triangle.A + ", " + triangle.B + ", " + triangle.C);
            Console.WriteLine("Периметр: " + triangle.getP());
            Console.WriteLine("Площадь: " + triangle.getS());
            Console.ReadLine();
        }
    }

}
