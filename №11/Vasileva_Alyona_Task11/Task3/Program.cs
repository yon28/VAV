using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Task3

/*Переопределить метод GetHashCode класса TwoDPointWithHash (из демо) таким образом, 
 * чтобы точки с координатами (1,1) и (10,10) возвращали разный хеш код.*/
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<TwoDPointWithHash> arr = new List<TwoDPointWithHash>();
            for (int i = 0; i <= 100; i++)
            {
                for (int j = 0; j <=100; j++)
                {
                    arr.Add(new TwoDPointWithHash(i, j));
                    
                }
            }
            var distinct = arr.Distinct();
            foreach (var point in distinct)
            {
                Console.WriteLine($"Точка: {point}, хэш  {point.GetHashCode()}");
            }
            Console.ReadLine();
        }
    }

    class TwoDPointWithHash : TwoDPoint
    {
        public TwoDPointWithHash(int x, int y) : base(x, y)
        {
        }

        public override int GetHashCode()
        {
            int hashBase = 132;
            hashBase = (hashBase * 74) + x;
            hashBase = (hashBase * 74) + y;

            return hashBase;
        }
    }


}
