using System;
using Timer = System.Timers.Timer;

class Program
{
    static int remainingTime;
    static int elapsedTime;
    static Timer? timer;

    static void Main()
    {
        Console.Write("Enter number of seconds: ");
        remainingTime = int.Parse(Console.ReadLine() ?? "0");
        elapsedTime = 0;
        timer = new Timer(1000);
        timer.Elapsed += Timer_Elapsed;
        timer.Start();
        Console.ReadLine();
    }

    static void Timer_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
    {
        elapsedTime++;
        if (remainingTime > 0)
        {
            Console.WriteLine($"Time left: {remainingTime--} seconds, Elapsed time: {elapsedTime} seconds");
        }
        else
        {
            Console.WriteLine($"Time's up! Total elapsed time: {elapsedTime} seconds");
            timer?.Stop();
        }
    }
}
