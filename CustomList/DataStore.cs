using System;
using System.Collections.Generic;
using System.Text;

namespace CustomList
{
    class MyList<T>
    {
        private T[] arr;

        public MyList()
        {
            arr = new T[0];
        }

        public void Add(T num)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = num;
        }

        //public void AddRange(IEnumerable<T> collection)
        //{

        //}

        public void GetAll()
        {
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }

        //Indexer

        //    private T[] store;
        //    public MyList()
        //    {
        //        store = new T[5];
        //    }

        //    public MyList(int length)
        //    {
        //        store = new T[length];
        //    }

        //    public T this[int index]
        //    {
        //        get
        //        {
        //            try
        //            {
        //                return store[index];
        //            }
        //            catch (Exception)
        //            {

        //                return store[0];
        //            }
        //        }
        //        set
        //        {
        //            try
        //            {
        //                store[index] = value;
        //            }
        //            catch (Exception)
        //            {

        //                Console.WriteLine("Out of range");
        //            }
        //        }
        //    }

        //    public int Length
        //    {
        //        get
        //        {
        //            return store.Length;
        //        }
        //    }
    }


}   
