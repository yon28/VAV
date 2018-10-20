using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*В кругу стоят N человек, пронумерованных от 1 до N. 
            При ведении счета по кругу вычеркивается каждый второй человек, пока не останется один. 
            */

            // Создадим список
            List<string> list = new List<string>();
            MyList.GenerateList(list);
            Console.WriteLine("В кругу: ");
            MyList.Write(list);
            Console.WriteLine();
            MyList.RemoveEachSecondItem(list);

            Console.WriteLine();
           Console.WriteLine("Вторым способом:");
            // Создадим связный список
            LinkedList<string> link = new LinkedList<string>();
            MyLinkedList.GenerateList(link);
            MyLinkedList.Write(link);
            MyLinkedList.RemoveEachSecondItem(link);
            Console.ReadLine();
            Console.ReadLine();
        }


    }

}
