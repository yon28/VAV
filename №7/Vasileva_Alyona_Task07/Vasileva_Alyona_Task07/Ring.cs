using System;

namespace Vasileva_Alyona_Task07
{
    public class Ring : Figure
    {

        public int InnerR;

        public Ring()
        {
        }


     /*   public Ring(Round roundBig, Round roundSmall) //Агрегирование
        {
            if (Validate(roundBig.Radius, roundSmall.Radius))
            {
                X0 = roundBig.X0;
                Y0 = roundBig.Y0;
                RadiusBig = roundBig.Radius;
                RadiusSmall = roundSmall.Radius;
            }
        }*/

        public Ring(double x0, double y0, double radiusBig, double radiusSmall)
        {
            if (Validate(radiusBig, radiusSmall))
            {
                X0 = x0;
                Y0 = y0;
                RadiusBig = radiusBig;
                RadiusSmall = radiusSmall;
            }
            Round roundBig = new Round(X0,Y0, RadiusBig);
            Round roundSmall = new Round(X0, Y0, RadiusSmall);
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
        public double Length() => 2 * Math.PI * (RadiusBig + RadiusSmall);
        public double Area() => 3.14 * (RadiusBig - RadiusSmall) * (RadiusBig - RadiusSmall);
        public static string Draw()
        {
            return "Нарисовал кольцо";
        }
        public override string ToString()
       => string.Format("Кольцо. Координаты центра: {0} , {1};  Радиусы: {2} , {3}; Длина граничной линии: {4}; Площадь: {5}",
                 X0, Y0, RadiusBig, RadiusSmall, Length(), Area());
    }
}
