using System;
using System.IO;
using System.Collections.Generic;

class Player
{
    public string Name { get; }
    private int _rank;

    // Event triggered when rank changes
    public event Action<string, int> RankChanged;

    public Player(string name, int rank)
    {
        Name = name;
        _rank = rank;
    }

    public int Rank
    {
        get { return _rank; }
        set
        {
            if (_rank != value) // Check if rank actually changed
            {
                _rank = value;
                RankChanged?.Invoke(Name, _rank); // Trigger event
            }
        }
    }
}

class RankTracker
{
    private const string logFile = "rank_log.txt";

    public void OnRankChanged(string playerName, int newRank)
    {
        // Log to console
        Console.WriteLine($"Player {playerName}'s rank changed to {newRank}");

        // Special message for 1st rank
        if (newRank == 1)
        {
            Console.WriteLine($"🎉 Player {playerName} secured 1st rank! 🎉");
        }

        // Log to file
        File.AppendAllText(logFile, $"{playerName}, {newRank}{Environment.NewLine}");
    }
}

class Program
{
    static void Main()
    {
        RankTracker tracker = new RankTracker();
        List<Player> players = new List<Player>();

        while (true)
        {
            Console.WriteLine("\nSelect an action:");
            Console.WriteLine("1. Add Player");
            Console.WriteLine("2. Update Rank");
            Console.WriteLine("3. Exit");
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter player name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter initial rank: ");
                    int rank = int.Parse(Console.ReadLine());

                    Player newPlayer = new Player(name, rank);
                    newPlayer.RankChanged += tracker.OnRankChanged;
                    players.Add(newPlayer);
                    Console.WriteLine($"{name} added with rank {rank}.");
                    break;

                case "2":
                    Console.Write("Enter player name: ");
                    string playerName = Console.ReadLine();
                    Player player = players.Find(p => p.Name == playerName);

                    if (player != null)
                    {
                        Console.Write("Enter new rank: ");
                        int newRank = int.Parse(Console.ReadLine());
                        player.Rank = newRank;
                    }
                    else
                    {
                        Console.WriteLine("Player not found.");
                    }
                    break;

                case "3":
                    Console.WriteLine("Exiting program...");
                    return;

                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }
}
