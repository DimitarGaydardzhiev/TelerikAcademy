using System;

public class CSharpExam : Exam
{
    private const int MinGrade = 0;
    private const int MaxGrade = 100;
    private int score;

    public CSharpExam(int score)
    {
        this.Score = score;
    }

    public int Score
    {
        get
        {
            return this.score;
        }

        private set
        {
            if (value < CSharpExam.MinGrade || value > CSharpExam.MaxGrade)
            {
                throw new ArgumentException(string.Format(GlobalErrorMessages.ValueCannotBeOutOfThePredifinedRange, "Score", CSharpExam.MinGrade, CSharpExam.MaxGrade));
            }

            this.score = value;
        }
    }

    public override ExamResult Check()
    {
        if (this.Score < CSharpExam.MinGrade || this.Score > CSharpExam.MaxGrade)
        {
            throw new InvalidOperationException(string.Format(GlobalErrorMessages.ValueCannotBeOutOfThePredifinedRange, "Score", CSharpExam.MinGrade, CSharpExam.MaxGrade));
        }
        else
        {
            return new ExamResult(this.Score, 0, 100, "Exam results calculated by score.");
        }
    }
}
