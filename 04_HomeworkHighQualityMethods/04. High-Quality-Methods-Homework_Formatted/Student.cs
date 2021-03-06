﻿using System;

namespace Methods
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string OtherInfo { get; set; }

        /// <summary>
        /// Method compares the age of two students
        /// </summary>
        /// <param name="other">instance of class Student</param>
        /// <returns>Returns bool IsOlderThan other student</returns>
        public bool IsOlderThan(Student other)
        {
            DateTime firstDate =
                DateTime.Parse(this.OtherInfo.Substring(this.OtherInfo.Length - 10));
            DateTime secondDate =
                DateTime.Parse(other.OtherInfo.Substring(other.OtherInfo.Length - 10));
            
            return firstDate < secondDate;
        }
    }
}
