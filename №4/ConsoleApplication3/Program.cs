using System;
using System.Globalization;
using System.Threading;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Отличия в параметрах языковых культур:");
            CultureInfo ci1 = new CultureInfo("ru");
            CultureInfo ci = new CultureInfo("en");
            CultureInfo ci2 = CultureInfo.InvariantCulture;
           // CultureInfo ci3 = CultureInfo.InstalledUICulture;
            Write(ci1);
            Write(ci);
            Console.Write("invariant");
            Write(ci2);
            //  Write(ci3);
            Console.ReadLine();
        }

        static void Write(CultureInfo ci)
        {
            Thread.CurrentThread.CurrentCulture = ci;
            Console.WriteLine(ci.ToString() + ": ");
            Console.WriteLine("Форматы отображения даты и времени");
            DateTime now = DateTime.Now;  //DateTime.Today;
            Console.WriteLine(now.ToString());
            string[] array = { "D", "d","F","f","G", "g", "M", "O", "R", "s", "T", "t", "U", "u", "Y"};
            foreach (string format in array)
            {
                {
                    Console.WriteLine(format + ": " + now.ToString(format)); 
                    // Console.WriteLine("U: {0:U}", now);
                }
            }
            Console.WriteLine();
            Console.WriteLine("Форматы отображения числовых данных: разделитель групп разрядов");
            int a = 1234567890;
            Console.WriteLine(a.ToString("N"));
            Console.WriteLine(a.ToString("####.###"));
            Console.WriteLine();
            Console.WriteLine("Форматы отображения числовых данных: разделитель дробной и целой части ");
            double n = 9876543.21;
            Console.WriteLine(n.ToString("N", ci));
            Console.WriteLine();
            //CultureInfo.InvariantCulture
            // CultureInfo.InstalledUICulture
            // "C3" - три символа после запятой
            // после CultureInfo точку и смотреть 
            //DateTime.Parse
        }
    }
}
