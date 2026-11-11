using System;

class Menu
{
    private bool _quit = false;
    AnimationsAndTiming _delayTiming = new AnimationsAndTiming();
    public void StartProgram()
    {
        Console.Clear();
        Console.WriteLine("Welcome to the mindfulness program.");
        while (_quit != true)
        {
            MenuOptions();
            ActivityNavigation(CheckUserChoice());
        }

    }

    private void MenuOptions()
    {
        Console.Clear();
        Console.WriteLine("Menu Options: ");
        Console.WriteLine("1. Start breathing activity");
        Console.WriteLine("2. Start reflection activity");
        Console.WriteLine("3. Start listing activity");
        Console.WriteLine("4. Quit");
    }

    private int CheckUserChoice()
    {
        Console.Write("Select a choice from the menu: ");
        string _userChoice = Console.ReadLine();
        Console.Clear();
        _delayTiming.LoadingAnimation();
        Console.Clear();
        if (int.TryParse(_userChoice, out int _menuChoice))
        {
           return _menuChoice; 
        }
        return -1;
    }

    private void ActivityNavigation(int _selection)
    {
        if (_selection == 1)
        {
            BreathingActivity _breath = new BreathingActivity();
            _breath.RunBreathingActivity();
        }
        else if (_selection == 2)
        {
            ReflectionActivity _reflection = new ReflectionActivity();
            _reflection.RunReflectionActivity();
        }
        else if (_selection == 3)
        {
            EnumerationActivity _enumerate = new EnumerationActivity();
            _enumerate.RunEnumerationActivity();
        }
        else if (_selection == 4)
        {
            Console.Clear();
            Console.WriteLine("Thank you for using the mindfulness program today.");
            _quit = true;
            
            
        }
        else
        {
            Console.WriteLine("That is not a valid input. Please enter a valid choice.");
            _delayTiming.LoadingAnimation();
        }
    }
}