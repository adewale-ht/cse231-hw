// W03 Project: Scripture Memorizer Program
// Creativity: You can choose from a library of scriptures at the start.
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Multiple scripture options
        var scriptures = new[]
        {
            new { Reference = new Reference("John", 3, 16), Text = "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life." },
            new { Reference = new Reference("Proverbs", 3, 5, 6), Text = "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight." },
            new { Reference = new Reference("Philippians", 4, 13), Text = "I can do all things through Christ which strengtheneth me." }
        };

        Console.WriteLine("Choose a scripture to memorize:");
        for (int i = 0; i < scriptures.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {scriptures[i].Reference}");
        }
        Console.Write("Enter number: ");
        int choice = int.Parse(Console.ReadLine());
        var selected = scriptures[Math.Clamp(choice - 1, 0, scriptures.Length - 1)];

        Scripture scripture = new Scripture(selected.Reference, selected.Text);

        int round = 0;
        while (true)
        {
            scripture.Display();
            if (scripture.AllWordsHidden())
            {
                Console.WriteLine($"Congratulations! You memorized the scripture in {round} rounds.");
                break;
            }
            Console.WriteLine("Press Enter to hide more words or type 'quit' to finish.");
            string input = Console.ReadLine();
            if (input.Trim().ToLower() == "quit")
            {
                Console.WriteLine("Goodbye!");
                break;
            }
            scripture.HideRandomWords(3); // Hide 3 words per round
            round++;
        }
    }
}
