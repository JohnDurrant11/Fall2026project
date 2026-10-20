

class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;

        //Console.WriteLine($"{_top}/{_bottom}");
    }

    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;

        Console.WriteLine($"{_top}/{_bottom}");
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;

        Console.WriteLine($"{_top}/{_bottom}");
    }

    public void SetNumerator(int top)
    {
        _top = top;
    }

    public int GetNumerator()
    {
        return _top;
    }    

    public void SetDenomerator(int bottom)
    {
        _bottom = bottom;
    }

    public int GetDenomerator()
    {
        return _bottom;
    }

    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    public double GetDecimalValue()
    {
        return (double)_top/_bottom;
    }
}