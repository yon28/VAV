using System;
using System.Collections;
using System.Collections.Generic;


namespace Task1
{
    public class DynamicArray<Arr> : IEnumerable<Arr> where Arr : new()  //Представляет собой массив с запасом
    {
        Arr[] arr;

        public DynamicArray() //Конструктор без параметров,создается массив емкостью 8 элементов.  
        {
            arr = new Arr[8];
            Length = 0;
        }
        public DynamicArray(int num) // Конструктор с 1 целочисленным параметром, создается массив заданной емкости.  
        {
            arr = new Arr[num];
            Length = 0;
        }
        public DynamicArray(Arr[] arr)//Конструктор, который в качестве параметра принимает массив
        {
            this.arr = new Arr[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                this.arr[i] = arr[i];
            }
        }
        int length; //Length – получение длины заполненной части массива
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
        public void Add(Arr newElement)// Метод, добавляющий в конец массива один элемент.                           
        {
            if (Length < arr.Length)
            {
                arr[Length] = newElement;
            }
            else  //При нехватке места для добавления элемента емкость массива должна расширяться в 2 раза.
            {
                Arr[] temp = new Arr[Length];
                arr.CopyTo(temp, 0);
                arr = new Arr[arr.Length * 2];
                temp.CopyTo(arr, 0);
                arr[temp.Length] = newElement;
            }
            Length++;
        }

        public void AddRange(Arr[] elements) //Метод, добавляющий в конец массива содержимое переданного массива
        {
            if (elements.Length > (Capacity - Length))
            {
                Arr[] temp = new Arr[Length];
                arr.CopyTo(temp, 0);
                arr = new Arr[Length + elements.Length];
                temp.CopyTo(arr, 0);
                elements.CopyTo(arr, Length);
            }
            else
            {
                elements.CopyTo(arr, Length);
            }

            Length = elements.Length + Length;
        }

        public int Capacity //Capacity – получение реальной ёмкости массива
        {
            get => arr.Length;
        }
        public Arr this[int i]   //При необходимости расширения массива делать это только один раз вне зависимости от числа элементов в добавляемой коллекции
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

        public bool Remove(int number) //Метод, удаляющий из коллекции указанный элемент.
        {
            if (number < Length)
            {
                Array.Copy(arr, number + 1, arr, number, Length - number);
                arr[Length] = default(Arr);
                Length--;
                return true;
            }
            else
            {
                return false; //Метод должен возвращать true, если удаление прошло успешно и false в противном случае.
            }
        }
        public void Insert(Arr element, int number) //Метод Insert, позволяющий добавить элемент в произвольную позицию массива 
        {
            if (number > Length)
            {
                throw new ArgumentOutOfRangeException("Выход за границы массива");
            }
            Arr[] temp = new Arr[Capacity];
            if (Length < Capacity)
            {
                Array.Copy(arr, number, arr, number + 1, Length - number);
                arr[number] = element;
                Length++;
            }
            else
            {
                arr.CopyTo(temp, 0);
                arr = new Arr[Capacity + 1];
                Array.Copy(temp, 0, arr, 0, number);
                Array.Copy(temp, number, arr, number + 1, Length - number);
                arr[number] = element;
                Length++;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()=> GetEnumerator(); //Индексатор, позволяющий работать с элементом с указанным номером
        public IEnumerator<Arr> GetEnumerator()=>new DynamicArrayEnum<Arr>(arr, Length);

    }
}
