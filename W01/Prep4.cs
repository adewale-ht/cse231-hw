
using System;
using System.Collections.Generic;
class Prep4 {
    static void Main() {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter 5 numbers:");
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int num;
        do {
            Console.Write("Enter number: ");
            num = int.Parse(Console.ReadLine());
            if (num != 0) numbers.Add(num);
        } while (num != 0);

        Console.WriteLine($"The sum is: {numbers.Sum()}");
        Console.WriteLine($"The average is: {(numbers.Count > 0 ? numbers.Average() : 0)}");
        Console.WriteLine($"The largest number is: {numbers.Max()}");

        // Stretch: smallest positive
        int smallestPositive = int.MaxValue;
        foreach (int n in numbers) {
            if (n > 0 && n < smallestPositive) smallestPositive = n;
        }
        if (smallestPositive != int.MaxValue)
            Console.WriteLine($"The smallest positive number is: {smallestPositive}");

        // Stretch: sorted list
        numbers.Sort();
        Console.WriteLine("The sorted list is:");
        foreach (int n in numbers) Console.WriteLine(n);
    }
}
