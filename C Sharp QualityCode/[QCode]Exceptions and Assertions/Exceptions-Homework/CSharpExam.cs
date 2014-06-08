using System;

public class CSharpExam : Exam
{
    private const int MaxPoints = 100;
    private const int MinPoints = 0;
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

        set
        {
            if (MinPoints > value || value > MaxPoints)
            {
                throw new ArgumentException(string.Format("Score must be between {0} and {1}", MinPoints, MaxPoints));
            }

            this.score = value;
        }
    }

    public override ExamResult Check()
    {
        return new ExamResult(this.Score, MinPoints, MaxPoints, "Exam results calculated by score.");
    }
}
