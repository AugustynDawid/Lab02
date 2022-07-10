using System;
using System.Collections.Generic;
using System.Text;

namespace Lab02
{
    class Person
    {
        protected string name;
        protected int age;
        public string Name
        {
            get => name;
            set { name = value; }
        }

        public int Age
        {
            get => age;
            set { age = value; }
        }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public bool Equals(Person? other)
        {
            if (other == null) return false;

            return (this.Name == other.Name && this.Age == other.Age);
        }

        public override string ToString()
        {
            return $"{this.Name} ({this.Age} y.o.)";
        }
    }
}
