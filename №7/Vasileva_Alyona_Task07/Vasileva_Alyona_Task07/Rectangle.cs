using System;


namespace Vasileva_Alyona_Task07
{
    public class Rectangle : Figure
    {
        protected double width, height;

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

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
        public double Width
        {
            get => width;
            private set
            {
                ValidateValue(value, out width);
            }
        }

        public double Height
        {
            get => height;
            private set
            {
                ValidateValue(value, out height);
            }
        }
        public double Length()
        {
            return (width + height)*2;
        }


        public double Area()
        {
            return width * height;
        }

        public virtual string Draw()
        {
            return "Нарисовал прямоугольник";
        }
        public override string ToString() => string.Format("Прямоугольник. Длина и ширина: {0}, {1}; периметр  {2}, площадь  {3}",
        Width, Height, Length(), Area());
    }
}
