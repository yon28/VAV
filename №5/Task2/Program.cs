using System;


namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Round round1 = new Round(2, 3, 1);
            Round round2 = new Round(3, 4, 1);
            Round sum = round1 + round2;
            Console.WriteLine("First round:  {0}", round1);
            Console.WriteLine("Second round: {0}", round2);
            Console.WriteLine("The sum of the two rounds: {0}", sum);
            Console.ReadLine();
        }
    }

    class Round
    {
        //Круг с указанными координатами центра, радиусом. 
        // радиус положительный
        public double x0, y0, radius;
        public Round(double x0, double y0, double radius)
        {
            this.x0 = x0;
            this.y0 = y0;
            this.radius = radius;
        }
        //Свойства, позволяющие узнать длину окружности и площадь круга.
        double circle()
        {
            return 2 * Math.PI * radius;
        }
        double Square()
        {
            return 3.14 * radius * radius;
        }
        public static Round operator + (Round c1, Round c2)
        {
            // корректно, если один круг не содержит другой
            double hypotenuse = Math.Sqrt((c1.x0 - c2.x0) * (c1.x0 - c2.x0) + (c1.y0 - c2.y0) * (c1.y0 - c2.y0));
            double x = Math.Abs(c1.x0 - c2.x0) + (c1.radius + c2.radius) * hypotenuse / Math.Abs(c1.x0 - c2.x0);
            double y = Math.Abs(c1.y0 - c2.y0) + (c1.radius + c2.radius) * hypotenuse / Math.Abs(c1.y0 - c2.y0);
            double r = (c1.radius + c2.radius + hypotenuse) / 2;
            return new Round(x, y, r);
        }
    }




}
