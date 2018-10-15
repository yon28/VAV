using System;
using Vasileva_Alyona_Task07;

namespace ConsoleApp2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Polymorphism.DemoMain();
            Console.ReadLine();
        }
    }

    public class Polymorphism
    {
        public static void DemoMain()
        {
            Figure[] fig = new Figure[10];
            Random randomGenerator = new Random();

            for (int i = 0; i < fig.Length; i++)
            {
                switch (randomGenerator.Next(6))
                {
                    case 0:
                        fig[i] = new Rectangle(10, 10);
                        break;
                    case 1:
                        fig[i] = new Round(10, 10, 1);
                        break;
                    case 2:
                        fig[i] = new Ring(10, 10, 5, 1);
                        break;
                    case 3:
                        fig[i] = new Triangle(10, 10, 6);
                        break;
                    case 4:
                        fig[i] = new Circle(10, 10, 1);
                        break;
                    case 5:
                        fig[i] = new Line(10, 10, 1,1);
                        break;
                }
            }

            for (int i = 0; i < fig.Length; i++)
            {
                string str;

                if (fig[i] is Rectangle)
                {
                    str = ((Rectangle)fig[i]).ToString();
                }
                else if (fig[i] is Triangle)
                {
                    str = ((Triangle)fig[i]).ToString();
                }
                else if (fig[i] is Ring)
                {
                    str = ((Ring)fig[i]).ToString();
                }
                else if (fig[i] is Round)
                {
                    str = ((Round)fig[i]).ToString();
                }
                else if (fig[i] is Circle)
                {
                    str = ((Circle)fig[i]).ToString();
                }
                else if (fig[i] is Line)
                {
                    str = ((Line)fig[i]).ToString();
                }
                else
                {
                    str = "";
                }

                Console.WriteLine(str);
            }

        }
    }
}

