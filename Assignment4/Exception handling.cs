using System;
class Program
{
    static void Main()
    {
        try
        {
            int a = 10, b = 0;
            int result = a / b;
            Console.WriteLine("Result: " + result);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Error: Cannot divide by zero! " + ex.Message);
        }

        try
        {
            Console.WriteLine("\nEnter a number:");
            int num = Convert.ToInt32(Console.ReadLine());
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Error: Invalid input format! " + ex.Message);
        }

        try
        {
            int[] numbers = { 10, 20, 30 };
            Console.WriteLine("\nAccessing element at index 5: " + numbers[5]);
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine("Error: Array index out of range! " + ex.Message);
        }

        try
        {
            string? str = null;
            Console.WriteLine("\nString Length: " + (str?.Length ?? 0));
        }
        catch (NullReferenceException ex)
        {
            Console.WriteLine("Error: Object reference is null! " + ex.Message);
        }

        try
        {
            Console.WriteLine("\nEnter an index (0-2) for the array:");
            int index = Convert.ToInt32(Console.ReadLine());
            int[] arr = { 1, 2, 3 };

            if (index < 0 || index >= arr.Length)
            {
                throw new ArgumentOutOfRangeException("index", "Index is out of valid range.");
            }

            Console.WriteLine("Array Element: " + arr[index]);
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }

        try
        {
            object obj = "Hello";
            int num = (int)obj;
        }
        catch (InvalidCastException ex)
        {
            Console.WriteLine("Error: Invalid type casting! " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Unexpected Error: " + ex.Message);
        }

        Console.WriteLine("\nExecution completed.");
    }
}
