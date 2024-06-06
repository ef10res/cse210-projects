using System;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        DateTime date = DateTime.Now;
        string stringDate = date.ToString();
        Entry entry = new Entry();
        Journal journal = new Journal();
        

        Console.WriteLine("1.Write");
        Console.WriteLine("2.Display");
        Console.WriteLine("3.Load");
        Console.WriteLine("4.Save");
        Console.WriteLine("5.Quit");
        Console.Write("What would you like to do?");

        int choice = int.Parse(Console.ReadLine());
        
        PromptGenerator promptGenerator = new PromptGenerator();
        while (choice != 5)
        {

            if (choice == 1)
            {
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine(prompt);
                stringDate = date.ToString();
                entry._prompt = prompt;
                entry._entry = Console.ReadLine();
                journal._entries.Add(entry);
            }

            else if (choice == 2)
            {
                entry._date = stringDate;
                foreach (Entry line in journal._entries)
                {
                    Console.WriteLine($"{line._date}, {line._prompt}, {line._entry}");
                }
            }

            else if (choice == 3)
            {
                journal.LoadFromFile();
            }

            else if (choice == 4)
            {
                Console.WriteLine("What is the name of the file?");
                string fileName = Console.ReadLine();
                journal.SaveToFile(fileName, journal._entries);
            }

            else 
            {
                choice = 0;
            }

            Console.WriteLine("1.Write");
            Console.WriteLine("2.Display");
            Console.WriteLine("3.Load");
            Console.WriteLine("4.Save");
            Console.WriteLine("5.Quit");
            Console.WriteLine("What would you like to do?");
            choice = int.Parse(Console.ReadLine());
        }
    }
}