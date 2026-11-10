using System;
using System.Drawing;

class MathAssignment : Assignment
{
    private string _textBookSection;
    private string _problems;

    public MathAssignment(string name, string topic, string textBookSection, string problems) : base(name, topic)
    {
        _textBookSection = textBookSection;
        _problems = problems;
    }

    public void GetHomeworkList()
    {
        Console.WriteLine($"{_textBookSection} {_problems}");
    }
}