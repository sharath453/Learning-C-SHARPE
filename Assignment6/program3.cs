using System;

class Program
{
    static void DistributeApples(int T, int N)
    {
        int equalShare = T / N;
        int remaining = T % N;
        
        Console.WriteLine("Each kid gets: " + equalShare + " apples");
        Console.WriteLine("Remaining apples distributed to youngest: " + remaining);
    }

    static void Main()
    {
        Console.Write("Enter total apples (T): ");
        int T = int.Parse(Console.ReadLine());
        Console.Write("Enter number of kids (N): ");
        int N = int.Parse(Console.ReadLine());
        
        DistributeApples(T, N);
    }
}
