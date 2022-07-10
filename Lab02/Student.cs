using System;
using System.Collections.Generic;
using System.Text;

namespace Lab02
{
    class Student : Person
    {
        protected string group;
        protected List<Task> tasks = new List<Task>();

        public string Group
        {
            get => group;
            set { group = value; }
        }

        public Student(string name, int age, string group)
            :base(name, age)
        {
            this.group = group;
        }

        public Student(string name, int age, string group, List<Task> tasks)
            : this(name, age, group)
        {
            this.tasks = tasks;
        }

        public void AddTask(string taskName, TaskStatus taskStatus)
        {
            Task newTask = new Task(taskName, taskStatus);
            this.tasks.Add(newTask);
        }

        public void RemoveTask(int index)
        {
            this.tasks.RemoveAt(index);
        }

        public void UpdateTask(int index, TaskStatus taskStatus)
        {
            this.tasks[index].Status = taskStatus;
        }

        public string RenderTasks(string prefix = "\t")
        {
            string result = "Tasks: " + System.Environment.NewLine;
            for (int i = 0; i < tasks.Count; i++)
            {
                result += prefix + (i + 1) + ". " + tasks[i].ToString() + System.Environment.NewLine;
            }

            return result;
        }

        public override string ToString()
        {
            string result =  "Student: " + base.ToString() + System.Environment.NewLine;
            result += $"Group: {this.group}" + System.Environment.NewLine;
            result += this.RenderTasks();

            return result;
        }

        /*
        public bool SequenceEqual(List<T> a, List<T> b)
        {
            throw new NotImplementedException();
        }
        */
    }
}
