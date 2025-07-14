public class Fraction
{
    private int _top; // numerator for this
    private int _bottom; // denominator for this

    // Default constructor 
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    // Constructor for whole number
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    // Constructor for numerator and denominator
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // Get numerator
    public int GetTop()
    {
        return _top;
    }

    // Set numerator
    public void SetTop(int top)
    {
        _top = top;
    }

    // Get denominator
    public int GetBottom()
    {
        return _bottom;
    }

    // Set denominator
    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    // Return fraction as string
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    // Return decimal value of fraction
    public double GetDecimalValue()
    {
        return (double)_top / _bottom;
    }
}