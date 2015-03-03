using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndPolymorphism
{
    public class LocalCourse : Course
    {
        private string lab;

        public LocalCourse(string courseName, string lab = null)
            : base(courseName)
        {
            this.Lab = lab;
        }

        public LocalCourse(string courseName, string teacherName, string lab = null)
            : base(courseName, teacherName)
        {
            this.Lab = lab;
        }

        public LocalCourse(string courseName, string teacherName, IList<string> students, string lab = null)
            : base(courseName, teacherName, students)
        {
            this.Lab = lab;
        }

        public string Lab
        {
            get { return this.lab; }
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("Lab name cannot be empty.");
                }
                this.lab = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            if (this.Lab != null)
            {
                result.Append(";\nLab = { ");
                result.Append(this.Lab);
                result.Append(" }");
            }

            return "\nLocal Course: " + base.ToString() + result.ToString();
        }
    }
}
