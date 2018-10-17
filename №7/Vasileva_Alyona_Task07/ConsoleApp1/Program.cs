using System;
using Vasileva_Alyona_Task07;

namespace ConsoleApp2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Figure[] fig = Generate();
            Write(fig);
        }

        public static Figure[] Generate()
        {
            Figure[] fig = new Figure[10];
            Random randomGenerator = new Random();

            for (int i = 0; i < fig.Length; i++)
            {
                switch (randomGenerator.Next(6))
                {
                    case 0:
                        fig[i] = new Rectangle(randomGenerator.Next(6)+1, randomGenerator.Next(6)+1);
                        break;
                    case 1:
                        fig[i] = new Round(randomGenerator.Next(6), randomGenerator.Next(6), randomGenerator.Next(6)+1);
                        break;
                    case 2:
                        fig[i] = new Ring(randomGenerator.Next(6), randomGenerator.Next(6), randomGenerator.Next(6)*7+1, randomGenerator.Next(2)+1);
                        break;
                    case 3:
                        int side = randomGenerator.Next(6);
                        fig[i] = new Triangle(side, side, randomGenerator.Next(2));
                        break;
                    case 4:
                        fig[i] = new Circle(randomGenerator.Next(6), randomGenerator.Next(6), randomGenerator.Next(6)+1);
                        break;
                    case 5:
                        fig[i] = new Line(randomGenerator.Next(6), randomGenerator.Next(6), randomGenerator.Next(6), randomGenerator.Next(6));
                        break;
                }
            }
            return fig;

        }
        public static void Write(Figure[] fig)
        {
            Canvas canvas = new Canvas();
            for (int i = 0; i < fig.Length; i++)
            {
                /*fig[i].Draw();
                string str = fig[i].ToString();
                Console.WriteLine(str);*/

                canvas.ConsolePrint(fig[i]);
            }
            Console.ReadLine();
        }
    }
}

