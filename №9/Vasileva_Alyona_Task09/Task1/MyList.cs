using System;
using System.Collections;
using System.Collections.Generic;


namespace Task1 
{
    public class MyList
    {
        public static void GenerateList(List<string> list)
        {
            // Добавим несколько элементов
            list.Add("1. Алексей");
            list.Add("2. Борис");
            list.Add("3. Виктор");
            list.Add("4. Григорий");
            list.Add("5. Денис");
            list.Add("6. Егор");
            list.Add("7. Жора");
            list.Add("8. Зинаида");
            list.Add("9. Игорь");
            list.Add("10. Константин");
            list.Add("11. Леонид");
            list.Add("12. Мария");
            list.Add("13. Наталья");
            list.Add("14.Олег");
        }

        public static void Write(List<string> list)
        {
            foreach (var i in list)
            {
                Console.Write(i + "  ");
            }
            Console.WriteLine();
        }
        public static void RemoveEachSecondItem(List<string> link)

        {
            bool b = false;
            while (link.Count != 1)
            {
                for (int i = 0; i < link.Count; i++)
                {
                    if (b) link.RemoveAt(i--);
                    b = !b;
                }
               Write(link);
            }

        }

    }
}
