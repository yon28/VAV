using System;

namespace Vasileva_Alyona_Task07
{
    public class Circle : Figure
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

        public double Length() => 2 * Math.PI * radius;

        public Circle(double x0, double y0, double radius)
        {
            X0 = x0;
            Y0 = y0;
            Radius = radius;
        }
        public virtual string Draw()
        {
            return "Нарисовал окружность";
        }
        public override string ToString() => string.Format("Окружность. Координаты центра: {0} , {1};  Радиус: {2} ; Длина окружности {3}",
                 X0, Y0, Radius, Length());
    }
}

