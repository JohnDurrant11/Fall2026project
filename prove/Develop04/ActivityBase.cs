using System;

class ActivityBase
{
    Random _random = new Random();

    AnimationsAndTiming _delayTiming = new AnimationsAndTiming();

    protected int StartActivity(string _activityName, string _activityDescription)
    {
        OpeningMessage(_activityName, _activityDescription);
        int _duration = ActivityDuration();
        PrepareMessage();
        return _duration;
    }
    private void OpeningMessage(string _activityName, string _activityDescription)
    {
        Console.WriteLine($"Welcome to the {_activityName}.");
        Console.WriteLine();
        Console.WriteLine($"This activity will help you {_activityDescription}.");
        Console.WriteLine();
        Console.WriteLine("How long, in seconds, would you like your session? ");
    }

    private int ActivityDuration()
    {
        string _enteredTime = Console.ReadLine();
        if (int.TryParse(_enteredTime, out int _activityDuration))
        {
           return _activityDuration;
        }
        return -1;
    }

    private void PrepareMessage()
    {
        Console.Clear();
        Console.WriteLine("Get Ready.");
        for (int i = 3; i > 0; i--)
        {
            _delayTiming.LoadingAnimation();
        }
    }

    protected void ClosingMessage(string _activityName, int _activityDuration)
    {
        Console.Clear();
        Console.WriteLine("Well done!");
        _delayTiming.LoadingAnimation();
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_activityDuration} seconds of the {_activityName}.");
        for (int i = 2; i > 0; i--)
        {
            _delayTiming.LoadingAnimation();
        }

        
    }
    protected string RandomListItem(List<string> _list)
    {
        if (_list == null || _list.Count == 0)
        {
            return string.Empty;
        }
        int _index = _random.Next(_list.Count);
        return _list[_index];
    }
}