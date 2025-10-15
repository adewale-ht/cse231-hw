using System;

// Creativity: This program exceeds requirements by allowing the user to "level up" every 1000 points and displaying a badge.
// You can also add your own custom goal types by extending the Goal base class.

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        string filename = "goals.txt";
        manager.Load(filename);

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Eternal Quest Program");
            Console.WriteLine($"Score: {manager.Score}");
            Console.WriteLine($"Level: {manager.Score / 1000 + 1} {(manager.Score >= 1000 ? "🏅" : "")}");
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. List Goals");
            Console.WriteLine("2. Create New Goal");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Quit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                manager.DisplayGoals();
                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();
            }
            else if (choice == "2")
            {
                Console.WriteLine("Select goal type:");
                Console.WriteLine("1. Simple Goal");
                Console.WriteLine("2. Eternal Goal");
                Console.WriteLine("3. Checklist Goal");
                Console.Write("Type: ");
                string type = Console.ReadLine();
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Description: ");
                string desc = Console.ReadLine();
                Console.Write("Points: ");
                int points = int.Parse(Console.ReadLine());

                if (type == "1")
                {
                    manager.AddGoal(new SimpleGoal(name, desc, points));
                }
                else if (type == "2")
                {
                    manager.AddGoal(new EternalGoal(name, desc, points));
                }
                else if (type == "3")
                {
                    Console.Write("Target count: ");
                    int target = int.Parse(Console.ReadLine());
                    Console.Write("Bonus points: ");
                    int bonus = int.Parse(Console.ReadLine());
                    manager.AddGoal(new ChecklistGoal(name, desc, points, target, bonus));
                }
            }
            else if (choice == "3")
            {
                manager.DisplayGoals();
                Console.Write("Which goal did you accomplish? (number): ");
                if (int.TryParse(Console.ReadLine(), out int idx))
                {
                    manager.RecordEvent(idx - 1);
                }
                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();
            }
            else if (choice == "4")
            {
                manager.Save(filename);
                Console.WriteLine("Goals saved.");
                Console.ReadLine();
            }
            else if (choice == "5")
            {
                manager.Load(filename);
                Console.WriteLine("Goals loaded.");
                Console.ReadLine();
            }
            else if (choice == "6")
            {
                manager.Save(filename);
                Console.WriteLine("Goodbye!");
                break;
            }
        }
    }
}