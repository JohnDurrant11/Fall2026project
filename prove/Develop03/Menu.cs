using System;
using System.Diagnostics;

class Menu
{

    public void MenuRun()
    {
        Console.WriteLine("Welcome to the Scripture Memorization tool.");
        bool quit = false;
        while (quit != true)
        {
            int choice = MenuOptions();

            if (choice == 1)
            {
                AddScripture();
                Console.WriteLine("Thank you for adding to the Scripture memorization tool!");
            }
            else if (choice == 2)
            {
                Console.Clear();
                Reference DisplayReferences = new Reference();
                Scripture DisplayScirpture = new Scripture();
                int userChoice = DisplayReferences.DisplayReferences();
                DisplayScirpture.runScriptureGame(userChoice);
            }
            else if (choice == 3)
            {
                quit = true;
                Console.Clear();
                Console.WriteLine("Thank you for using the Scripture memorization tool! Have a great day!");
            }
            else
            {
                Console.WriteLine("That is not a valid input. Please enter a valid choice.");
            }
        }
    }

    private int MenuOptions()
    {
        Console.WriteLine("Please enter the number for your choice.");
        Console.WriteLine("1, Input scripture into list.");
        Console.WriteLine("2, Select scripture to memorize.");
        Console.WriteLine("3, Quit the program.");
        Console.Write("~ ");

        string userInput = Console.ReadLine();

        if (int.TryParse(userInput, out int menuChoice))
        {
           return menuChoice; 
        }
        return -1;
    }

    private void AddScripture()
    {
        Reference newReference = new Reference();
        newReference.NewScriptureReference();
    }

    private void MemorizeScripture()
    {
        
    }


}