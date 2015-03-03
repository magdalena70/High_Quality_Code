using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndPolymorphism
{
    public class OffsiteCourse : Course
    {
        private string town;

        public OffsiteCourse(string courseName, string town = null)
            : base(courseName)
        {
            this.Town = town;
        }

        public OffsiteCourse(string courseName, string teacherName, string town = null)
            : base(courseName, teacherName)
        {
            this.Town = town;
        }

        public OffsiteCourse(string courseName, string teacherName, IList<string> students, string town = null)
            : base(courseName, teacherName, students)
        {
            this.Town = town;
        }

        public string Town
        {
            get { return this.town; }
            set 
            {
                if (value == "")
                {
                    throw new ArgumentException("Town name cannot be empty.");
                }
                this.town = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            if (this.Town != null)
            {
                result.Append(";\nTown = { ");
                result.Append(this.Town);
                result.Append(" }");
            }
            
            return "\nOffsite Course: " + base.ToString() + result.ToString();
        }
    }
}
