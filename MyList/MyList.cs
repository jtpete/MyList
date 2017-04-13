﻿using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyList
{
    public class MyList<T> : IEnumerable<T>
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
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < myList.Length; i++)
            {
                yield return myList[i];
            }
        }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
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
        public static MyList<T> operator +(MyList<T> list1, MyList<T> list2)
        {
            MyList<T> newList = new MyList<T>();

            if (list1.length != 0)
            {
                for (int i = 0; i < list1.length; i++)
                    newList.Add(list1[i]);
            }
            if (list2.length != 0)
            {
                for (int i = 0; i < list2.length; i++)
                    newList.Add(list2[i]);
            }
            return newList;
        }
        public static MyList<T> operator -(MyList<T> list1, MyList<T> list2)
        {
            MyList<T> newList = new MyList<T>();
            MyList<T> removeValues = new MyList<T>();

            if (list2.length != 0)
            {
                if (list1.length != 0)
                {
                    for (int i = 0; i < list2.length; i++)
                    {
                        for (int j = 0; j < list1.length; j++)
                        {
                            if (list2[i].Equals(list1[j]))
                            {
                                removeValues.Add(list2[i]);
                                j = list1.length;
                            }
                        }
                    }
                }
            }
            if (list1.length != 0 && removeValues.length != 0)
            {
                for (int i = 0; i < list1.length; i++)
                {
                    bool addThis = true;
                    for (int j = 0; j < removeValues.length; j++)
                    {
                        if (list1[i].Equals(removeValues[j]))
                        {
                            addThis = false;
                            j = removeValues.length;
                        }
                    }
                    if (addThis)
                        newList.Add(list1[i]);
                }
            }
            else if (list1.length != 0 && removeValues.length == 0)
            {
                for (int i = 0; i < list1.length; i++)
                    newList.Add(list1[i]);
            }

            return newList;
        }
        public override string ToString()
        {
            string listString = "";
            if (myList.Length != 0)
                for (int i = 0; i < myList.Length; i++)
                    listString = TakeValuesToString();

            return listString;
        }
        private string TakeValuesToString()
        {
            string myString = "";
            for (int i = 0; i < myList.Length; i++)
            {
                myString += myList[i];
            }
            return myString;
        }
        public MyList<T> Zip(MyList<T> zipList)
        {
            MyList<T> newList = new MyList<T>();

            if (myList.Length != 0 && !zipList.Equals(0))
            {
                if (myList.Length >= zipList.Length)
                {
                    for (int i = 0; i < myList.Length; i++)
                    {
                        newList.Add(myList[i]);
                        if (i < zipList.Length)
                            newList.Add(zipList[i]);
                    }
                }
                else
                {
                    for (int i = 0; i < zipList.Length; i++)
                    {
                        if (i < myList.Length)
                            newList.Add(myList[i]);
                        newList.Add(zipList[i]);
                    }
                }
            }
            else if (myList.Length != 0 && zipList.Equals(0))
            {
                for (int i = 0; i < myList.Length; i++)
                    newList.Add(myList[i]);
            }
            else if (myList.Length == 0 && !zipList.Equals(0))
            {
                for (int i = 0; i < zipList.Length; i++)
                    newList.Add(zipList[i]);
            }
            return newList;

        }
        public void Sort()
        {
            T temp;

            if (myList.Length > 1)
            {
                for(int i = 0; i < myList.Length; i++)
                {
                    for(int j = 0; j < myList.Length-1; j++)
                    {
                        if (Comparer<T>.Default.Compare(myList[j], myList[j+1]) >= 0) 
                        {
                            temp = myList[j + 1];
                            myList[j + 1] = myList[j];
                            myList[j] = temp;
                        }
                    }
                }
            }
        }
    }
}

