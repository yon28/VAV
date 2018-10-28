using System;
using Task1;
using System.Threading;


namespace Task3
{
    /*Написать модуль сортировки, включающий в себя: 
•	Метод, позволяющий запустить в сортировку в отдельном потоке выполнения; 
•	Событие, сигнализирующее о завершении сортировки. 

Продемонстрировать работу модуля в многопоточном режиме.
*/
    public class Program
    {
        static void Main(string[] args)
        {
            string[] Arr = Task_1.Create();
            Console.WriteLine("Сформирован массив: ");
            Task_1.Write(Arr);
            //Task_1.Sorted(Arr);
            MyClass myClass = new MyClass();
            myClass.SortingFinish += Task_1.Write;
            Thread t1 = new Thread(new ParameterizedThreadStart(myClass.Method));
            t1.Start();
            Console.WriteLine("Отсортированный массив: ");
            Task_1.Write(Arr);
            Console.Read();
        }
    }

    public class MyClass
    {
        public delegate void MyDelegate(string[] arr);
        public event MyDelegate SortingFinish;
        public void Method(object x)
        {
            string[] arr = (string[])x;
            Task_1.Sorted(arr);
            SortingFinish?.Invoke(arr);
        }
    }
}


