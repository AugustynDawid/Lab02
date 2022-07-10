using System;
using System.Collections.Generic;
using System.Text;

namespace Lab02
{
    class Classroom
    {
        private string name;
        private Person[] persons;

        public string Name
        {
            get => name;
            set { name = value; }
        }

        public Classroom(string name, Person[] persons)
        {
            this.name = name;
            this.persons = persons;
        }

        public override string ToString()
        {
            string result = $"Classroom: {this.name}" + System.Environment.NewLine;
            result += System.Environment.NewLine;

            string teacher = "";
            string students = "";

            foreach (Person p in this.persons)
            {
                if (p is Teacher)
                {
                    teacher += ((Teacher)p).ToString() + System.Environment.NewLine; ;
                }
                else if (p is Student)
                {
                    students += ((Student)p).ToString() + System.Environment.NewLine;
                }
            }

            result += teacher;
            result += System.Environment.NewLine;
            result += students;
            return result;

        }
    }
}
