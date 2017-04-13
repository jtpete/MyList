using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyList;

namespace MyListTest
{
    [TestClass]
    public class UnitTestMyList
    {
        // Testing Add Method
        [TestMethod]
        public void SuccessfulConstructor()
        {
            MyList<int> intList = new MyList<int>();
            int item = 0;

            Assert.AreEqual(item, intList.Length);
        }

        // Testing Add Method
        [TestMethod]
        public void SuccessfulSingleIntAdd()
        {
            MyList<int> intList = new MyList<int>();
            int item = 2;

            intList.Add(item);

            Assert.AreEqual(item, intList[0]);
        }
        [TestMethod]
        public void SuccessfulSingleStringAdd()
        {
            MyList<string> stringList = new MyList<string>();
            string item = "Hello World";

            stringList.Add(item);

            Assert.AreEqual(item, stringList[0]);
        }
        [TestMethod]
        public void SuccessfulSingleDateAdd()
        {
            MyList<DateTime> dateList = new MyList<DateTime>();
            DateTime today = DateTime.Now;

            dateList.Add(today);

            Assert.AreEqual(today, dateList[0]);
        }
        [TestMethod]
        public void SuccessfulSingleObjectAdd()
        {
            MyList<Person> objList = new MyList<Person>();
            Person jason = new Person("Jason", 40, "black");

            objList.Add(jason);

            Assert.AreEqual(jason, objList[0]);
        }
        [TestMethod]
        public void SuccessfulMultipleIntAdd()
        {
            MyList<int> intList = new MyList<int>();
            int[] item = new int[] { 1, 2, 3, 4, 5 };

            for (int i = 0; i < 5; i++)
            {
                intList.Add(item[i]);
            }

            for (int i = 0; i < item.Length; i++)
            {
                Assert.AreEqual(item[i], intList[i]);
            }
        }
        [TestMethod]
        public void SuccessfulMultipleStringAdd()
        {
            MyList<string> stringList = new MyList<string>();
            string[] item = new string[] { "Hello", "World", "Great", "Fun", "Test" };

            for (int i = 0; i < 5; i++)
            {
                stringList.Add(item[i]);
            }

            for (int i = 0; i < item.Length; i++)
            {
                Assert.AreEqual(item[i], stringList[i]);
            }
        }
        [TestMethod]
        public void SuccessfulMultipleObjAdd()
        {
            MyList<Person> objList = new MyList<Person>();
            Person person1 = new MyListTest.Person("Jason", 40, "Black");
            Person person2 = new MyListTest.Person("Michelle", 39, "Blond");
            Person person3 = new MyListTest.Person("Lucas", 12, "Brown");
            Person person4 = new MyListTest.Person("Carter", 10, "Black");
            Person person5 = new MyListTest.Person("Brook", 7, "Blond");
            Person[] item = new Person[] { person1, person2, person3, person4, person5 };

            for (int i = 0; i < 5; i++)
            {
                objList.Add(item[i]);
            }

            for (int i = 0; i < item.Length; i++)
            {
                Assert.AreEqual(item[i], objList[i]);
            }
        }
        [TestMethod]
        public void SuccessfulStressIntAdd()
        {
            MyList<int> intList = new MyList<int>();
            int[] item = new int[1000];
            for (int i = 0; i < item.Length; i++)
            {
                item[i] = i;
            }

            for (int i = 0; i < item.Length; i++)
            {
                intList.Add(item[i]);
            }

            for (int i = 0; i < item.Length; i++)
            {
                Assert.AreEqual(item[i], intList[i]);
            }
        }


        //Testing Remove Method
        [TestMethod]
        public void SuccessfulSingleIntRemove()
        {
            MyList<int> intList = new MyList<int>();
            int item = 1;
            intList.Add(item);
            intList.Add(2);
            intList.Add(3);
            intList.Add(4);
            intList.Add(5);

            bool result = intList.Remove();

            Assert.IsTrue(result);
        }
        [TestMethod]
        public void SuccessfulOnlyIntRemove()
        {
            MyList<int> intList = new MyList<int>();
            int item = 1;
            intList.Add(item);

            bool result = intList.Remove();

            Assert.IsTrue(result);
        }
        [TestMethod]
        public void SuccessfulSingleStringRemove()
        {
            MyList<string> stringList = new MyList<string>();
            string item = "Hello";
            stringList.Add(item);
            stringList.Add("World");
            stringList.Add("Fun");
            stringList.Add("Challenge");
            stringList.Add("Broken");

            bool result = stringList.Remove();

            Assert.IsTrue(result);
        }
        [TestMethod]
        public void SuccessfulOnlyStringRemove()
        {
            MyList<string> stringList = new MyList<string>();
            string item = "Hello";
            stringList.Add(item);

            bool result = stringList.Remove();

            Assert.IsTrue(result);
        }
        [TestMethod]
        public void SuccessfulSingleObjRemove()
        {
            MyList<Person> objList = new MyList<Person>();
            Person person1 = new MyListTest.Person("Jason", 40, "Black");
            Person person2 = new MyListTest.Person("Michelle", 39, "Blond");
            Person person3 = new MyListTest.Person("Lucas", 12, "Brown");
            Person person4 = new MyListTest.Person("Carter", 10, "Black");
            Person person5 = new MyListTest.Person("Brook", 7, "Blond");
            Person[] item = new Person[] { person1, person2, person3, person4, person5 };
            for (int i = 0; i < 5; i++)
            {
                objList.Add(item[i]);
            }

            bool result = objList.Remove();

            Assert.IsTrue(result);
        }
        [TestMethod]
        public void SuccessfulOnlyObjRemove()
        {
            MyList<Person> objList = new MyList<Person>();
            Person person1 = new MyListTest.Person("Jason", 40, "Black");
            objList.Add(person1);

            bool result = objList.Remove();

            Assert.IsTrue(result);
        }
        [TestMethod]
        public void SuccessfulShiftingIntRemove()
        {
            MyList<int> intList = new MyList<int>();
            int item = 2;
            intList.Add(1);
            intList.Add(item);
            intList.Add(3);
            intList.Add(4);
            intList.Add(5);

            bool result = intList.Remove();

            Assert.AreEqual(item, intList[0]);
        }
        [TestMethod]
        public void EmptyListIntRemove()
        {
            MyList<int> intList = new MyList<int>();


            bool result = intList.Remove();

            Assert.IsFalse(result);
        }
        [TestMethod]
        public void SuccessfulStressIntRemove()
        {
            MyList<int> intList = new MyList<int>();
            int[] item = new int[10000];
            for (int i = 0; i < item.Length; i++)
            {
                item[i] = i;
            }

            for (int i = 0; i < item.Length; i++)
            {
                intList.Add(item[i]);
            }

            bool result = intList.Remove();
            Assert.IsTrue(result);
        }


        //Testing ToString Method
        [TestMethod]
        public void SingleIntToString()
        {
            MyList<int> intList = new MyList<int>();
            int item = 1;
            intList.Add(item);

            string result = intList.ToString();

            Assert.AreEqual(item.ToString(), result);
        }
        [TestMethod]
        public void SingleDoubleToString()
        {
            MyList<double> doubleList = new MyList<double>();
            double item = 3.1415926;
            doubleList.Add(item);

            string result = doubleList.ToString();

            Assert.AreEqual(item.ToString(), result);
        }
        [TestMethod]
        public void SingleStringToString()
        {
            MyList<string> stringList = new MyList<string>();
            string item = "Jason";
            stringList.Add(item);

            string result = stringList.ToString();

            Assert.AreEqual(item, result);
        }
        [TestMethod]
        public void SingleDateTimeToString()
        {
            MyList<DateTime> dateTimeList = new MyList<DateTime>();
            DateTime today = DateTime.Today;
            dateTimeList.Add(today);

            string result = dateTimeList.ToString();

            Assert.AreEqual(today.ToString(), result);
        }
        [TestMethod]
        public void SingleObjToString()
        {
            MyList<Person> objList = new MyList<Person>();
            Person person = new Person("Jason", 40, "Black");
            objList.Add(person);

            string result = objList.ToString();

            Assert.AreEqual(person.ToString(), result);
        }
        [TestMethod]
        public void EmptyListIntToString()
        {
            string emptyString = "";
            MyList<int> intList = new MyList<int>();


            string result = intList.ToString();

            Assert.AreEqual(emptyString, result);

        }


        //Testing + operator
        [TestMethod]
        public void SuccessfulIntEqualSizeOpAdd()
        {
            int[] item = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            MyList<int> intList1 = new MyList<int>();
            intList1.Add(item[0]);
            intList1.Add(item[1]);
            intList1.Add(item[2]);
            intList1.Add(item[3]);
            intList1.Add(item[4]);

            MyList<int> intList2 = new MyList<int>();
            intList2.Add(item[5]);
            intList2.Add(item[6]);
            intList2.Add(item[7]);
            intList2.Add(item[8]);
            intList2.Add(item[9]);

            MyList<int> result = intList1 + intList2;
            for (int i = 0; i < item.Length; i++)
            {
                Assert.AreEqual(item[i], result[i]);
            }
        }
        [TestMethod]
        public void SuccessfulIntFirstLargerOpAdd()
        {
            int[] item = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };

            MyList<int> intList1 = new MyList<int>();
            intList1.Add(item[0]);
            intList1.Add(item[1]);
            intList1.Add(item[2]);
            intList1.Add(item[3]);
            intList1.Add(item[4]);
            intList1.Add(item[5]);
            intList1.Add(item[6]);
            intList1.Add(item[7]);

            MyList<int> intList2 = new MyList<int>();
            intList2.Add(item[8]);
            intList2.Add(item[9]);
            intList2.Add(item[10]);
            intList2.Add(item[11]);
            intList2.Add(item[12]);

            MyList<int> result = intList1 + intList2;

            for (int i = 0; i < item.Length; i++)
            {
                Assert.AreEqual(item[i], result[i]);
            }
        }
        [TestMethod]
        public void SuccessfulIntSecondLargerOpAdd()
        {
            int[] item = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };

            MyList<int> intList1 = new MyList<int>();
            intList1.Add(item[0]);
            intList1.Add(item[1]);
            intList1.Add(item[2]);
            intList1.Add(item[3]);


            MyList<int> intList2 = new MyList<int>();
            intList2.Add(item[4]);
            intList2.Add(item[5]);
            intList2.Add(item[6]);
            intList2.Add(item[7]);
            intList2.Add(item[8]);
            intList2.Add(item[9]);
            intList2.Add(item[10]);
            intList2.Add(item[11]);
            intList2.Add(item[12]);

            MyList<int> result = intList1 + intList2;

            for (int i = 0; i < item.Length; i++)
            {
                Assert.AreEqual(item[i], result[i]);
            }
        }
        [TestMethod]
        public void SuccessfulIntSingleElementOpAdd()
        {
            int[] item = new int[] { 1, 2 };

            MyList<int> intList1 = new MyList<int>();
            intList1.Add(item[0]);


            MyList<int> intList2 = new MyList<int>();
            intList2.Add(item[1]);


            MyList<int> result = intList1 + intList2;

            for (int i = 0; i < item.Length; i++)
            {
                Assert.AreEqual(item[i], result[i]);
            }
        }
        [TestMethod]
        public void SuccessfulIntFirstEmptyOpAdd()
        {
            int[] item = new int[] { 1 };

            MyList<int> intList1 = new MyList<int>();


            MyList<int> intList2 = new MyList<int>();
            intList2.Add(item[0]);


            MyList<int> result = intList1 + intList2;

            for (int i = 0; i < item.Length; i++)
            {
                Assert.AreEqual(item[i], result[i]);
            }
        }
        [TestMethod]
        public void SuccessfulIntSecondEmptyOpAdd()
        {
            int[] item = new int[] { 1 };

            MyList<int> intList1 = new MyList<int>();
            intList1.Add(item[0]);

            MyList<int> intList2 = new MyList<int>();


            MyList<int> result = intList1 + intList2;

            for (int i = 0; i < item.Length; i++)
            {
                Assert.AreEqual(item[i], result[i]);
            }
        }
        [TestMethod]
        public void SuccessfulIntBothEmptyOpAdd()
        {
            MyList<int> item = new MyList<int>();

            MyList<int> intList1 = new MyList<int>();

            MyList<int> intList2 = new MyList<int>();


            MyList<int> result = intList1 + intList2;

            Assert.AreEqual(item.Length, result.Length);
        }
        [TestMethod]
        public void SuccessfulStringEqualSizeOpAdd()
        {
            string[] item = new string[] { "Jason", "Bob", "Michelle", "Lucas", "Frank", "Mike", "Jose", "Patricia" };

            MyList<string> stringList1 = new MyList<string>();
            stringList1.Add(item[0]);
            stringList1.Add(item[1]);
            stringList1.Add(item[2]);
            stringList1.Add(item[3]);

            MyList<string> stringList2 = new MyList<string>();
            stringList2.Add(item[4]);
            stringList2.Add(item[5]);
            stringList2.Add(item[6]);
            stringList2.Add(item[7]);

            MyList<string> result = stringList1 + stringList2;

            for (int i = 0; i < item.Length; i++)
            {
                Assert.AreEqual(item[i], result[i]);
            }
        }
        [TestMethod]
        public void SuccessfulStringFirstLargerOpAdd()
        {
            string[] item = new string[] { "Jason", "Bob", "Michelle", "Lucas", "Frank", "Mike", "Jose", "Patricia" };

            MyList<string> stringList1 = new MyList<string>();
            stringList1.Add(item[0]);
            stringList1.Add(item[1]);
            stringList1.Add(item[2]);
            stringList1.Add(item[3]);
            stringList1.Add(item[4]);
            stringList1.Add(item[5]);

            MyList<string> stringList2 = new MyList<string>();
            stringList2.Add(item[6]);
            stringList2.Add(item[7]);


            MyList<string> result = stringList1 + stringList2;

            for (int i = 0; i < item.Length; i++)
            {
                Assert.AreEqual(item[i], result[i]);
            }
        }
        [TestMethod]
        public void SuccessfulStringSecondLargerOpAdd()
        {
            string[] item = new string[] { "Jason", "Bob", "Michelle", "Lucas", "Frank", "Mike", "Jose", "Patricia" };

            MyList<string> stringList1 = new MyList<string>();
            stringList1.Add(item[0]);
            stringList1.Add(item[1]);


            MyList<string> stringList2 = new MyList<string>();
            stringList2.Add(item[2]);
            stringList2.Add(item[3]);
            stringList2.Add(item[4]);
            stringList2.Add(item[5]);
            stringList2.Add(item[6]);
            stringList2.Add(item[7]);


            MyList<string> result = stringList1 + stringList2;

            for (int i = 0; i < item.Length; i++)
            {
                Assert.AreEqual(item[i], result[i]);
            }
        }
        [TestMethod]
        public void SuccessfulStringSingleElementOpAdd()
        {
            string[] item = new string[] { "Jason", "Bob" };

            MyList<string> stringList1 = new MyList<string>();
            stringList1.Add(item[0]);

            MyList<string> stringList2 = new MyList<string>();
            stringList2.Add(item[1]);

            MyList<string> result = stringList1 + stringList2;

            for (int i = 0; i < item.Length; i++)
            {
                Assert.AreEqual(item[i], result[i]);
            }
        }
        [TestMethod]
        public void SuccessfulStringFirstEmptyOpAdd()
        {
            string[] item = new string[] { "Jason", "Bob" };

            MyList<string> stringList1 = new MyList<string>();


            MyList<string> stringList2 = new MyList<string>();
            stringList2.Add(item[0]);
            stringList2.Add(item[1]);

            MyList<string> result = stringList1 + stringList2;

            for (int i = 0; i < item.Length; i++)
            {
                Assert.AreEqual(item[i], result[i]);
            }
        }
        [TestMethod]
        public void SuccessfulStringSecondEmptyOpAdd()
        {
            string[] item = new string[] { "Jason", "Bob" };

            MyList<string> stringList1 = new MyList<string>();
            stringList1.Add(item[0]);
            stringList1.Add(item[1]);

            MyList<string> stringList2 = new MyList<string>();


            MyList<string> result = stringList1 + stringList2;

            for (int i = 0; i < item.Length; i++)
            {
                Assert.AreEqual(item[i], result[i]);
            }
        }
        [TestMethod]
        public void SuccessfulStringBothEmptyOpAdd()
        {
            MyList<string> item = new MyList<string>();

            MyList<string> stringList1 = new MyList<string>();

            MyList<string> stringList2 = new MyList<string>();


            MyList<string> result = stringList1 + stringList2;

            Assert.AreEqual(item.Length, result.Length);
        }
        [TestMethod]
        public void SuccessfulObjEqualSizeOpAdd()
        {
            Person person1 = new MyListTest.Person("Jason", 40, "Black");
            Person person2 = new MyListTest.Person("Michelle", 39, "Blond");
            Person person3 = new MyListTest.Person("Lucas", 12, "Brown");
            Person person4 = new MyListTest.Person("Carter", 10, "Black");
            Person person5 = new MyListTest.Person("Brook", 7, "Blond");
            Person person6 = new MyListTest.Person("Pat", 80, "Purple");
            Person person7 = new MyListTest.Person("Frank", 39, "Blond");
            Person person8 = new MyListTest.Person("Jonathan", 21, "Brown");
            Person person9 = new MyListTest.Person("Bob", 10, "Black");
            Person person10 = new MyListTest.Person("Darcy", 70, "Blond");
            Person[] item = new Person[] { person1, person2, person3, person4, person5, person6, person7, person8, person9, person10 };

            MyList<Person> objList1 = new MyList<Person>();
            MyList<Person> objList2 = new MyList<Person>();

            for (int i = 0; i < item.Length; i++)
            {
                if (i < 5)
                {
                    objList1.Add(item[i]);
                }
                else
                {
                    objList2.Add(item[i]);
                }
            }

            MyList<Person> result = objList1 + objList2;

            for (int i = 0; i < item.Length; i++)
            {
                Assert.AreEqual(item[i], result[i]);
            }
        }
        [TestMethod]
        public void SuccessfulObjFirstLargerOpAdd()
        {
            Person person1 = new MyListTest.Person("Jason", 40, "Black");
            Person person2 = new MyListTest.Person("Michelle", 39, "Blond");
            Person person3 = new MyListTest.Person("Lucas", 12, "Brown");
            Person person4 = new MyListTest.Person("Carter", 10, "Black");
            Person person5 = new MyListTest.Person("Brook", 7, "Blond");
            Person person6 = new MyListTest.Person("Pat", 80, "Purple");
            Person person7 = new MyListTest.Person("Frank", 39, "Blond");
            Person person8 = new MyListTest.Person("Jonathan", 21, "Brown");
            Person person9 = new MyListTest.Person("Bob", 10, "Black");
            Person person10 = new MyListTest.Person("Darcy", 70, "Blond");
            Person[] item = new Person[] { person1, person2, person3, person4, person5, person6, person7, person8, person9, person10 };

            MyList<Person> objList1 = new MyList<Person>();
            MyList<Person> objList2 = new MyList<Person>();

            for (int i = 0; i < item.Length; i++)
            {
                if (i < 7)
                {
                    objList1.Add(item[i]);
                }
                else
                {
                    objList2.Add(item[i]);
                }
            }

            MyList<Person> result = objList1 + objList2;

            for (int i = 0; i < item.Length; i++)
            {
                Assert.AreEqual(item[i], result[i]);
            }
        }
        [TestMethod]
        public void SuccessfulObjSecondLargerOpAdd()
        {
            Person person1 = new MyListTest.Person("Jason", 40, "Black");
            Person person2 = new MyListTest.Person("Michelle", 39, "Blond");
            Person person3 = new MyListTest.Person("Lucas", 12, "Brown");
            Person person4 = new MyListTest.Person("Carter", 10, "Black");
            Person person5 = new MyListTest.Person("Brook", 7, "Blond");
            Person person6 = new MyListTest.Person("Pat", 80, "Purple");
            Person person7 = new MyListTest.Person("Frank", 39, "Blond");
            Person person8 = new MyListTest.Person("Jonathan", 21, "Brown");
            Person person9 = new MyListTest.Person("Bob", 10, "Black");
            Person person10 = new MyListTest.Person("Darcy", 70, "Blond");
            Person[] item = new Person[] { person1, person2, person3, person4, person5, person6, person7, person8, person9, person10 };

            MyList<Person> objList1 = new MyList<Person>();
            MyList<Person> objList2 = new MyList<Person>();

            for (int i = 0; i < item.Length; i++)
            {
                if (i < 2)
                {
                    objList1.Add(item[i]);
                }
                else
                {
                    objList2.Add(item[i]);
                }
            }

            MyList<Person> result = objList1 + objList2;

            for (int i = 0; i < item.Length; i++)
            {
                Assert.AreEqual(item[i], result[i]);
            }
        }
        [TestMethod]
        public void SuccessfulObjSingleElementOpAdd()
        {
            Person person1 = new MyListTest.Person("Jason", 40, "Black");
            Person person2 = new MyListTest.Person("Michelle", 39, "Blond");

            Person[] item = new Person[] { person1, person2 };

            MyList<Person> objList1 = new MyList<Person>();
            objList1.Add(item[0]);


            MyList<Person> objList2 = new MyList<Person>();
            objList2.Add(item[1]);


            MyList<Person> result = objList1 + objList2;

            for (int i = 0; i < item.Length; i++)
            {
                Assert.AreEqual(item[i], result[i]);
            }
        }
        [TestMethod]
        public void SuccessfulObjSecondEmptyOpAdd()
        {
            Person person1 = new MyListTest.Person("Jason", 40, "Black");
            Person person2 = new MyListTest.Person("Michelle", 39, "Blond");

            Person[] item = new Person[] { person1 };

            MyList<Person> objList1 = new MyList<Person>();
            objList1.Add(item[0]);

            MyList<Person> objList2 = new MyList<Person>();

            MyList<Person> result = objList1 + objList2;

            for (int i = 0; i < item.Length; i++)
            {
                Assert.AreEqual(item[i], result[i]);
            }
        }
        [TestMethod]
        public void SuccessfulObjFirstEmptyOpAdd()
        {
            Person person1 = new MyListTest.Person("Jason", 40, "Black");
            Person person2 = new MyListTest.Person("Michelle", 39, "Blond");

            Person[] item = new Person[] { person1 };

            MyList<Person> objList1 = new MyList<Person>();

            MyList<Person> objList2 = new MyList<Person>();
            objList2.Add(item[0]);


            MyList<Person> result = objList1 + objList2;

            for (int i = 0; i < item.Length; i++)
            {
                Assert.AreEqual(item[i], result[i]);
            }
        }
        [TestMethod]
        public void SuccessfulObjBothEmptyOpAdd()
        {
            MyList<Person> item = new MyList<Person>();

            MyList<Person> objList1 = new MyList<Person>();

            MyList<Person> objList2 = new MyList<Person>();

            MyList<Person> result = objList1 + objList2;


            Assert.AreEqual(item.Length, result.Length);
        }

        //Testing - operator 
        [TestMethod]
        public void SuccessfulIntOpSub()
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] evens = new int[] { 2, 4, 6, 8, 10 };
            int[] odds = new int[] { 1, 3, 5, 7, 9 };

            MyList<int> intList1 = new MyList<int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                intList1.Add(numbers[i]);
            }

            MyList<int> intList2 = new MyList<int>();
            for (int i = 0; i < odds.Length; i++)
            {
                intList2.Add(odds[i]);
            }

            MyList<int> result = intList1 - intList2;

            for (int i = 0; i < evens.Length; i++)
            {
                Assert.AreEqual(evens[i], result[i]);
            }
        }
        [TestMethod]
        public void SuccessfulIntNoMatchOpSub()
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] evens = new int[] { 2, 4, 6, 8, 10 };
            int[] odds = new int[] { 1, 3, 5, 7, 9 };

            MyList<int> intList1 = new MyList<int>();
            for (int i = 0; i < evens.Length; i++)
            {
                intList1.Add(evens[i]);
            }

            MyList<int> intList2 = new MyList<int>();
            for (int i = 0; i < odds.Length; i++)
            {
                intList2.Add(odds[i]);
            }

            MyList<int> result = intList1 - intList2;

            for (int i = 0; i < evens.Length; i++)
            {
                Assert.AreEqual(evens[i], result[i]);
            }
        }
        [TestMethod]
        public void SuccessfulIntSecondEmptyOpSub()
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] evens = new int[] { 2, 4, 6, 8, 10 };
            int[] odds = new int[] { 1, 3, 5, 7, 9 };

            MyList<int> intList1 = new MyList<int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                intList1.Add(numbers[i]);
            }

            MyList<int> intList2 = new MyList<int>();


            MyList<int> result = intList1 - intList2;

            for (int i = 0; i < numbers.Length; i++)
            {
                Assert.AreEqual(numbers[i], result[i]);
            }
        }
        [TestMethod]
        public void SuccessfulIntFirstEmptyOpSub()
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            MyList<int> empty = new MyList<int>();

            MyList<int> intList1 = new MyList<int>();

            MyList<int> intList2 = new MyList<int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                intList2.Add(numbers[i]);
            }

            MyList<int> result = intList1 - intList2;

            Assert.AreEqual(empty.Length, result.Length);
        }
        [TestMethod]
        public void SuccessfulIntBothEmptyOpSub()
        {
            MyList<int> empty = new MyList<int>();

            MyList<int> intList1 = new MyList<int>();

            MyList<int> intList2 = new MyList<int>();


            MyList<int> result = intList1 - intList2;

            Assert.AreEqual(empty.Length, result.Length);
        }
        [TestMethod]
        public void SuccessfulStringOpSub()
        {
            string[] names = new string[] { "Jason", "Bob", "Michelle", "Lucas", "Frank", "Mike", "Jose", "Patricia" };
            string[] boys = new string[] { "Jason", "Bob", "Lucas", "Frank", "Mike", "Jose" };
            string[] girls = new string[] { "Michelle", "Patricia" };


            MyList<string> stringList1 = new MyList<string>();
            for (int i = 0; i < names.Length; i++)
            {
                stringList1.Add(names[i]);
            }

            MyList<string> stringList2 = new MyList<string>();
            for (int i = 0; i < girls.Length; i++)
            {
                stringList2.Add(girls[i]);
            }


            MyList<string> result = stringList1 - stringList2;

            for (int i = 0; i < boys.Length; i++)
            {
                Assert.AreEqual(boys[i], result[i]);
            }
        }
        [TestMethod]
        public void SuccessfulStringNoMatchOpSub()
        {
            string[] names = new string[] { "Jason", "Bob", "Michelle", "Lucas", "Frank", "Mike", "Jose", "Patricia" };
            string[] boys = new string[] { "Jason", "Bob", "Lucas", "Frank", "Mike", "Jose" };
            string[] girls = new string[] { "Michelle", "Patricia" };


            MyList<string> stringList1 = new MyList<string>();
            for (int i = 0; i < boys.Length; i++)
            {
                stringList1.Add(boys[i]);
            }

            MyList<string> stringList2 = new MyList<string>();
            for (int i = 0; i < girls.Length; i++)
            {
                stringList2.Add(girls[i]);
            }


            MyList<string> result = stringList1 - stringList2;

            for (int i = 0; i < boys.Length; i++)
            {
                Assert.AreEqual(boys[i], result[i]);
            }
        }
        [TestMethod]
        public void SuccessfulStringSecondEmptyOpSub()
        {
            string[] names = new string[] { "Jason", "Bob", "Michelle", "Lucas", "Frank", "Mike", "Jose", "Patricia" };
            string[] boys = new string[] { "Jason", "Bob", "Lucas", "Frank", "Mike", "Jose" };
            string[] girls = new string[] { "Michelle", "Patricia" };


            MyList<string> stringList1 = new MyList<string>();
            for (int i = 0; i < names.Length; i++)
            {
                stringList1.Add(names[i]);
            }

            MyList<string> stringList2 = new MyList<string>();


            MyList<string> result = stringList1 - stringList2;

            for (int i = 0; i < names.Length; i++)
            {
                Assert.AreEqual(names[i], result[i]);
            }
        }
        [TestMethod]
        public void SuccessfulStringFirstEmptyOpSub()
        {
            string[] names = new string[] { "Jason", "Bob", "Michelle", "Lucas", "Frank", "Mike", "Jose", "Patricia" };
            string[] boys = new string[] { "Jason", "Bob", "Lucas", "Frank", "Mike", "Jose" };
            string[] girls = new string[] { "Michelle", "Patricia" };
            MyList<string> empty = new MyList<string>();

            MyList<string> stringList1 = new MyList<string>();

            MyList<string> stringList2 = new MyList<string>();
            for (int i = 0; i < names.Length; i++)
            {
                stringList2.Add(names[i]);
            }

            MyList<string> result = stringList1 - stringList2;

            Assert.AreEqual(empty.Length, result.Length);
        }
        [TestMethod]
        public void SuccessfulStringBothEmptyOpSub()
        {

            MyList<string> empty = new MyList<string>();

            MyList<string> stringList1 = new MyList<string>();

            MyList<string> stringList2 = new MyList<string>();


            MyList<string> result = stringList1 - stringList2;

            Assert.AreEqual(empty.Length, result.Length);
        }
        [TestMethod]
        public void SuccessfulObjOpSub()
        {
            Person person1 = new MyListTest.Person("Jason", 40, "Black");
            Person person2 = new MyListTest.Person("Michelle", 39, "Blond");
            Person person3 = new MyListTest.Person("Lucas", 12, "Brown");
            Person person4 = new MyListTest.Person("Carter", 10, "Black");
            Person person5 = new MyListTest.Person("Brook", 7, "Blond");
            Person person6 = new MyListTest.Person("Pat", 80, "Purple");
            Person person7 = new MyListTest.Person("Frank", 39, "Blond");
            Person person8 = new MyListTest.Person("Jonathan", 21, "Brown");
            Person person9 = new MyListTest.Person("Bob", 10, "Black");
            Person person10 = new MyListTest.Person("Darcy", 70, "Blond");
            Person[] people = new Person[] { person1, person2, person3, person4, person5, person6, person7, person8, person9, person10 };
            Person[] girls = new Person[] { person2, person5, person10 };
            Person[] boys = new Person[] { person1, person3, person4, person6, person7, person8, person9 };

            MyList<Person> objList1 = new MyList<Person>();
            for (int i = 0; i < people.Length; i++)
            {
                objList1.Add(people[i]);

            }
            MyList<Person> objList2 = new MyList<Person>();
            for (int i = 0; i < girls.Length; i++)
            {
                objList2.Add(girls[i]);

            }

            MyList<Person> result = objList1 - objList2;

            for (int i = 0; i < boys.Length; i++)
            {
                Assert.AreEqual(boys[i], result[i]);
            }
        }
        [TestMethod]
        public void SuccessfulObjNoMatchOpSub()
        {
            Person person1 = new MyListTest.Person("Jason", 40, "Black");
            Person person2 = new MyListTest.Person("Michelle", 39, "Blond");
            Person person3 = new MyListTest.Person("Lucas", 12, "Brown");
            Person person4 = new MyListTest.Person("Carter", 10, "Black");
            Person person5 = new MyListTest.Person("Brook", 7, "Blond");
            Person person6 = new MyListTest.Person("Pat", 80, "Purple");
            Person person7 = new MyListTest.Person("Frank", 39, "Blond");
            Person person8 = new MyListTest.Person("Jonathan", 21, "Brown");
            Person person9 = new MyListTest.Person("Bob", 10, "Black");
            Person person10 = new MyListTest.Person("Darcy", 70, "Blond");
            Person[] people = new Person[] { person1, person2, person3, person4, person5, person6, person7, person8, person9, person10 };
            Person[] girls = new Person[] { person2, person5, person10 };
            Person[] boys = new Person[] { person1, person3, person4, person6, person7, person8, person9 };

            MyList<Person> objList1 = new MyList<Person>();
            for (int i = 0; i < boys.Length; i++)
            {
                objList1.Add(boys[i]);

            }
            MyList<Person> objList2 = new MyList<Person>();
            for (int i = 0; i < girls.Length; i++)
            {
                objList2.Add(girls[i]);

            }

            MyList<Person> result = objList1 - objList2;

            for (int i = 0; i < boys.Length; i++)
            {
                Assert.AreEqual(boys[i], result[i]);
            }
        }
        [TestMethod]
        public void SuccessfulObjSecondEmptyOpSub()
        {
            Person person1 = new MyListTest.Person("Jason", 40, "Black");
            Person person2 = new MyListTest.Person("Michelle", 39, "Blond");
            Person person3 = new MyListTest.Person("Lucas", 12, "Brown");
            Person person4 = new MyListTest.Person("Carter", 10, "Black");
            Person person5 = new MyListTest.Person("Brook", 7, "Blond");
            Person person6 = new MyListTest.Person("Pat", 80, "Purple");
            Person person7 = new MyListTest.Person("Frank", 39, "Blond");
            Person person8 = new MyListTest.Person("Jonathan", 21, "Brown");
            Person person9 = new MyListTest.Person("Bob", 10, "Black");
            Person person10 = new MyListTest.Person("Darcy", 70, "Blond");
            Person[] people = new Person[] { person1, person2, person3, person4, person5, person6, person7, person8, person9, person10 };
            Person[] girls = new Person[] { person2, person5, person10 };
            Person[] boys = new Person[] { person1, person3, person4, person6, person7, person8, person9 };

            MyList<Person> objList1 = new MyList<Person>();
            for (int i = 0; i < people.Length; i++)
            {
                objList1.Add(people[i]);

            }
            MyList<Person> objList2 = new MyList<Person>();


            MyList<Person> result = objList1 - objList2;

            for (int i = 0; i < people.Length; i++)
            {
                Assert.AreEqual(people[i], result[i]);
            }
        }
        [TestMethod]
        public void SuccessfulObjFirstEmptyOpSub()
        {
            Person person1 = new MyListTest.Person("Jason", 40, "Black");
            Person person2 = new MyListTest.Person("Michelle", 39, "Blond");
            Person person3 = new MyListTest.Person("Lucas", 12, "Brown");
            Person person4 = new MyListTest.Person("Carter", 10, "Black");
            Person person5 = new MyListTest.Person("Brook", 7, "Blond");
            Person person6 = new MyListTest.Person("Pat", 80, "Purple");
            Person person7 = new MyListTest.Person("Frank", 39, "Blond");
            Person person8 = new MyListTest.Person("Jonathan", 21, "Brown");
            Person person9 = new MyListTest.Person("Bob", 10, "Black");
            Person person10 = new MyListTest.Person("Darcy", 70, "Blond");
            Person[] people = new Person[] { person1, person2, person3, person4, person5, person6, person7, person8, person9, person10 };
            MyList<Person> empty = new MyList<Person>();

            MyList<Person> objList1 = new MyList<Person>();

            MyList<Person> objList2 = new MyList<Person>();
            for (int i = 0; i < people.Length; i++)
            {
                objList2.Add(people[i]);

            }

            MyList<Person> result = objList1 - objList2;

            Assert.AreEqual(empty.Length, result.Length);
        }
        [TestMethod]
        public void SuccessfulObjBothEmptyOpSub()
        {
            MyList<Person> empty = new MyList<Person>();

            MyList<Person> objList1 = new MyList<Person>();

            MyList<Person> objList2 = new MyList<Person>();

            MyList<Person> result = objList1 - objList2;

            Assert.AreEqual(empty.Length, result.Length);
        }

        //Testing Count Method
        [TestMethod]
        public void SuccessfulIntCount()
        {
            int size = 100;
            MyList<int> intList = new MyList<int>();
            for (int i = 0; i < size; i++)
            {
                intList.Add(i);
            }

            int result = intList.Count();

            Assert.AreEqual(size, result);
        }
        [TestMethod]
        public void SuccessfulIntStressCount()
        {
            int size = 100000;
            MyList<int> intList = new MyList<int>();
            for (int i = 0; i < size; i++)
            {
                intList.Add(i);
            }

            int result = intList.Count();

            Assert.AreEqual(size, result);
        }
        [TestMethod]
        public void SuccessfulIntEmptyCount()
        {
            int size = 0;
            MyList<int> intList = new MyList<int>();

            int result = intList.Count();

            Assert.AreEqual(size, result);
        }
        [TestMethod]
        public void SuccessfulStringCount()
        {
            string[] names = new string[] { "Jason", "Bob", "Michelle", "Lucas", "Frank", "Mike", "Jose", "Patricia" };
            MyList<string> stringList = new MyList<string>();
            for (int i = 0; i < names.Length; i++)
            {
                stringList.Add(names[i]);
            }

            int result = stringList.Count();

            Assert.AreEqual(names.Length, result);
        }
        [TestMethod]
        public void SuccessfulStringEmptyCount()
        {
            int size = 0;
            MyList<string> stringList = new MyList<string>();


            int result = stringList.Count();

            Assert.AreEqual(size, result);
        }
        [TestMethod]
        public void SuccessfulObjCount()
        {
            Person person1 = new MyListTest.Person("Jason", 40, "Black");
            Person person2 = new MyListTest.Person("Michelle", 39, "Blond");
            Person person3 = new MyListTest.Person("Lucas", 12, "Brown");
            Person person4 = new MyListTest.Person("Carter", 10, "Black");
            Person person5 = new MyListTest.Person("Brook", 7, "Blond");
            Person person6 = new MyListTest.Person("Pat", 80, "Purple");
            Person person7 = new MyListTest.Person("Frank", 39, "Blond");
            Person person8 = new MyListTest.Person("Jonathan", 21, "Brown");
            Person person9 = new MyListTest.Person("Bob", 10, "Black");
            Person person10 = new MyListTest.Person("Darcy", 70, "Blond");
            Person[] people = new Person[] { person1, person2, person3, person4, person5, person6, person7, person8, person9, person10 };

            MyList<Person> objList = new MyList<Person>();
            for (int i = 0; i < people.Length; i++)
            {
                objList.Add(people[i]);
            }

            int result = objList.Count();

            Assert.AreEqual(people.Length, result);
        }
        [TestMethod]
        public void SuccessfulObjEmptyCount()
        {

            int size = 0;
            MyList<Person> objList = new MyList<Person>();

            int result = objList.Count();

            Assert.AreEqual(size, result);
        }


        //Testing Zip Method
        [TestMethod]
        public void SuccessfulIntZip()
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] evens = new int[] { 2, 4, 6, 8, 10 };
            int[] odds = new int[] { 1, 3, 5, 7, 9 };

            MyList<int> intList1 = new MyList<int>();
            for (int i = 0; i < odds.Length; i++)
            {
                intList1.Add(odds[i]);
            }

            MyList<int> intList2 = new MyList<int>();
            for (int i = 0; i < evens.Length; i++)
            {
                intList2.Add(evens[i]);
            }

            MyList<int> result = intList1.Zip(intList2);

            for (int i = 0; i < numbers.Length; i++)
            {
                Assert.AreEqual(numbers[i], result[i]);
            }
        }
        [TestMethod]
        public void SuccessfulIntFirstLargerZip()
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 13, 15, 17, 19, 21 };
            int[] evens = new int[] { 2, 4, 6, 8, 10 };
            int[] odds = new int[] { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21 };

            MyList<int> intList1 = new MyList<int>();
            for (int i = 0; i < odds.Length; i++)
            {
                intList1.Add(odds[i]);
            }

            MyList<int> intList2 = new MyList<int>();
            for (int i = 0; i < evens.Length; i++)
            {
                intList2.Add(evens[i]);
            }

            MyList<int> result = intList1.Zip(intList2);

            for (int i = 0; i < numbers.Length; i++)
            {
                Assert.AreEqual(numbers[i], result[i]);
            }
        }
        [TestMethod]
        public void SuccessfulIntSecondLargerZip()
        {
            int[] numbers = new int[] { 2, 1, 4, 3, 6, 5, 8, 7, 10, 9, 11, 13, 15, 17, 19, 21 };
            int[] evens = new int[] { 2, 4, 6, 8, 10 };
            int[] odds = new int[] { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21 };

            MyList<int> intList1 = new MyList<int>();
            for (int i = 0; i < evens.Length; i++)
            {
                intList1.Add(evens[i]);
            }

            MyList<int> intList2 = new MyList<int>();
            for (int i = 0; i < odds.Length; i++)
            {
                intList2.Add(odds[i]);
            }

            MyList<int> result = intList1.Zip(intList2);

            for (int i = 0; i < numbers.Length; i++)
            {
                Assert.AreEqual(numbers[i], result[i]);
            }
        }
        [TestMethod]
        public void SuccessfulIntSecondEmptyZip()
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };

            MyList<int> intList1 = new MyList<int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                intList1.Add(numbers[i]);
            }

            MyList<int> intList2 = new MyList<int>();

            MyList<int> result = intList1.Zip(intList2);

            for (int i = 0; i < numbers.Length; i++)
            {
                Assert.AreEqual(numbers[i], result[i]);
            }
        }
        [TestMethod]
        public void SuccessfulIntFirstEmptyZip()
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };

            MyList<int> intList1 = new MyList<int>();

            MyList<int> intList2 = new MyList<int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                intList2.Add(numbers[i]);
            }

            MyList<int> result = intList1.Zip(intList2);

            for (int i = 0; i < numbers.Length; i++)
            {
                Assert.AreEqual(numbers[i], result[i]);
            }
        }
        [TestMethod]
        public void SuccessfulStringZip()
        {
            string[] names = new string[] { "Jason", "Michelle", "Bob", "Patricia", "Lucas", "Betty", "Frank", "Julia", "Mike", "Rose", "Jose" };
            string[] boys = new string[] { "Jason", "Bob", "Lucas", "Frank", "Mike", "Jose" };
            string[] girls = new string[] { "Michelle", "Patricia", "Betty", "Julia", "Rose" };


            MyList<string> stringList1 = new MyList<string>();
            for (int i = 0; i < boys.Length; i++)
            {
                stringList1.Add(boys[i]);
            }

            MyList<string> stringList2 = new MyList<string>();
            for (int i = 0; i < girls.Length; i++)
            {
                stringList2.Add(girls[i]);
            }


            MyList<string> result = stringList1.Zip(stringList2);

            for (int i = 0; i < names.Length; i++)
            {
                Assert.AreEqual(names[i], result[i]);
            }
        }
        [TestMethod]
        public void SuccessfulStringFirstLargerZip()
        {
            string[] names = new string[] { "Jason", "Michelle", "Bob", "Patricia", "Lucas", "Frank", "Mike", "Jose" };
            string[] boys = new string[] { "Jason", "Bob", "Lucas", "Frank", "Mike", "Jose" };
            string[] girls = new string[] { "Michelle", "Patricia" };


            MyList<string> stringList1 = new MyList<string>();
            for (int i = 0; i < boys.Length; i++)
            {
                stringList1.Add(boys[i]);
            }

            MyList<string> stringList2 = new MyList<string>();
            for (int i = 0; i < girls.Length; i++)
            {
                stringList2.Add(girls[i]);
            }


            MyList<string> result = stringList1.Zip(stringList2);

            for (int i = 0; i < names.Length; i++)
            {
                Assert.AreEqual(names[i], result[i]);
            }
        }
        [TestMethod]
        public void SuccessfulStringSecondLargerZip()
        {
            string[] names = new string[] { "Michelle", "Jason", "Patricia", "Bob", "Lucas", "Frank", "Mike", "Jose" };
            string[] boys = new string[] { "Jason", "Bob", "Lucas", "Frank", "Mike", "Jose" };
            string[] girls = new string[] { "Michelle", "Patricia" };


            MyList<string> stringList1 = new MyList<string>();
            for (int i = 0; i < girls.Length; i++)
            {
                stringList1.Add(girls[i]);
            }

            MyList<string> stringList2 = new MyList<string>();
            for (int i = 0; i < boys.Length; i++)
            {
                stringList2.Add(boys[i]);
            }

            MyList<string> result = stringList1.Zip(stringList2);

            for (int i = 0; i < names.Length; i++)
            {
                Assert.AreEqual(names[i], result[i]);
            }
        }
        [TestMethod]
        public void SuccessfulStringSecondEmptyZip()
        {
            string[] names = new string[] { "Michelle", "Jason", "Patricia", "Bob", "Lucas", "Frank", "Mike", "Jose" };

            MyList<string> stringList1 = new MyList<string>();
            for (int i = 0; i < names.Length; i++)
            {
                stringList1.Add(names[i]);
            }

            MyList<string> stringList2 = new MyList<string>();

            MyList<string> result = stringList1.Zip(stringList2);

            for (int i = 0; i < names.Length; i++)
            {
                Assert.AreEqual(names[i], result[i]);
            }
        }
        [TestMethod]
        public void SuccessfulStringFirstEmptyZip()
        {
            string[] names = new string[] { "Michelle", "Jason", "Patricia", "Bob", "Lucas", "Frank", "Mike", "Jose" };

            MyList<string> stringList1 = new MyList<string>();

            MyList<string> stringList2 = new MyList<string>();
            for (int i = 0; i < names.Length; i++)
            {
                stringList2.Add(names[i]);
            }

            MyList<string> result = stringList1.Zip(stringList2);

            for (int i = 0; i < names.Length; i++)
            {
                Assert.AreEqual(names[i], result[i]);
            }
        }
        [TestMethod]
        public void SuccessfulStringBothEmptyZip()
        {
            MyList<string> empty = new MyList<string>();

            MyList<string> stringList1 = new MyList<string>();

            MyList<string> stringList2 = new MyList<string>();

            MyList<string> result = stringList1.Zip(stringList2);

            Assert.AreEqual(empty.Length, result.Length);
        }
        [TestMethod]
        public void SuccessfulObjZip()
        {
            Person person1 = new MyListTest.Person("Jason", 40, "Black");
            Person person2 = new MyListTest.Person("Michelle", 39, "Blond");
            Person person3 = new MyListTest.Person("Lucas", 12, "Brown");
            Person person4 = new MyListTest.Person("Carter", 10, "Black");
            Person person5 = new MyListTest.Person("Brook", 7, "Blond");
            Person person6 = new MyListTest.Person("Pat", 80, "Purple");
            Person person7 = new MyListTest.Person("Frank", 39, "Blond");
            Person person8 = new MyListTest.Person("Jonathan", 21, "Brown");
            Person person9 = new MyListTest.Person("Bob", 10, "Black");
            Person person10 = new MyListTest.Person("Darcy", 70, "Blond");
            Person[] people = new Person[] { person1, person2, person3, person5, person4, person10, person6, person7, person8, person9 };
            Person[] girls = new Person[] { person2, person5, person10 };
            Person[] boys = new Person[] { person1, person3, person4, person6, person7, person8, person9 };

            MyList<Person> objList1 = new MyList<Person>();
            for (int i = 0; i < boys.Length; i++)
            {
                objList1.Add(boys[i]);

            }
            MyList<Person> objList2 = new MyList<Person>();
            for (int i = 0; i < girls.Length; i++)
            {
                objList2.Add(girls[i]);

            }

            MyList<Person> result = objList1.Zip(objList2);

            for (int i = 0; i < people.Length; i++)
            {
                Assert.AreEqual(people[i], result[i]);
            }
        }


        //Testing Iteration 
        [TestMethod]
        public void IterateIntList()
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };

            MyList<int> intList = new MyList<int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                intList.Add(numbers[i]);
            }

            MyList<int> result = new MyList<int>();

            foreach (int intItem in intList)
                result.Add(intItem);

            for (int i = 0; i < numbers.Length; i++)
            {
                Assert.AreEqual(numbers[i], result[i]);
            }
        }
        [TestMethod]
        public void IterateObjList()
        {
            Person person1 = new MyListTest.Person("Jason", 40, "Black");
            Person person2 = new MyListTest.Person("Michelle", 39, "Blond");
            Person person3 = new MyListTest.Person("Lucas", 12, "Brown");
            Person person4 = new MyListTest.Person("Carter", 10, "Black");
            Person person5 = new MyListTest.Person("Brook", 7, "Blond");
            Person person6 = new MyListTest.Person("Pat", 80, "Purple");
            Person person7 = new MyListTest.Person("Frank", 39, "Blond");
            Person person8 = new MyListTest.Person("Jonathan", 21, "Brown");
            Person person9 = new MyListTest.Person("Bob", 10, "Black");
            Person person10 = new MyListTest.Person("Darcy", 70, "Blond");
            Person[] people = new Person[] { person1, person2, person3, person5, person4, person10, person6, person7, person8, person9 };

            MyList<Person> objList = new MyList<Person>();
            for (int i = 0; i < people.Length; i++)
            {
                objList.Add(people[i]);
            }

            MyList<Person> result = new MyList<Person>();
            foreach (Person intItem in objList)
                result.Add(intItem);

            for (int i = 0; i < people.Length; i++)
            {
                Assert.AreEqual(people[i], result[i]);
            }
        }
        [TestMethod]
        public void IterateStringList()
        {
            string[] names = new string[] { "Michelle", "Jason", "Patricia", "Bob", "Lucas", "Frank", "Mike", "Jose" };

            MyList<string> stringList = new MyList<string>();
            for (int i = 0; i < names.Length; i++)
            {
                stringList.Add(names[i]);
            }

            MyList<string> result = new MyList<string>();
            foreach (string intItem in stringList)
                result.Add(intItem);

            for (int i = 0; i < names.Length; i++)
            {
                Assert.AreEqual(names[i], result[i]);
            }
        }

        //Testing Sorting
        [TestMethod]
        public void SortIntList()
        {
            int[] orderedNumbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 38, 49, 58, 100, 123, 345, 654, 876, 987  };
            int[] unorderedNumbers = new int[] { 100, 12, 345, 49, 5, 6, 876, 8, 987, 10, 11, 2, 13, 14, 38, 16, 15, 4, 58, 1, 123, 3, 654, 7, 9 };

            MyList<int> intList = new MyList<int>();
            for (int i = 0; i < unorderedNumbers.Length; i++)
            {
                intList.Add(unorderedNumbers[i]);
            }

            intList.Sort();

            for (int i = 0; i < orderedNumbers.Length; i++)
            {
                Assert.AreEqual(orderedNumbers[i], intList[i]);
            }
        }
        [TestMethod]
        public void SortObjList()
        {
            Person person1 = new MyListTest.Person("Jason", 40, "Black");
            Person person2 = new MyListTest.Person("Michelle", 39, "Blond");
            Person person3 = new MyListTest.Person("Lucas", 12, "Brown");
            Person person4 = new MyListTest.Person("Carter", 10, "Black");
            Person person5 = new MyListTest.Person("Brook", 7, "Blond");
            Person person6 = new MyListTest.Person("Pat", 80, "Purple");
            Person person7 = new MyListTest.Person("Frank", 39, "Blond");
            Person person8 = new MyListTest.Person("Jonathan", 21, "Brown");
            Person person9 = new MyListTest.Person("Bob", 10, "Black");
            Person person10 = new MyListTest.Person("Darcy", 70, "Blond");
            Person[] people = new Person[] { person1, person2, person3, person5, person4, person10, person6, person7, person8, person9 };

            MyList<Person> objList = new MyList<Person>();
            for (int i = 0; i < people.Length; i++)
            {
                objList.Add(people[i]);
            }

            Array.Sort(people);
            objList.Sort();

            for (int i = 0; i < people.Length; i++)
            {
                Assert.AreEqual(people[i], objList[i]);
            }
        }
        [TestMethod]
        public void SortStringList()
        {
            string[] unorderedNames = new string[] { "Michelle", "Jason", "Patricia", "Bob", "Lucas", "Frank", "Mike", "Jose", "Freddy", "Adam", "Zebra", "Willy", "Robert", "Amanda", "Celery" };

            MyList<string> stringList = new MyList<string>();
            for (int i = 0; i < unorderedNames.Length; i++)
            {
                stringList.Add(unorderedNames[i]);
            }

            Array.Sort(unorderedNames);

            stringList.Sort();

            for (int i = 0; i < unorderedNames.Length; i++)
            {
                Assert.AreEqual(unorderedNames[i], stringList[i]);
            }
        }
        [TestMethod]
        public void SortEmpyList()
        {
            MyList<int> empty = new MyList<int>();

            MyList<int> intList = new MyList<int>();

            intList.Sort();

            Assert.AreEqual(empty.Length, intList.Length);
        }
        [TestMethod]
        public void SortIntOneInList()
        {
            int[] orderedNumbers = new int[] { 1};

            MyList<int> intList = new MyList<int>();
            for (int i = 0; i < orderedNumbers.Length; i++)
            {
                intList.Add(orderedNumbers[i]);
            }

            intList.Sort();

            for (int i = 0; i < orderedNumbers.Length; i++)
            {
                Assert.AreEqual(orderedNumbers[i], intList[i]);
            }
        }
        [TestMethod]
        public void SortIntTwoInList()
        {
            int[] orderedNumbers = new int[] { 1, 34 };
            int[] unorderedNumbers = new int[] { 34, 1 };


            MyList<int> intList = new MyList<int>();
            for (int i = 0; i < unorderedNumbers.Length; i++)
            {
                intList.Add(unorderedNumbers[i]);
            }

            intList.Sort();

            for (int i = 0; i < orderedNumbers.Length; i++)
            {
                Assert.AreEqual(orderedNumbers[i], intList[i]);
            }
        }
        [TestMethod]
        public void SortObjTwoInList()
        {
            Person person1 = new MyListTest.Person("Jason", 40, "Black");
            Person person2 = new MyListTest.Person("Michelle", 39, "Blond");
            Person[] unorderedPeople = new Person[] { person2, person1};
            Person[] orderedPeople = new Person[] { person1, person2 };


            MyList<Person> objList = new MyList<Person>();
            for (int i = 0; i < unorderedPeople.Length; i++)
            {
                objList.Add(unorderedPeople[i]);
            }

            Array.Sort(orderedPeople);
            objList.Sort();

            for (int i = 0; i < orderedPeople.Length; i++)
            {
                Assert.AreEqual(orderedPeople[i], objList[i]);
            }
        }
        [TestMethod]
        public void SortObjOneInList()
        {
            Person person1 = new MyListTest.Person("Jason", 40, "Black");
            Person[] orderedPeople = new Person[] { person1 };


            MyList<Person> objList = new MyList<Person>();
            
            objList.Add(person1);

            objList.Sort();

            for (int i = 0; i < orderedPeople.Length; i++)
            {
                Assert.AreEqual(orderedPeople[i], objList[i]);
            }
        }
    }

}
