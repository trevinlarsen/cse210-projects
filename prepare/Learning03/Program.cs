using System;

class Program
{
    static void Main(string[] args)
    {
        
        Fraction fraction1 = new Fraction(1); 
        Fraction fraction2 = new Fraction(5); 
        Fraction fraction3 = new Fraction(6,7 ); 

        
        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction1.GetDecimalValue());
        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction2.GetDecimalValue());
        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(fraction3.GetDecimalValue());

        
        fraction3.SetNumerator(3);
        fraction3.SetDenominator(4);

        
        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(fraction3.GetDecimalValue());
    }
}
