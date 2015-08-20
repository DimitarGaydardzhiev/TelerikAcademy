using System;

public class ExamResult
{
    private int grade;
    private int minGrade;
    private int maxGrade;
    private string comments;

    public ExamResult(int grade, int minGrade, int maxGrade, string comments)
    {
        this.Grade = grade;
        this.MinGrade = minGrade;
        this.MaxGrade = maxGrade;
        this.Comments = comments;
    }

    public int Grade
    {
        get
        {
            return this.grade;
        }

        private set
        {
            if (value < 0)
            {
                throw new ArgumentException(string.Format(GlobalErrorMessages.ValueShouldNotBeLessThanZero, "Grade"));
            }

            this.grade = value;
        }
    }

    public int MinGrade
    {
        get
        {
            return this.minGrade;
        }

        private set
        {
            if (value < 0)
            {
                throw new ArgumentException(string.Format(GlobalErrorMessages.ValueShouldNotBeLessThanZero, "Min grade"));
            }

            this.minGrade = value;
        }
    }

    public int MaxGrade
    {
        get
        {
            return this.maxGrade;
        }

        private set
        {
            if (value <= this.minGrade)
            {
                throw new ArgumentException(string.Format(GlobalErrorMessages.FirstValueShouldBeLessOrEqualThanSecondValue, "Min grade", "Max grade"));
            }

            this.maxGrade = value;
        }
    }

    public string Comments
    {
        get
        {
            return this.comments;
        }

        private set
        {
            if (value == null || value == string.Empty)
            {
                throw new ArgumentNullException(string.Format(GlobalErrorMessages.StringCannotBeNullOrEmpty, "Comments"));
            }

            this.comments = value;
        }
    }
}
