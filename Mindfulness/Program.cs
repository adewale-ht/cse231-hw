using System;

// Creativity: This program exceeds requirements by tracking the total number of activities completed in this session
// and displaying it at the end. (See the variable totalActivitiesCompleted.)

class Program
{
    static void Main(string[] args)
    {
        int totalActivitiesCompleted = 0;
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program\n");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start Breathing Activity");
            Console.WriteLine("  2. Start Reflection Activity");
            Console.WriteLine("  3. Start Listing Activity");
            Console.WriteLine("  4. Quit");
            Console.Write("\nSelect a choice from the menu: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity breathing = new BreathingActivity();
                breathing.Run();
                totalActivitiesCompleted++;
            }
            else if (choice == "2")
            {
                ReflectionActivity reflection = new ReflectionActivity();
                reflection.Run();
                totalActivitiesCompleted++;
            }
            else if (choice == "3")
            {
                ListingActivity listing = new ListingActivity();
                listing.Run();
                totalActivitiesCompleted++;
            }
            else if (choice == "4")
            {
                Console.WriteLine($"\nYou completed {totalActivitiesCompleted} mindfulness activities this session. Goodbye!");
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Press Enter to continue.");
                Console.ReadLine();
            }
        }
    }
}