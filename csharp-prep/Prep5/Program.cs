using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayMessage()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static string PromptUserName()
        {
            Console.Write("What is your name: ");
            string user_Name = Console.ReadLine();
            return user_Name;
        }

        static int PromptUserNumber()
        {
            Console.Write("What is your favorite number: ");
            string number_Answer = Console.ReadLine();
            int user_Number = int.Parse(number_Answer);
            return user_Number;
        }

        static void PromptUserBirthYear(out int birth_Year)
        {
            Console.Write("What year were you born: ");
            string input = Console.ReadLine();
            birth_Year = int.Parse(input);
        }

        static int SquareNumber(int number)
        {
            int squared_Number = number * number;
            return squared_Number;
        }

        static void DisplayResult()
        {
            DisplayMessage();
            string user_Name = PromptUserName();
            int user_Number = PromptUserNumber();
            int birth_Year;
            PromptUserBirthYear(out birth_Year);
            int current_Year = DateTime.Now.Year;
            int age = current_Year - birth_Year;
            int squared_Number = SquareNumber(user_Number);
            Console.WriteLine($"{user_Name}, the square of your number is {squared_Number}.");
            Console.WriteLine($"{user_Name}, you will be {age} this year.");
        }

        DisplayResult();
    }
}