using System;
using System.Collections;
using System.Collections.Generic;


namespace Task1 //Обобщения
{
    public class DynamicArray<Type> : IEnumerable<Type> where Type : new()  //Ограничение с конструктором
    {
        Type[] arr;

        public DynamicArray()
        {
            arr = new Type[8];
            Length = 0;
        }
        public DynamicArray(int count)
        {
            arr = new Type[count];
            Length = 0;
        }
        public DynamicArray(Type[] arr)
        {
            this.arr = new Type[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                this.arr[i] = arr[i];
            }
        }

        int length;
        public int Length
        {
            get => length;
            private set
            {
                if (value >= 0)
                {
                    length = value;
                }
                else
                {
                    throw new Exception("Неположительные значения недопустимы!");
                }
            }
        }

        public void AddRange(Type[] elements) // добавляющий содержимое переданного массива
        {
            if (elements.Length > (Capacity - Length))
            {
                Expand(elements.Length);
                elements.CopyTo(arr, Length);
            }
            else
            {
                elements.CopyTo(arr, Length);
            }

            Length = elements.Length + Length;
        }

        public int Capacity // реальная ёмкость массива
        {
            get => arr.Length;
        }

        public Type this[int i]   //Индексатор
        {
            get => arr[i];
            set
            {
                if (i > Capacity)
                {
                    throw new ArgumentOutOfRangeException("Выход за границы массива");
                }
                arr[i] = value;
            }
        }

        public bool RemoveNumber(int number) 
        {
            if (number <= Length)
            {
                Array.Copy(arr, number + 1, arr, number, Length - number);
                arr[Length] = default(Type);
                Length--;
                return true;// если удаление прошло успешно
            }
            else
            {
                return false;
            }
        }

        public bool Remove(Type element) //удаляет последний элемент, равный заданному 
        {
            int number=-1;
            for (int i = 0; i <= Length; i++)
            {
                if (arr[i].Equals(element))
                {
                    number = i;
                }
            }
            if (number !=-1)
            {
                return RemoveNumber(number);
            }
            else
            {
                return false;
            }
        }

        public void Insert(Type element, int number) //добавить элемент в указанную позицию
        {
            if (number > Length)
            {
                throw new ArgumentOutOfRangeException("Выход за границы массива");
            }
            else
            {
                if (Length == Capacity)
                {
                    Expand(1);
                }
                Array.Copy(arr, number, arr, number + 1, Length - number);
                arr[number] = element;
                Length++;
            }
        }

        public void Expand( int elementsLength)
        {
            Type[] temp = new Type[Length];
            arr.CopyTo(temp, 0);
            arr = new Type[Length + elementsLength]; //+++
            temp.CopyTo(arr, 0);
        }

        public void Add(Type newElement)
        {
            Insert(newElement, Length);
        }
        //Получаем перечислитель, устанавливаемый в начало коллекции
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator(); 
        public IEnumerator<Type> GetEnumerator() => new DynamicArrayEnum<Type>(arr, Length);

    }
}
