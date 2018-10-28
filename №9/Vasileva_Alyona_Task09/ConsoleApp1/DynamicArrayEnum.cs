using System;
using System.Collections;
using System.Collections.Generic;


namespace Task1
{
    public class DynamicArrayEnum<Arr> : IEnumerator<Arr> where Arr : new()
    {
        public Arr[] dynArr;
        int i = -1;
        // Реализуем интерфейс IEnumerable
        object IEnumerator.Current
        {
            get => Current;
        }
        // Реализуем интерфейс IEnumerator
        int length;
        public DynamicArrayEnum(Arr[] arr, int length)
        {
            dynArr = arr;
            this.length = length;
        }
        public bool MoveNext()
        {
            if (i == dynArr.Length - 1)
            {
                Reset();
                return false;
            }
            i++;
            return (i < length);
        }

        public void Reset()
        {
            i = -1;
        }
        public Arr Current //получение текущего элемента
        {
            get => dynArr[i];
        }

        public void Dispose()
        {
            dynArr = null;
        }
    }
}
