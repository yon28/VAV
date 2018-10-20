using System;


namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            DynamicArray<int> array = new DynamicArray<int>();
            Random randomGenerator = new Random();
            for (int i = 0; i < 4; i++)
            {
                array.Add(randomGenerator.Next(6000));
            }
            Console.WriteLine("Сформирован произвольный массив:");
            Write(array);
            array.Insert(randomGenerator.Next(6000), 3);
            Console.WriteLine("Вставлен новый элемент на позицию с номером 3: ");
            Write(array);
            array.RemoveNumber(4);
            Console.WriteLine("Удалён элемент с позиции с номером 4: ");
            Write(array);
            array.Insert(6000, 1);
            Console.WriteLine("Вставлен новый элемент на позицию с номером 1: ");
            Write(array);
            array.Remove(6000);
            Console.WriteLine("Удалён элемент 6000: ");
            Write(array);
            Console.Read();
        }

        public static void Write<Type>(DynamicArray<Type> array) where Type : new()
        {
            foreach (var element in array)
            {
                Console.Write(element+ " ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
