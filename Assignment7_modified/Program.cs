using System;

class TicTacToe
{
    static void Main()
    {
        Console.WriteLine("Welcome to Tic-Tac-Toe!");
        Game game = new Game();
        game.Play();
    }
}

class Game
{
    private char[,] board;
    private char currentPlayer;

    public Game()
    {
        board = new char[3, 3];
        InitializeBoard();
        currentPlayer = 'X'; // Player X always starts
    }

    private void InitializeBoard()
    {
        for (int i = 0; i < 3; i++)
            for (int j = 0; j < 3; j++)
                board[i, j] = ' ';
    }

    public void Play()
    {
        while (true)
        {
            PrintBoard();
            Console.WriteLine($"\nPlayer {currentPlayer}, it's your turn!");
            Console.Write("Enter your move (row and column, e.g., 1 2): ");
            
            int row, col;
            string input = Console.ReadLine();
            while (!IsValidMove(input, out row, out col))
            {
                Console.Write("Invalid move. Try again: ");
                input = Console.ReadLine();
            }
            board[row, col] = currentPlayer;

            if (CheckWin(currentPlayer))
            {
                PrintBoard();
                Console.WriteLine($"\n🎉 Player {currentPlayer} wins! 🎉");
                break;
            }

            if (IsBoardFull())
            {
                PrintBoard();
                Console.WriteLine("\n🤝 It's a draw! 🤝");
                break;
            }

            SwitchPlayer();
        }
    }

    private bool IsValidMove(string input, out int row, out int col)
    {
        row = col = -1;
        string[] parts = input.Split();
        return parts.Length == 2 &&
               int.TryParse(parts[0], out row) &&
               int.TryParse(parts[1], out col) &&
               row >= 0 && row < 3 && col >= 0 && col < 3 &&
               board[row, col] == ' ';
    }

    private bool CheckWin(char symbol)
    {
        for (int i = 0; i < 3; i++)
            if ((board[i, 0] == symbol && board[i, 1] == symbol && board[i, 2] == symbol) ||
                (board[0, i] == symbol && board[1, i] == symbol && board[2, i] == symbol))
                return true;

        return (board[0, 0] == symbol && board[1, 1] == symbol && board[2, 2] == symbol) ||
               (board[0, 2] == symbol && board[1, 1] == symbol && board[2, 0] == symbol);
    }

    private bool IsBoardFull()
    {
        foreach (char cell in board)
            if (cell == ' ') return false;
        return true;
    }

    private void SwitchPlayer()
    {
        currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
    }

    private void PrintBoard()
    {
        Console.WriteLine("\n  0   1   2");
        for (int i = 0; i < 3; i++)
        {
            Console.Write(i + " ");
            for (int j = 0; j < 3; j++)
            {
                Console.Write(board[i, j]);
                if (j < 2) Console.Write(" | ");
            }
            Console.WriteLine();
            if (i < 2) Console.WriteLine("  ---------");
        }
    }
}
