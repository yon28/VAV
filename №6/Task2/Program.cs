using System;
using ClassLibrary1;

namespace Task2
{
    public class Round
    {
        public double X0
        {
            get;
            private set;
        }
        public double Y0
        {
            get;
            private set;
        }
        private double radius;
        public double Radius
        {
            get => radius;
            private set
            {
                if (value > 0)
                {
                    radius = value;
                }
                else
                {
                    throw new Exception("Неположительные значения недопустимы!");
                }
            }
        }
        // Свойства, позволяющие узнать длину окружности и площадь круга.
        public double Circle() => 2 * Math.PI * radius;
        public double Square() => 3.14 * radius * radius;
        // Круг с указанными координатами центра, радиусом. 
        public Round(double x0, double y0, double radius)
        {
            X0 = x0;
            Y0 = y0;
            Radius = radius;
        }
        public static string Draw()
        {
            return "Нарисовал круг";
        }
        public static Ring operator -(Round c1, Round c2)
        {
            if (c1.Radius - c2.Radius < 0)
            {
                throw new Exception("Радиус внешнего круга меньше радиуса внутреннего круга!");
            }
            return new Ring(c1, c2) { RadiusBig = c1.Radius, RadiusSmall = c2.Radius };
        }
        public override string ToString() => string.Format("Координаты центра: {0} , {1};  Радиус: {2} ; Длина окружности {3}; Площадь: {4}",
                 X0, Y0, Radius, Circle(), Square());
    }

    public class Ring
    {
        public Ring(Round roundBig, Round roundSmall) //Агрегирование
        {
            if (Validate(roundBig.Radius, roundSmall.Radius))
            {
                X0 = roundBig.X0;
                Y0 = roundBig.Y0;
                RadiusBig = roundBig.Radius;
                RadiusSmall = roundSmall.Radius;
            }
        }
        public double X0
        {
            get;
            private set;
        }
        public double Y0
        {
            get;
            private set;
        }
        public double RadiusBig
        {
            get;
            set;
        }
        public double RadiusSmall
        {
            get;
            set;
        }
        private bool Validate(double RadiusBig, double RadiusSmall)
        {
            if (RadiusBig > RadiusSmall)
            {
                return true;
            }
            else
            {
                throw new Exception("Радиус внешнего круга должен быть больше радиуса внутреннего круга!");
            }
        }
        public double Circle() => 2 * Math.PI * (RadiusBig + RadiusSmall);
        public double Square() => 3.14 * (RadiusBig - RadiusSmall) * (RadiusBig - RadiusSmall);
        public static string Draw()
        {
            return "Нарисовал кольцо";
        }
        public override string ToString()
       => string.Format("Координаты центра: {0} , {1};  Радиусы: {2} , {3}; Длина граничной линии: {4}; Площадь: {5}",
                 X0, Y0, RadiusBig, RadiusSmall, Circle(), Square());
    }

    class Program
    {
        public static void Main(string[] args)
        {
            Round roundBig = new Round(2, 3, 2);
            Round roundSmall = new Round(3, 4, 1);
            Ring ring = new Ring(roundBig, roundSmall);
            Console.WriteLine(Ring.Draw());
            Console.WriteLine(ring.ToString());
            Console.ReadLine();
            /*
            // перегрузка (др. кол-во параметров. через 
            // перекрытие  (new ставить)
            // virtual в базовом, overite в наследнике
            // $"{lastName} { firstName}"  склеивает
            */
        }

    }

}

