class Program
{
    static void Main()
    {
        char[,] board = new char[3, 3];
        InitializeBoard(board);

        Console.WriteLine("Выберите режим игры:");
        Console.WriteLine("1. Игрок против игрока");
        Console.WriteLine("2. Игрок против компьютера");
        Console.Write("Ваш выбор: ");
        int gameMode = int.Parse(Console.ReadLine());

        char currentPlayer = 'X';
        bool gameEnded = false;

        while (!gameEnded)
        {
            PrintBoard(board);

            if (gameMode == 2 && currentPlayer == 'O')
            {
                Console.WriteLine("Ход компьютера...");
                MakeSmartComputerMove(board, 'O', 'X');
            }
            else
            {
                Console.WriteLine($"Игрок {currentPlayer}, ваш ход!");
                Console.Write("Введите номер строки (1, 2, 3): ");
                int row = int.Parse(Console.ReadLine()) - 1;
                Console.Write("Введите номер столбца (1, 2, 3): ");
                int col = int.Parse(Console.ReadLine()) - 1;

                if (row < 0 || row > 2 || col < 0 || col > 2 || board[row, col] != ' ')
                {
                    Console.WriteLine("Некорректный ход. Попробуйте снова.");
                    continue;
                }

                board[row, col] = currentPlayer;
            }

            if (CheckWin(board, currentPlayer))
            {
                PrintBoard(board);
                Console.WriteLine($"Игрок {currentPlayer} победил!");
                gameEnded = true;
            }
            else if (CheckDraw(board))
            {
                PrintBoard(board);
                Console.WriteLine("Ничья!");
                gameEnded = true;
            }
            else
            {
                currentPlayer = currentPlayer == 'X' ? 'O' : 'X';
            }
        }
    }

    static void InitializeBoard(char[,] board)
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                board[i, j] = ' ';
            }
        }
    }

    static void PrintBoard(char[,] board)
    {
        Console.Clear();
        Console.WriteLine("  1 2 3");
        for (int i = 0; i < 3; i++)
        {
            Console.Write((i + 1) + " ");
            for (int j = 0; j < 3; j++)
            {
                Console.Write(board[i, j]);
                if (j < 2) Console.Write("|");
            }
            Console.WriteLine();
            if (i < 2) Console.WriteLine("  -----");
        }
    }

    static bool CheckWin(char[,] board, char player)
    {
        for (int i = 0; i < 3; i++)
        {
            if ((board[i, 0] == player && board[i, 1] == player && board[i, 2] == player) ||
                (board[0, i] == player && board[1, i] == player && board[2, i] == player))
            {
                return true;
            }
        }

        if ((board[0, 0] == player && board[1, 1] == player && board[2, 2] == player) ||
            (board[0, 2] == player && board[1, 1] == player && board[2, 0] == player))
        {
            return true;
        }

        return false;
    }

    static bool CheckDraw(char[,] board)
    {
        foreach (char cell in board)
        {
            if (cell == ' ') return false;
        }
        return true;
    }

    static void MakeSmartComputerMove(char[,] board, char computer, char opponent)
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (board[i, j] == ' ')
                {
                    board[i, j] = computer;
                    if (CheckWin(board, computer))
                    {
                        return;
                    }
                    board[i, j] = ' ';
                }
            }
        }

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (board[i, j] == ' ')
                {
                    board[i, j] = opponent;
                    if (CheckWin(board, opponent))
                    {
                        board[i, j] = computer;
                        return;
                    }
                    board[i, j] = ' ';
                }
            }
        }

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (board[i, j] == ' ')
                {
                    board[i, j] = computer;
                    return;
                }
            }
        }
    }
}