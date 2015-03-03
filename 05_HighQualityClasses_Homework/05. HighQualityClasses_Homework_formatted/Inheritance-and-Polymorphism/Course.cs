using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InheritanceAndPolymorphism
{
    public abstract class Course
    {
        private string courseName;
        private string teacherName;
        private IList<string> students;

        protected Course(string courseName)
        {
            this.CourseName = courseName;
        }

        protected Course(string courseName, string teacherName)
            : this(courseName)
        {
            this.TeacherName = teacherName;
        }

        protected Course(string courseName, string teacherName, IList<string> students)
            : this(courseName, teacherName)
        {
            this.TeacherName = teacherName;
            this.Students = students;
        }

        public string CourseName
        {
            get { return this.courseName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Course name cannot be empty.");
                }
                this.courseName = value;
            }
        }

        public string TeacherName
        {
            get { return this.teacherName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Teacher's name cannot be empty");
                }

                this.teacherName = value;
            }
        }

        public IList<string> Students
        {
            get { return this.students; }
            set
            {
                if (value != null)
                {
                
                    foreach (var student in value)
                    {

                        if (string.IsNullOrEmpty(student))
                        {
                            throw new ArgumentException("Student in list cannot be null or empty");
                        }
                    }
                }

                this.students = value;
            }
        }

        public string GetStudentsAsString()
        {
            if (this.Students == null || this.Students.Count == 0)
            {
                return "{ }";
            }
            else
            {
                return "{ " + string.Join(", ", this.Students);
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(" { Name = ");
            result.Append(this.CourseName);
            result.Append(" }");
            if (this.TeacherName != null && teacherName != " ")
            {
                result.Append(";\nTeacher = { ");
                result.Append(this.TeacherName);
                result.Append(" }");
            }

            if (this.Students != null)
            {
                result.Append(";\nStudents = ");
                result.Append(this.GetStudentsAsString());
                result.Append(" }");
            }

            return result.ToString();
        }
    }
}
