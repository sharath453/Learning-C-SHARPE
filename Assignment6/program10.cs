using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        string inputFile = "C:\\Users\\Sharath A L\\Downloads\\file.txt";
        string outputFile = "C:\\Users\\Sharath A L\\Downloads\\names2.txt";

        if (!File.Exists(inputFile))
        {
            Console.WriteLine("Error: Input file not found.");
            return;
        }

        string[] names = File.ReadAllLines(inputFile);
        
        foreach (var name in names)
        {
            int kFactor = CalculateKFactor(name);
            Console.WriteLine($"Name: {name}, K-Factor: {kFactor}, Prime: {IsPrime(kFactor)}");
        }

        var filteredNames = names.Where(name => IsPrime(CalculateKFactor(name))).ToArray();
        File.WriteAllLines(outputFile, filteredNames);

        Console.WriteLine("Filtered names with prime K-factor saved in 'names2.txt'.");
    }

    static int CalculateKFactor(string name)
    {
        int asciiSum = name.Sum(c => (int)c);
        return DigitalRoot(asciiSum);
    }

    static int DigitalRoot(int num)
    {
        while (num >= 10)
        {
            num = num.ToString().Sum(c => c - '0');
        }
        return num;
    }

    static bool IsPrime(int num)
    {
        if (num < 2) return false;
        for (int i = 2; i * i <= num; i++)
        {
            if (num % i == 0) return false;
        }
        return true;
    }
}
