using ClassLibrary1;
using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            Field field = new Field(10, 10);
            Obj[] objects = Generate();
            game.MakeMove(objects);
            Write(objects);
        }

        public static Obj[] Generate()
        {
            Obj[] objects = new Obj[10];
            Obj hero = new Hero();
            objects[0] = hero;

            Random randomGenerator = new Random();
            for (int i = 1; i < objects.Length; i++)
            {
                switch (randomGenerator.Next(6))
                {
                    case 0:
                        objects[i] = new Apple();
                        break;
                    case 1:
                        objects[i] = new Bear();
                        break;
                    case 2:
                        objects[i] = new Cherry();
                        break;
                    case 3:
                        objects[i] = new Stone();
                        break;
                    case 4:
                        objects[i] = new Wolf();
                        break;
                    case 5:
                        objects[i] = new Wood();
                        break;
                }
            }
            return objects;

        }



        public static void Write(Obj[] objects)
        {
            Canvas canvas = new Canvas();
            for (int i = 0; i < objects.Length; i++)
            {
                canvas.ConsolePrint(objects[i]);
                Console.ReadLine();
            }
        }
        /*1.	Игрок может передвигаться по прямоугольному полю размером Width на Height. 
    2.	На поле располагаются бонусы (яблоко, вишня и т.д.), которые игрок может подобрать для поднятия каких-либо характеристик.
    3.	За игроком охотятся монстры (волки, медведи, когти смерти и т.д.), которые могут передвигаться по карте по какому-либо алгоритму.
    4.	На поле располагаются препятствия разных типов (камни, деревья и т.д.), которые игрок и монстры должны обходить.
    Цель игры – собрать все бонусы и не быть «съеденным» монстрами.
    */
    }
}
