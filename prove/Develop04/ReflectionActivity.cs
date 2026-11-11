using System;

class ReflectionActivity : ActivityBase
{
    AnimationsAndTiming _delayTiming = new AnimationsAndTiming();
    private string _reflectionName = "Reflection Activity";
    private string _reflectionMessage = "reflect on times when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life";
    private List<string> _thoughtPrompt = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private List<string> _reflectPrompt = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };
    public void RunReflectionActivity()
    {
        int _duration = StartActivity(_reflectionName, _reflectionMessage);
        AskPrompts(_duration);
        ClosingMessage(_reflectionName, _duration);
    }
    

    private void AskPrompts(int _duration)
    {
        Console.Clear();
        Console.WriteLine("Consider the following Prompt:");
        Console.WriteLine($"---{RandomListItem(_thoughtPrompt)}---");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begein in: ");
        _delayTiming.FiveSecondTimer();
        Console.WriteLine();
        for (int i = 0; i < _duration; i = i + 10)
        {
            Console.WriteLine($"> {RandomListItem(_reflectPrompt)} ");
            _delayTiming.TenSecondTimer();
        }
    }
}