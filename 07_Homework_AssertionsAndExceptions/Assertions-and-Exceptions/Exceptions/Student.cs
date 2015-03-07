using System;
using System.Linq;
using System.Collections.Generic;

public class Student
{
    private string firstName;
    private string lastName;
    private IList<Exam> exams;

    public Student(string firstName, string lastName, IList<Exam> exams = null)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Exams = exams;
    }

    public string FirstName 
    {
        get
        {
            return this.firstName;
        }
        private set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("First name cannot be empty.");
               // Environment.Exit(0);
            }

            this.firstName = value;
        } 
    }
    public string LastName 
    {
        get
        {
            return this.lastName;
        }
        private set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Last name cannot be empty.");
                //Environment.Exit(0);
            }

            this.lastName = value;
        } 
    }
    public IList<Exam> Exams 
    {
        get
        {
            return this.exams;
        }
        private set
        {
            this.exams = value;
        }
    }

    public IList<ExamResult> CheckExams()
    {
        if (this.Exams.Count == 0)
        {
            Console.WriteLine("The student has no exams!");
            return null;
        }
        else
        {
            IList<ExamResult> results = new List<ExamResult>();
            for (int i = 0; i < this.Exams.Count; i++)
            {
                results.Add(this.Exams[i].Check());
            }

            return results;
        }
    }

    public double CalcAverageExamResultInPercents()
    {
        if (this.Exams != null)
        {
            double[] examScore = new double[this.Exams.Count];
            IList<ExamResult> examResults = CheckExams();
            for (int i = 0; i < examResults.Count; i++)
            {
                double dividend = ((double)examResults[i].Grade - examResults[i].MinGrade);
                double divider = (examResults[i].MaxGrade - examResults[i].MinGrade);
                examScore[i] = dividend / divider;
            }

            return examScore.Average();
        }
        else
        {
            Console.Write("Cannot calculate average on missing exams: ");
            return 0;
        }
    }
}
