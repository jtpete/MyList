using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyList
{
    public class MyList<T>
    {
        private T[] myList = new T[10];
        public T this[int i] { get { return myList[i]; } set { myList[i] = value; } }

        public void
    }
}
