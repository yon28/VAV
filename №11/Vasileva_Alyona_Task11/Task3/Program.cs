using System;
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
            
            Console.Read();
        }
    }

    public class MyClass
    {
        public delegate void MyDelegate(string[] arr);
        public event MyDelegate SortingFinish;
        public void Method(object x)
        {

        }
    }
}


