using System;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());
        numbers.Add(number);

        while (number != 0)
        { 
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());
            if (number != 0)
            {
                numbers.Add(number);
            } 
        }
        int total = 0;  
        foreach (int integer in numbers)
        {
            total = total + integer;
        }
        float average = total / numbers.Count;

        int max = numbers[0];
        foreach (int integer in numbers)
        {
            if (integer > max)
            {
                max = integer;
            }
        }
        Console.WriteLine($"The sum is {total}");
        Console.WriteLine($"The average is {average}");
        Console.WriteLine($"The max is {max}");

    }
}