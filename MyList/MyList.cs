using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyList
{
    public class MyList<T>
    {
        private T[] myList;
        public T this[int i] { get { return myList[i]; } set { myList[i] = value; } }
        private int length;
        public int Length { get { return length; } set { length = value; } }

        public MyList()
        {
            myList = new T[0];
            length = 0;
        }
        public void Add(T item)
        {
            ExpandMyList(ref myList, length + 1);
            length += 1;
            myList[length - 1] = item;
        }
        private void ExpandMyList(ref T[] oldList, int newSize)
        {
            T[] newList = new T[newSize];
            for (int i = 0; i < newSize - 1; i++)
                newList[i] = oldList[i];
            oldList = newList;
        }
        public bool Remove()
        {
            if (length != 0)
            {
                ReduceMyList(ref myList, length - 1);
                length -= 1;
                return true;
            }
            return false;
        }
        private void ReduceMyList(ref T[] oldList, int newSize)
        {
            T[] newList = new T[newSize];
            for (int i = 0; i < newSize - 1; i++)
                newList[i] = oldList[i + 1];
            oldList = newList;
        }
        public int Count()
        {
            return length;
        }
    }
}

