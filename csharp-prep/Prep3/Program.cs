using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is the magic number? ");
        Random randomGenerator = new Random();
        int magic = randomGenerator.Next(1,101);

        //Console.Write("What is your guess? ");
        //int guess = int.Parse(Console.ReadLine());
        int guess = 0;
        do
        {
            Console.WriteLine("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            if (guess > magic)
            {
                Console.WriteLine("Lower");        
            }
            else if (guess < magic)
            {
                Console.WriteLine("Higher");
            }
        }   while (guess != magic);
        if (guess == magic)
        {
            Console.WriteLine("You guessed it! ");
        }
    }
}