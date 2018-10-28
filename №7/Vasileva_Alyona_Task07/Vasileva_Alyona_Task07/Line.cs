using System;

namespace Vasileva_Alyona_Task07
{
    public class Line : Figure
    {
        public double X1
        {
            get;
            private set;
        }
        public double Y1
        {
            get;
            private set;
        }
        public double X2
        {
            get;
            private set;
        }
        public double Y2
        {
            get;
            private set;
        }
        public double Length() => Math.Sqrt((X1-X2)* (X1 - X2) + (Y1 - Y2) * (Y1 - Y2));

        public Line(double x1, double y1, double x2, double y2)
        {
            X1 = x1;
            Y1 = y1;
            X1 = x2;
            Y1 = y2;
        }
        public virtual string Draw()
        {
            return "Нарисовал линию";
        }
        public override string ToString() => string.Format("Линия. Координаты начала: {0}, {1};  Координаты конца: {2}, {3}; Длина отрезка: {4}",
                 X1, Y1, X2, Y2, Length());
    }
}

