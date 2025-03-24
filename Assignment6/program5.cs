using System;

class Program
{
    static void CalculateFactorial(int n, ref long result)
    {
        result = 1;
        for (int i = 1; i <= n; i++)
        {
            result *= i;
        }
    }

    static void GetBinomialCoefficient(int n, int k, out long coefficient)
    {
        long factN = 1, factK = 1, factNK = 1;

        CalculateFactorial(n, ref factN);
        CalculateFactorial(k, ref factK);
        CalculateFactorial(n - k, ref factNK);

        coefficient = factN / (factK * factNK);
    }

    static void PrintPascalsTriangle(int rows)
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                long value;
                GetBinomialCoefficient(i, j, out value);
                Console.Write(value + " ");
            }
            Console.WriteLine();
        }
    }

    static void Main()
    {
        Console.Write("Enter number of rows for Pascal's Triangle: ");
        int rows = int.Parse(Console.ReadLine());

        Console.WriteLine("Pascal's Triangle:");
        PrintPascalsTriangle(rows);
    }
}
