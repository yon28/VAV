using System;


namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            DynamicArray<int> array = new DynamicArray<int>();
            Random randomGenerator = new Random();
            Console.WriteLine("Сформирован произвольный массив");
            for (int i = 0; i < 3; i++)
            {
                array.Add(randomGenerator.Next(6000));
            }
            Write(array);
            Console.WriteLine("Capacity: " + array.Capacity + ", Length: " + array.Length  );
            array.Insert(randomGenerator.Next(6000), 3);
            array.Remove(randomGenerator.Next(2));
            Console.ReadLine();
        }

        public static void Write(DynamicArray<int> array)
        {
            foreach (var element in array)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine();
        }
    }
}
