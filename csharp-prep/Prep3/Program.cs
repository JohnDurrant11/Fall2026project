using System;

class Program
{
    static void Main(string[] args)
    {
        int guessed_It = 0;
        
        Random randomGenerator = new Random();
        int magic_Number = randomGenerator.Next(1,100);

        /*
        Console.Write("What is the magic number? ");
        string user_Input = Console.ReadLine();
        int magic_Number = int.Parse(user_Input);
        */

        while (guessed_It != 1)
        {

            Console.Write("What is your guess? ");
            string user_Guess = Console.ReadLine();
            int number_Guess = int.Parse(user_Guess);

            if (number_Guess > magic_Number)
            {
                Console.WriteLine("Lower.");
         }
            else if (number_Guess < magic_Number)
            {
                Console.WriteLine("Higher.");
            }
            else
            {
                Console.WriteLine("You guessed it!");
                guessed_It = 1;
            }
        }
    }
}