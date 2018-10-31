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
            TwoDPointWithHash point1 = new TwoDPointWithHash(1, 1);
            TwoDPointWithHash point2 = new TwoDPointWithHash(10, 10);
            var twoDPointList = new List<TwoDPointWithHash> { point1, point2 };
            var distinct = twoDPointList.Distinct();
            foreach (var point in distinct)
            {
                Console.WriteLine("Уникальная точка: {0}", point);
            }
            Console.WriteLine("Хэш первой точки: {0}\nХэш второй точки: {1}", point1.GetHashCode(), point2.GetHashCode());

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
            unchecked
            {
                Random rand = new Random();
                int hash1 = 5381;
                int hash2 = hash1;
                string str = (x + y + x * y + rand.Next(-3000, 3000)).ToString();
                for (int i = 0; i < str.Length && str[i] != '\0'; i += 2)
                {
                    hash1 = ((hash1 << 5) + hash1) ^ str[i];
                    if (i == str.Length - 1 || str[i + 1] == '\0')
                        break;
                    hash2 = ((hash2 << 5) + hash2) ^ str[i + 1];
                }
                return Math.Abs(hash1 + (hash2 * 1566083941));
            }
        }
    }


}
