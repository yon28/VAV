using System;
using Task1;
using System.Threading;

namespace Task3
{
    /*Написать модуль сортировки, включающий в себя: 
•	Метод сортировки из задания 1; 
•	Метод, позволяющий запустить в сортировку в отдельном потоке выполнения; 
•	Событие, сигнализирующее о завершении сортировки. 
    Продемонстрировать работу модуля в многопоточном режиме.
*/
    public class Program
    {
        static void Main(string[] args)
        {
            string[] arr = MyArray.Create();
            Console.WriteLine("Сформирован массив: ");
            MyArray.Write(arr);
            SortingModule sortingModule = new SortingModule();
            sortingModule.CreateThread(arr);

            string[] arr1 = MyArray.Create();
            Console.WriteLine("Сформирован массив: ");
            MyArray.Write(arr1);
            Console.WriteLine("Отсортированные массивы: ");
            SortingModule sortingModule1 = new SortingModule();
            sortingModule1.CreateThread(arr1);
            Console.Read();
        }
    }

    public class SortingModule
    {
        public delegate void Event(string[] arr);
        public event Event SortingFinish;

        public void Sort(string[] arr)
        {
            var my = new MyArray();
            MyArray.SortMin(arr, my.compare);
            SortingFinish?.Invoke(arr);
        }
        public void CreateThread(string[] arr)
        {
            SortingFinish += MyArray.Write;
            Thread th = new Thread(() => Sort(arr));
            th.Start();
        }
      }
}


