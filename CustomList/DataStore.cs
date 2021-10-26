using System;
using System.Collections.Generic;
using System.Text;

namespace CustomList
{
    public class MyList<T>
    {
        private T[] arr;
        public int Count { get; set; }
        public MyList()
        {
            arr = new T[10];
        }

        public void Add(T obj)
        {
            if (Count % 10 == 0)
            {
                ArrayResize();
            }
            arr[Count] = obj;
            Count++;

        }
        private void ArrayResize()
        {
            Array.Resize(ref arr, arr.Length + 10);

        }

        public void Clear()
        {
            arr = new T[10];
            Count = 0;
        }

        public void AddRange(IEnumerable<T> list)
        {
            foreach (var item in list)
            {
                Add(item);
            }
        }

        public T Find(Predicate<T> func)
        {
            foreach (var item in arr)
            {
                if (func(item))
                {
                    return item;
                }
            }
            return default;
        }
        public bool Contains(T obj)
        {
            foreach (var item in arr)
            {
                if (Comparer<T>.Default.Compare(item, obj) == 0) ;
                {
                    return true;
                }
            }
            return false;
        }
        public T this[int index]
        {
            get
            {
                try
                {
                    return arr[index];
                }
                catch (Exception)
                {

                    return arr[0];
                }
            }
            set
            {
                try
                {
                    arr[index] = value;
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

    }    

}   
