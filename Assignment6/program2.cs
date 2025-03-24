using System;

class Program
{
    static void CountDV(string input, ref int amountOfDigits, ref int amountOfVowels)
    {
        amountOfDigits = 0;
        amountOfVowels = 0;
        string vowels = "aeiouAEIOU";
        
        for (int i = 0; i < input.Length; i++)
        {
            if (char.IsDigit(input[i])) amountOfDigits++;
            if (vowels.Contains(input[i])) amountOfVowels++;
        }
    }

    static void Main()
    {
        Console.Write("Enter a text string: ");
        string text = Console.ReadLine();
        int amountOfDigits = 0, amountOfVowels = 0;
        
        CountDV(text, ref amountOfDigits, ref amountOfVowels);
        
        Console.WriteLine($"Digits: {amountOfDigits}, Vowels: {amountOfVowels}");
    }
}
