
using System;
class Prep5 {
    static int Square(int x) {
    static void DisplayWelcome() {
        Console.WriteLine("Welcome to the program!");
    }
    static string PromptUserName() {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }
    static int PromptUserNumber() {
        Console.Write("Please enter your favorite number: ");
        return int.Parse(Console.ReadLine());
    }
    static int SquareNumber(int x) {
        return x * x;
    }
    static void DisplayResult(string name, int squared) {
        Console.WriteLine($"{name}, the square of your number is {squared}");
    }
    }
    static void Main() {
    DisplayWelcome();
    string name = PromptUserName();
    int number = PromptUserNumber();
    int squared = SquareNumber(number);
    DisplayResult(name, squared);
    }
}
