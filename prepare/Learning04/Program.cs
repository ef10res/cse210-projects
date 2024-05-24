using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment math = new MathAssignment("Erick Flores", "Fractions", "7.4", "1-10");
        Console.WriteLine(math.GetSummary());
        Console.WriteLine(math.GetHomeWorkList());

        WritingAssignment writing = new WritingAssignment("Erick Flores", "Ancient History", "3000 B.C.");
        Console.WriteLine(writing.GetSummary());
        Console.WriteLine(writing.GetWritingInformation());
    }
}