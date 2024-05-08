
class ProgramFraction
{
    static void Main(string[] args)
    {
        Fraction _fraction = new Fraction();
        Console.WriteLine($"{_fraction.GetFractionString()}");
        Console.WriteLine($"{_fraction.GetDecimalValue()}");

        Fraction _fraction1 = new Fraction(5);
        Console.WriteLine(_fraction1.GetFractionString());
        Console.WriteLine(_fraction1.GetDecimalValue());

        Fraction _fraction2 = new Fraction(3,4);
        Console.WriteLine(_fraction2.GetFractionString());
        Console.WriteLine(_fraction2.GetDecimalValue());

        Fraction _fraction3 = new Fraction(1,3);
        Console.WriteLine(_fraction3.GetFractionString());
        Console.WriteLine(_fraction3.GetDecimalValue());
    }
}