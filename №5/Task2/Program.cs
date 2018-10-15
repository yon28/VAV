using System;

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

    class Program
    {
        public static void Main(string[] args)
        {
            Round roundBig = new Round(2, 3, 1);
            Round round2 = new Round(3, 4, 2);
            Round sum = roundBig + round2;
            Console.WriteLine("Площадь первого круга: " + roundBig.Square());
            Console.WriteLine("Площадь второго  круг: " + round2.Square());            
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
