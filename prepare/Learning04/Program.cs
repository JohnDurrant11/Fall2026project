using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Samuel Bennet", "Multiplication");
        assignment.GetSummary();

        MathAssignment math = new MathAssignment("Roberto Rodriguez", "Fractions", "Section 7.3", "Problems 8-19");
        math.GetSummary();
        math.GetHomeworkList();

        WritingAssignment writing = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        writing.GetSummary();
        writing.GetWritingInformation();
    }
}