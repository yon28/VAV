using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("В процессе разработки");
            /*Разработать консольное приложение, которое выводит на экран(в виде таблицы) отличия в параметрах языковых культур:
                "ru"  vs "en"
                "en"  vs "invariant"
                "ru"  vs "invariant"
            Необходимо вывести на экране отличия в:
              1) формат отображения даты и времени
              2) формат отображения числовых данных(разделитель дробной и целой части, разделитель групп разрядов и т.п.)

            Целесообразно реализовать отдельный метод, который принимает на входе название культур и выводит отличия на экран.
            Повторно использовать этот метод(Code Reuse) для вывода различных пар культур.
            */

            // CultureInfo
            // CultureInfo("en-GB")
            // CultureInfo.InstalledUICulture
            //DateTime.Parse
            //CultureInfo.InvariantCulture
            Console.ReadLine();
        }
    }
}
