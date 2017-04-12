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
        private Int32 maxArrSize;
        private Int32 nextInsert;

        public MyList()
        {
            myList = new T[10];
            maxArrSize = myList.Length;
            nextInsert = 0;

        }
        public void Add(T item)
        {          
            if (nextInsert == maxArrSize)
            {
                ExpandMyList();
            }
                myList[nextInsert] = item;
                nextInsert += 1;
        }
        private void ExpandMyList()
        {
            Array.Resize(ref this.myList, this.myList.Length + 10);
            maxArrSize = myList.Length;
        }
    }
}

