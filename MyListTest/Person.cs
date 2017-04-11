using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyListTest
{
    public class Person
    {
        private string name;
        public string Name { get { return name; } set { name = value; } }

        private int age;
        public int Age { get { return age; } set { age = value; } }

        private string hairColor;
        public string HairColor { get { return hairColor; } set { hairColor = value; } }

        public Person(string name, int age, string hairColor)
        {
            this.name = name;
            this.age = age;
            this.hairColor = hairColor;
        }
    }
}
