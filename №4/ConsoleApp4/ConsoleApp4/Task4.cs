using System;
using System.Text;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сравнительный анализ скорости работы String и StringBuilder для сложения. ");

            Console.WriteLine("Работа String:");
            TimeSpan time1 = Calculate(true);

            Console.WriteLine("Работа  StringBuilder:");
            TimeSpan time2 = Calculate(false);
            if (time2 > time1)
            {
                Console.WriteLine("StringBuilder  работает дольше");
            }
            else
            {
                Console.WriteLine("String работает дольше");
            }
            Console.WriteLine("Сравнительный анализ проведен. ");
            Console.ReadLine();
        }

        static TimeSpan Calculate(bool b)
        {
            string str = "";
            StringBuilder sb = new StringBuilder();
            int N = 100;
            DateTime beforetime = DateTime.Now;
            for (int i = 0; i < N; i++)
            {
                if (b)
                {
                    str += "*";
                }
                else
                {
                    sb.Append("*");
                }
            }
            DateTime aftertime = DateTime.Now;
            TimeSpan time = aftertime - beforetime;
            Console.Write(time.TotalMilliseconds + " ms.");
            Console.WriteLine();
            return time;
        }



    }
}
