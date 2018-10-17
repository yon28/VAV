using System;
using System.Collections;
using System.Collections.Generic;


namespace Task1
{
    public class DynamicArrayEnum<Arr> : IEnumerator<Arr> where Arr : new()
    {
        public Arr[] dynArr;
        int i = -1;
        int length;
        public DynamicArrayEnum(Arr[] arr, int length)
        {
            dynArr = arr;
            this.length = length;
        }

        object IEnumerator.Current
        {
            get => Current;
        }
        public Arr Current
        {
            get => dynArr[i]; 
        }

        public bool MoveNext()
        {
            i++;
            return (i < length);
        }

        public void Reset()
        {
            i = -1;
        }

        public void Dispose()
        {
            dynArr = null;
        }
    }
}
