
using System;
class Prep5 {
    static int Square(int x) {
        return x * x;
    }
    static void Main() {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine($"Square: {Square(num)}");
    }
}
