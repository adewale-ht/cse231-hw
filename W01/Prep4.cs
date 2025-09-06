
using System;
using System.Collections.Generic;
class Prep4 {
    static void Main() {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter 5 numbers:");
        for (int i = 0; i < 5; i++) {
            numbers.Add(int.Parse(Console.ReadLine()));
        }
        Console.WriteLine($"Max: {numbers.Max()}, Min: {numbers.Min()}");
    }
}
