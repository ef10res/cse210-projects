using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

public class PromptGenerator
{
    public static List<string> _prompts = new List<string>()
    {
        "What is something you can reflect on today?",
        "What do you wish you could have done differently today?",
        "Who taught you a new lesson today and what was it?",
        "What is a thought for future generations?",
        "Did you receive any impressions you would like to talk about?"
    };

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int random = rand.Next(0,5);

        string prompt = _prompts[random];

        return prompt;
    }
}