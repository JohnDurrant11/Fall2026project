using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        String grade_input = Console.ReadLine();
        int  grade_Percentage = int.Parse(grade_input);
        String grade_Letter;
        String pass_Status;

        if (grade_Percentage >= 90)
            {
                grade_Letter = "A";
            }
            else if (grade_Percentage >= 80)
            {
                grade_Letter = "B";
            }
            else if (grade_Percentage >= 70)
            {
                grade_Letter = "C";
            }
            else if (grade_Percentage >= 60)
            {
                grade_Letter = "D";
            }
            else
            {
                grade_Letter = "F";
            }

        if (grade_Percentage >= 70)
        {
            pass_Status = "Congragulations on passing!";
        }
        else
        {
            pass_Status = "Try again next time.";
        }

        Console.WriteLine($"{grade_Letter} {pass_Status}");
    }
}