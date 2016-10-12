using System;
using System.Collections;

namespace HelloWorld
{
    internal class MyArray<T> : IEnumerable, IEnumerator
    {
        private int ArraySize { get; set; } = 10; //by default 
        private int Count { get; set; } = 0;
        private T[] Array { get; set; }
        private int index = -1;

        public MyArray()
        {
            Array = new T[ArraySize];
            for (var i = 0; i < ArraySize; i++)
                Array[i] = default(T);
        }

        public MyArray(int arraySize)
        {
            Array = new T[arraySize];
            ArraySize = arraySize;
            for (var i = 0; i < ArraySize; i++)
                Array[i] = default(T);
        }

        public MyArray( T[] array)
        {
            Array = new T[array.Length];
            for (var i = 0; i < array.Length; i++)
                Array[i] = array[i];
            ArraySize = array.Length;
        }

        
        public int Length()
        {
            return Count;
        }
        
        public void AddElement(T elem)
        {
            if (Count >= ArraySize) Resize(ArraySize);
            Array[Count] = elem;
            Count++;
        }
        public T GetDeletedAtElem(int index)
        {
            if (index >= ArraySize)
                return default(T);
            T tmp = Array[index];
            Array[index] = default(T);
            return tmp;
        }
        public void DeleteElement(int index)
        {
            if (index >= ArraySize)
                return;
            Array[index] = default(T);
        }

        public T GetElement(int index)
        {
            try
            {
                return Array[index];
            }
            catch
            {
                Console.WriteLine("error! Index out of range");
                return default(T);
            }
        }

        public void AddElementTo(T elem, int index)
        {
            if (index >= ArraySize)
                Resize(index);
            Array[index] = elem;
        }

        
        public void DeleteAllElements()
        {
            Array = new T[ArraySize];
            Count = 0;
            ArraySize = 10;
        }


        
        private void Resize(int index)
        {
            var count = index - ArraySize + 1;
            var garbage = new T[count + ArraySize];
            for (var i = 0; i < Array.Length; i++)
                garbage[i] = Array[i];
            ArraySize += count;
            Array = garbage;
        }


        public IEnumerator GetEnumerator()
        {
            return this;
        }

        public bool MoveNext()
        {
            if (index == Array.Length - 1)
            {
                Reset();
                return false;
            }

            index++;
            return true;
        }

        public void Reset()
        {
            index= - 1;
        }

        public object Current => Array[index];
    }
}