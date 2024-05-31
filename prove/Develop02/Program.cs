using System;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("1.Write");
        Console.WriteLine("2.Display");
        Console.WriteLine("3.Load");
        Console.WriteLine("4.Save");
        Console.WriteLine("5.Quit");
        Console.Write("What would you like to do?");

        public int choice = int.Parse(Console.ReadLine());
        
        if (choice == 1)
        {
            Random rnd = new Random();
            int rndChoice = rnd.Next(0,5);
            Console.ReadLine(Entry._prompts[rndChoice]);
        }
    }
}