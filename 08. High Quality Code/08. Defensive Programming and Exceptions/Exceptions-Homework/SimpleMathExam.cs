using System;

public class SimpleMathExam : Exam
{
    private const int MinProblemsSolved = 0;
    private const int MaxProblemsSolved = 10;
    private const int LowNumberOfProblemsSolwed = 0;
    private const int AverageNumberOfProblemsSolwed = 5;
    private const int GoodNumberOfProblemsSolwed = 8;

    private int problemsSolved;

    public SimpleMathExam(int problemsSolved)
    {
        this.ProblemsSolved = problemsSolved;
    }

    public int ProblemsSolved
    {
        get
        {
            if (this.problemsSolved < MinProblemsSolved)
            {
                return MinProblemsSolved;
            }
            else if (this.problemsSolved > MaxProblemsSolved)
            {
                return MaxProblemsSolved;
            }
            else
            {
                return this.problemsSolved;
            }
        }

        private set
        {
            this.problemsSolved = value;
        }
    }

    public override ExamResult Check()
    {
        string comment = string.Empty;

        if (this.ProblemsSolved == LowNumberOfProblemsSolwed)
        {
           comment =  "Bad result";
        }
        else if (this.ProblemsSolved == AverageNumberOfProblemsSolwed)
        {
            comment = "Average result";
        }
        else if(this.ProblemsSolved == GoodNumberOfProblemsSolwed)
        {
            comment = "Good result";
        }
        else
        {
            comment = "Excellent result";
        }

        return new ExamResult(this.ProblemsSolved, MinProblemsSolved, MaxProblemsSolved, comment);
    }
}
