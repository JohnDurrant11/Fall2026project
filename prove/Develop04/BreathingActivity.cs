using System;

class BreathingActivity : ActivityBase
{
    AnimationsAndTiming _delayTiming = new AnimationsAndTiming();
    private string _breathingName = "Breathing Activity";
    private string _breathingMessage = "relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing";

    public void RunBreathingActivity()
    {
        int _duration = StartActivity(_breathingName, _breathingMessage);
        BreathDuration(_duration);
        ClosingMessage(_breathingName, _duration);
    }
    private void Breath()
    {
        Console.Clear();
        Console.WriteLine("Breath in.");
        _delayTiming.FiveSecondTimer();
        Console.Clear();
        Console.WriteLine("Breath out.");
        _delayTiming.FiveSecondTimer();
    }

    private void BreathDuration(int _duration)
    {
        int _durationCheck = 0;
        while (_durationCheck < _duration)
        {
            _durationCheck = _durationCheck + 10;
            Breath();
        }
    }

}