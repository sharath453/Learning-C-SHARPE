using System;
using System.Linq;

class Program
{
    static void ProcessNumbers(int[] numbers)
    {
        int totalSum = numbers.Sum();
        int index42 = Array.IndexOf(numbers, 42);
        int index24 = Array.IndexOf(numbers, 24);
        int oddIndexSum = numbers.Where((num, index) => index % 2 != 0).Sum();
        int evenIndexSum = numbers.Where((num, index) => index % 2 == 0).Sum();

        Console.WriteLine("Total Sum: " + totalSum);
        Console.WriteLine("Index of 42: " + (index42 != -1 ? index42.ToString() : "Not Found"));
        Console.WriteLine("Index of 24: " + (index24 != -1 ? index24.ToString() : "Not Found"));
        Console.WriteLine("Sum of numbers at odd indices: " + oddIndexSum);
        Console.WriteLine("Sum of numbers at even indices: " + evenIndexSum);
    }

    static void Main()
    {
        int[] numbers = new int[20];

        Console.WriteLine("Enter 20 numbers:");
        for (int i = 0; i < 20; i++)
        {
            Console.Write($"Number {i + 1}: ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        ProcessNumbers(numbers);
    }
}
