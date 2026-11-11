using System;

class EnumerationActivity : ActivityBase
{
    AnimationsAndTiming _delayTiming = new AnimationsAndTiming();

    private string _enumerationName = "Enumeration Activity";
    private string _enumerationMessage = "reflect on the good things in your life by having you list as many things as you can in a certain area";
    
    private List<string> _listPrompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "Who are people that you have helped this week?",
        "Who are some of your personal heroes?"
    };

    public void RunEnumerationActivity()
    {
        int _duration = StartActivity(_enumerationName, _enumerationMessage);
        DisplayPrompt();
        ContainList(_duration);
        ClosingMessage(_enumerationName, _duration);
    }

    private void DisplayPrompt()
    {
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($"---{RandomListItem(_listPrompts)}---");
        Console.WriteLine("You may begin in: ");
        _delayTiming.FiveSecondTimer();
    }

    private void ContainList(int duration)
    {
        List<string> _responses = new List<string>();
        _delayTiming.StartTimer(duration);

        while (_delayTiming.IsTimeRemaining())
        {
            Console.Write("> ");
            string input = Console.ReadLine();
            _responses.Add(input);
        }

        Console.WriteLine($"You listed {_responses.Count} items!");
        _delayTiming.LoadingAnimation();
    }
}