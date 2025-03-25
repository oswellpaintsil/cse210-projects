public class Fractions
{
    private double _top;
    private double _bottom;

    public Fractions()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fractions(double top)
    {
        _top = top;
        _bottom = 1;
    }

    public Fractions(double top, double bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public double GetTop()
    {
        return _top;
    }

    public void SetTop(double top)
    {
        _top = top;
    }

    public double GetBottom()
    {
        return _bottom;
    }

    public void SetBottom(double bottom)
    {
        _bottom = bottom;
    }

    public string GetFractionString()
    {
        string fraction = $"{_top}/{_bottom}";
        return fraction;
    }

    public double GetDecimalValue()
    {
        double value = _top/_bottom;
        return value;
    }


}