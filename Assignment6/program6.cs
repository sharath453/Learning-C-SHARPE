using System;

class Program
{
    static string DetermineTriangleType(int a, int b, int c)
    {
        if (a == b && b == c)
            return "Equilateral Triangle";
        else if (a == b || b == c || a == c)
            return "Isosceles Triangle";
        else
            return "Scalene Triangle";
    }

    static void Main()
    {
        Console.Write("Enter side 1: ");
        int side1 = int.Parse(Console.ReadLine());

        Console.Write("Enter side 2: ");
        int side2 = int.Parse(Console.ReadLine());

        Console.Write("Enter side 3: ");
        int side3 = int.Parse(Console.ReadLine());

        if (side1 + side2 > side3 && side2 + side3 > side1 && side1 + side3 > side2)
        {
            string result = DetermineTriangleType(side1, side2, side3);
            Console.WriteLine("Triangle Type: " + result);
        }
        else
        {
            Console.WriteLine("Invalid triangle! The sum of any two sides must be greater than the third side.");
        }
    }
}
