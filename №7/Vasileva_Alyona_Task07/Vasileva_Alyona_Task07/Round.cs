using System;


namespace Vasileva_Alyona_Task07
{
    public class Round:Circle
    {
        public double Area() => 3.14 * Radius * Radius;
        
        public Round(double x0, double y0, double radius) : base(x0, y0, radius)
        {
        }
        public override string Draw()
        {
            return "Нарисовал круг";
        }
       
        public override string ToString() => string.Format("Круг. Координаты центра: {0} , {1};  Радиус: {2} ; Длина окружности {3}; Площадь: {4}",
                 X0, Y0, Radius, Length(), Area());
    }
}
