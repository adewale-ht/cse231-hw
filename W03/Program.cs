// W03 Project: Scripture Memorizer Program
// Creativity: You can choose from a library of scriptures at the start.
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Library of scriptures
        List<Scripture> scriptures = new List<Scripture>
        {
            new Scripture(new Reference("John", 3, 16), "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."),
            new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."),
            new Scripture(new Reference("Psalm", 23, 1), "The Lord is my shepherd; I shall not want."),
        };

        Console.WriteLine("Choose a scripture to memorize:");
        for (int i = 0; i < scriptures.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {scriptures[i].GetDisplayText().Split('\n')[0]}");
        }
        Console.Write("Enter number: ");
        int choice = int.Parse(Console.ReadLine());
        Scripture scripture = scriptures[choice - 1];

        Console.Clear();
        while (true)
        {
            Console.WriteLine(scripture.GetDisplayText());
            if (scripture.AllWordsHidden())
            {
                Console.WriteLine("\nAll words are hidden. Good job!");
                break;
            }
            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit.");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit") break;
            Console.Clear();
            scripture.HideRandomWords(3);
        }
    }
}
