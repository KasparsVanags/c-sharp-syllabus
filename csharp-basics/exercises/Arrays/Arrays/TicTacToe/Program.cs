using System;

namespace TicTacToe
{
    class Program
    {
        private static char[,] board = new char[3, 3];
        private static char turnOf = 'X';

        private static void Main(string[] args)
        {
            InitBoard();
        }

        private static void InitBoard()
        {
            for (var r = 0; r < 3; r++)
            {
                for (var c = 0; c < 3; c++)
                    board[r, c] = ' ';
            }

            turnOf = 'X';
            GetInput();
        }

        private static void GameOver()
        {
            DisplayBoard();
            Console.WriteLine(GetDraw() ? "It's a draw!" : $"{GetWinner()} won!");
            Console.WriteLine("Play again? y/n");
            var choice = char.ToLower(Console.ReadKey().KeyChar);
            if (choice == 'y')
            {
                Console.WriteLine();
                InitBoard();
            }
            else
            {
                Console.WriteLine("\nThank you for playing. Exiting...");
                Environment.Exit(0);
            }
        }

        private static bool IsGameOver()
        {
            return GetDraw() || GetWinner() != '-';
        }
        
        private static char GetWinner()
        {
            //check across
            if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2] && board[0, 0] != ' ')
            {
                return board[0, 0];
            }
            if (board[2, 0] == board[1, 1] && board[1, 1] == board[0, 2] && board[2, 0] != ' ')
            {
                return board[2, 0];
            }
            for (var i = 0; i < 3; i++)
            {
                //check columns
                if (board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2] && board[i, 0] != ' ')
                {
                    return board[i, 0];
                }
                //check rows
                if (board[0, i] == board[1, i] && board[1, i] == board[2, i] && board[0, i] != ' ')
                {
                    return board[0, i];
                }
            }

            return '-'; //no winner
        }

        private static bool GetDraw()
        {
            for (var i = 0; i < 3; i++)
            {
                for (var j = 0; j < 3; j++)
                {
                    if (board[i, j] == ' ')
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        private static void DisplayBoard()
        {
            Console.WriteLine("  0  " + board[0, 0] + "|" + board[0, 1] + "|" + board[0, 2]);
            Console.WriteLine("    --+-+--");
            Console.WriteLine("  1  " + board[1, 0] + "|" + board[1, 1] + "|" + board[1, 2]);
            Console.WriteLine("    --+-+--");
            Console.WriteLine("  2  " + board[2, 0] + "|" + board[2, 1] + "|" + board[2, 2]);
        }

        private static void GetInput()
        {
            if (IsGameOver())
            {
                GameOver();
                return;
            }
            
            DisplayBoard();
            Console.Write($"{turnOf}, choose your location (row, column): ");
            if (int.TryParse(Console.ReadKey().KeyChar.ToString(), out int row) &&
                (row == 0 || row == 1 || row == 2))
            {
                Console.Write(" ");
                if (int.TryParse(Console.ReadKey().KeyChar.ToString(), out int column) &&
                    (column == 0 || column == 1 || column == 2))
                {
                    if (board[row, column] ==' ')
                    {
                        board[row, column] = turnOf;
                        turnOf = turnOf == 'X' ? 'O' : 'X';
                        Console.WriteLine();
                        GetInput();
                    }
                    else
                    {
                        Console.WriteLine("\nThat spot is already taken!");
                        GetInput();
                    }
                }
            }
            Console.WriteLine("\nError. You must input a number 0 - 2");
            GetInput();
        }
    }
}
