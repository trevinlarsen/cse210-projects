public class Fraction
{
    private int numerator;
    private int denominator;

    // Constructor with no parameters (defaults to 1/1)
    public Fraction()
    {
        numerator = 1;
        denominator = 1;
    }

    // Constructor with one parameter (sets denominator to 1)
    public Fraction(int numerator)
    {
        this.numerator = numerator;
        this.denominator = 1;
    }

    // Constructor with two parameters (sets both numerator and denominator)
    public Fraction(int numerator, int denominator)
    {
        this.numerator = numerator;
        this.denominator = denominator;
    }

    // Getter and Setter for Numerator
    public int GetNumerator() => numerator;
    public void SetNumerator(int value) => numerator = value;

    // Getter and Setter for Denominator
    public int GetDenominator() => denominator;
    public void SetDenominator(int value) => denominator = value;

    // Method to return the fraction as a string (e.g. 3/4)
    public string GetFractionString()
    {
        return $"{numerator}/{denominator}";
    }

    // Method to return the decimal value of the fraction (e.g. 0.75)
    public double GetDecimalValue()
    {
        return (double)numerator / denominator;
    }
}
