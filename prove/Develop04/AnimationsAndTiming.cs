using System;

class AnimationsAndTiming
{
    public void LoadingAnimation()
    {
        Console.Write(".");
        Thread.Sleep(600);
        Console.Write(".");
        Thread.Sleep(600);
        Console.Write(".");
        Thread.Sleep(600);
        Console.Write("\b \b\b \b\b \b");
    }

    public void FiveSecondTimer()
    {
        for (int i = 5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
    public void TenSecondTimer()
    {
        for (int i = 10; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b\b \b");
        }
    }
    private DateTime _endTime;

    public void StartTimer(int durationInSeconds)
    {
        _endTime =  DateTime.Now.AddSeconds(durationInSeconds);
    }

    public bool IsTimeRemaining()
    {
        return DateTime.Now < _endTime;
    }

}
