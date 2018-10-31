using System;

namespace Task1
{
    
    public class Task_1
    {
        static void Main(string[] args)
        {

            var my = new MyArray();
            string[] arr = MyArray.Create();
            Console.WriteLine("Сформирован массив строковых переменных: ");
            MyArray.Write(arr);
            MyArray.SortMin( arr,my.compare);
            Console.WriteLine("Отсортированный массив строковых переменных: ");
            MyArray.Write(arr);
            Console.Read();
        }

       
    }
}
