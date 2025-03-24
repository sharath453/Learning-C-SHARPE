using System;

class Program
{
    static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    static void Main()
    {
        Console.Write("Enter first number: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int num2 = int.Parse(Console.ReadLine());

        Console.WriteLine($"\nBefore Swap: num1 = {num1}, num2 = {num2}");

        Swap(ref num1, ref num2);

        Console.WriteLine($"After Swap: num1 = {num1}, num2 = {num2}");
    }
}
