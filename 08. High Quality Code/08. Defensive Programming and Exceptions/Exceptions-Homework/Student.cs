using System;
using System.Collections.Generic;
using System.Linq;

public class Student
{
    private string firstName;
    private string lastName;

    public Student(string firstName, string lastName, IList<Exam> exams = null)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Exams = new List<Exam>();

        if (exams != null)
        {
            this.Exams = exams;
        }
    }

    public string FirstName
    {
        get
        {
            return this.firstName;
        }

        private set
        {
            if (value == null)
            {
                throw new ArgumentNullException(string.Format(GlobalErrorMessages.StringCannotBeNullOrEmpty, "Student first name"));
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
            if (value == null)
            {
                throw new ArgumentNullException(string.Format(GlobalErrorMessages.StringCannotBeNullOrEmpty, "Student last name"));
            }

            this.lastName = value;
        }
    }

    public IList<Exam> Exams { get; private set; }

    public IList<ExamResult> CheckExams()
    {
        IList<ExamResult> results = new List<ExamResult>();

        for (int i = 0; i < this.Exams.Count; i++)
        {
            results.Add(this.Exams[i].Check());
        }

        return results;
    }

    public double CalcAverageExamResultInPercents()
    {
        double[] examScore = new double[this.Exams.Count];
        IList<ExamResult> examResults = this.CheckExams();
        for (int i = 0; i < examResults.Count; i++)
        {
            int currentGrade = examResults[i].Grade;
            int currentMinGrade = examResults[i].MinGrade;
            int currentMaxGrade = examResults[i].MaxGrade;

            examScore[i] =
                (double)(currentGrade - currentMinGrade) / (currentMaxGrade - currentMinGrade);
        }

        return examScore.Average();
    }
}
