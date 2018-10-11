using System;

namespace ClassLibrary1
{
    class Ring 
    {

        private double x, y, x0, y0,  radiusBig, radiusSmall, circle1, circle2;

        public Ring(Round round1, Round round2) //Агрегирование
        {
            x0 = round1.X0;
            x = round2.X0;
            y0 = round1.Y0;
            y = round2.Y0;
            radiusBig = round1.Radius;
            radiusSmall = round2.Radius;
            circle1 = round1.Circle();
            circle2 = round2.Circle();
        }

        public double X0
        {
            get => x0;
            private set
            {
                if (value != x)
                {
                    x0 = value;
                }
                else
                {
                    throw new Exception("Центр внешнего круга должен совпадать с центром внутреннего круга!");
                }
            }
        }

        public double Y0
        {
            get => y0;
            private set
            {
                if (value != y)
                {
                    y0 = value;
                }
                else
                {
                    throw new Exception("Центр внешнего круга должен совпадать с центром внутреннего круга!");
                }
            }
        }

        public double RadiusSmall
        {
            get;
            private set;
        }

        public double RadiusBig
        {
            get => radiusBig;
            private set
            {
                if (value > RadiusSmall)
                {
                    radiusBig = value;
                }
                else
                {
                    throw new Exception("Радиус внешнего круга должен быть больше, чем радиус внутреннего круга!");
                }
            }
        }


        public double Circle() => circle1 + circle2;
        public double Square() => 3.14 * (RadiusBig - RadiusSmall) * (RadiusBig - RadiusSmall);

    }

    class Round
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

        public static Round operator +(Round c1, Round c2)
        {
            // если один круг не содержит другой
            double hypotenuse = Math.Sqrt((c1.X0 - c2.X0) * (c1.X0 - c2.X0) + (c1.Y0 - c2.Y0) * (c1.Y0 - c2.Y0));
            double x = Math.Abs(c1.X0 - c2.X0) + (c1.radius + c2.radius) * hypotenuse / Math.Abs(c1.X0 - c2.X0);
            double y = Math.Abs(c1.Y0 - c2.Y0) + (c1.radius + c2.radius) * hypotenuse / Math.Abs(c1.Y0 - c2.Y0);
            double r = (c1.radius + c2.radius + hypotenuse) / 2;
            return new Round(x, y, r);
        }
    }
}
