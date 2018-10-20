using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class MyLinkedList
    {
            public static void GenerateList(LinkedList<string> link)
            {
                // Добавим несколько элементов
                link.AddLast("1. Алексей");
                link.AddLast("2. Борис");
                link.AddLast("3. Виктор");
                link.AddLast("4. Григорий");
                link.AddLast("5. Денис");
                link.AddLast("6. Егор");
                link.AddLast("7. Жора");
                link.AddLast("8. Зинаида");
                link.AddLast("9. Игорь");
                link.AddLast("10. Константин");
                link.AddLast("11. Леонид");
                link.AddLast("12. Мария");
                link.AddLast("13. Наталья");
                link.AddLast("14. Олег");
        }
       

        public static void Write(LinkedList<string> link)
        {
            Console.WriteLine("В кругу: ");
            foreach (var i in link)
            {
                Console.Write(i + "  ");
            }
            Console.WriteLine();
            Console.WriteLine();

        }
      /*  public static void WriteDown(LinkedList<string> link)
        {
            Console.WriteLine("Элементы коллекции в обратном направлении: ");
            LinkedListNode<string> node;
            for (node = link.Last; node != null; node = node.Previous)
            {
                Console.Write(node.Value + "  ");
            }
            Console.WriteLine();
            Console.ReadLine();
        }*/

        //> При использовании LinkedList<T> не обращаться к элементам напрямую по индексу.

        
        public static void RemoveEachSecondItem(LinkedList<string> link)
        {
            LinkedListNode<string> node = link.First;
            while (link.Count != 1)
            {
                Console.Write(node.Value + "  ");
                node = node.Next; 
                if (node == null)
                {
                    node = link.First;
                    Console.WriteLine();
                }
                if (node.Next != null)
                {
                    node = node.Next;
                    link.Remove(node.Previous);
                }
                else
                {
                    link.Remove(node);
                    node = link.First;
                    Console.WriteLine();
                }
            }
            Console.Write(node.Value + "  ");
        }
    }
}
