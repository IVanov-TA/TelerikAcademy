using System;

public class SimpleMathExam : Exam
{
    private const int MaxNumberProblems = 10;
    private const int MinNumberProblems = 0;

    private int problemSolved;

    public SimpleMathExam(int problemsSolved)
    {
        this.ProblemsSolved = problemsSolved;
    }

    public int ProblemsSolved
    {
        get
        {
            return this.problemSolved;
        }

        set
        {
            if (MinNumberProblems > value || value > MaxNumberProblems)
            {
                throw new ArgumentException(string.Format(
                        "Invalid input! You should enter number in the interval [{0}, {1}] for solved problems.",
                        MinNumberProblems, 
                        MaxNumberProblems));
            }

            this.problemSolved = value;
        }
    }

    public override ExamResult Check()
    {
        if (this.ProblemsSolved == MinNumberProblems)
        {
            return new ExamResult(2, 2, 6, "Bad result: nothing done.");
        }
        else if (this.ProblemsSolved == 1)
        {
            return new ExamResult(4, 2, 6, "Average result: nothing done.");
        }
        else if (this.ProblemsSolved == 2)
        {
            return new ExamResult(6, 2, 6, "Average result: nothing done.");
        }

        throw new ArgumentOutOfRangeException("The number of solved problems is invalid!");
    }
}
