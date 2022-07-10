using System;
using System.Collections.Generic;
using System.Text;

namespace Lab02
{
    class Task
    {
        private string name;
        private TaskStatus status;
        
        public string Name
        {
            get => name;
            set { name = value; }
        }

        public TaskStatus Status
        {
            get => status;
            set { status = value; }
        }

        public Task(string name, TaskStatus status)
        {
            this.name = name;
            this.status = status;
        }

        public bool Equals(Task? other)
        {
            if (other == null) return false;

            return (this.Name == other.Name && this.Status == other.Status);
        }

        public override string ToString()
        {
            return $"{this.Name} [{this.Status}]";
        }
    }

    enum TaskStatus
    {
        Waiting,
        Progress,
        Done,
        Rejected
    }
}
