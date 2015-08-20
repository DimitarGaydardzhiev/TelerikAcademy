namespace Minesweeper
{
    using System;
    using System.Collections.Generic;

    public class Engine
    {
        public static void Start()
        {
            string command = string.Empty;
            char[,] gameBoard = CreateGameBoard();
            char[,] mines = CreateMines();
            int counter = 0;
            bool isBlasted = false;
            List<Player> scoreList = new List<Player>(6);
            int row = 0;
            int col = 0;
            bool areInstructionsShown = true;
            const int MaxNumberOfMoves = 35;
            bool isGameWon = false;

            do
            {
                if (areInstructionsShown)
                {
                    Console.WriteLine("Let's play minesweeper!”. Try finding the squares without mines." +
                    " Command 'top' - shows the score list,\n 'restart' - begins a new game,\n 'exit' - exits the game");
                    DrawGameBoard(gameBoard);
                    areInstructionsShown = false;
                }

                Console.Write("Pick a row and a col : ");
                command = Console.ReadLine().Trim();
                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out row) &&
                    int.TryParse(command[2].ToString(), out col) &&
                        row <= gameBoard.GetLength(0) && col <= gameBoard.GetLength(1))
                    {
                        command = "turn";
                    }
                }

                switch (command)
                {
                    case "top":
                        ShowScoreList(scoreList);
                        break;
                    case "restart":
                        gameBoard = CreateGameBoard();
                        mines = CreateMines();
                        DrawGameBoard(gameBoard);
                        isBlasted = false;
                        areInstructionsShown = false;
                        break;
                    case "exit":
                        Console.WriteLine("Goodbye!");
                        break;
                    case "turn":
                        if (mines[row, col] != '*')
                        {
                            if (mines[row, col] == '-')
                            {
                                MakeMove(gameBoard, mines, row, col);
                                counter++;
                            }

                            if (MaxNumberOfMoves == counter)
                            {
                                isGameWon = true;
                            }
                            else
                            {
                                DrawGameBoard(gameBoard);
                            }
                        }
                        else
                        {
                            isBlasted = true;
                        }

                        break;
                    default:
                        Console.WriteLine("\nUnknown Command!\n");
                        break;
                }

                if (isBlasted)
                {
                    DrawGameBoard(mines);
                    Console.Write("\nGame over! You have {0} points. " + "Enter your name: ", counter);
                    string nickname = Console.ReadLine();
                    Player t = new Player(nickname, counter);
                    if (scoreList.Count < 5)
                    {
                        scoreList.Add(t);
                    }
                    else
                    {
                        for (int i = 0; i < scoreList.Count; i++)
                        {
                            if (scoreList[i].NumberOfPoints < t.NumberOfPoints)
                            {
                                scoreList.Insert(i, t);
                                scoreList.RemoveAt(scoreList.Count - 1);
                                break;
                            }
                        }
                    }

                    scoreList.Sort((Player r1, Player r2) => r2.Name.CompareTo(r1.Name));
                    scoreList.Sort((Player r1, Player r2) => r2.NumberOfPoints.CompareTo(r1.NumberOfPoints));
                    ShowScoreList(scoreList);

                    gameBoard = CreateGameBoard();
                    mines = CreateMines();
                    counter = 0;
                    isBlasted = false;
                    areInstructionsShown = true;
                }

                if (isGameWon)
                {
                    Console.WriteLine("\nCongratulations! You have opened 35 squares!");
                    DrawGameBoard(mines);
                    Console.WriteLine("Write your nickname: ");
                    string imeee = Console.ReadLine();
                    Player to4kii = new Player(imeee, counter);
                    scoreList.Add(to4kii);
                    ShowScoreList(scoreList);
                    gameBoard = CreateGameBoard();
                    mines = CreateMines();
                    counter = 0;
                    isGameWon = false;
                    areInstructionsShown = true;
                }
            }
            while (command != "exit");
            Console.WriteLine("Made in Bulgaria!");
            Console.WriteLine("Goodbye.");
            Console.Read();
        }

        private static void ShowScoreList(List<Player> points)
        {
            Console.WriteLine("\nPoints:");
            if (points.Count > 0)
            {
                for (int i = 0; i < points.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} cells", i + 1, points[i].Name, points[i].NumberOfPoints);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Empty score list!\n");
            }
        }

        private static void MakeMove(char[,] gameBoard, char[,] mines, int row, int col)
        {
            char numberOfMines = CountMinesNeighbours(mines, row, col);
            mines[row, col] = numberOfMines;
            gameBoard[row, col] = numberOfMines;
        }

        private static void DrawGameBoard(char[,] board)
        {
            int rows = board.GetLength(0);
            int cols = board.GetLength(1);
            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");
            for (int row = 0; row < rows; row++)
            {
                Console.Write("{0} | ", row);
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(string.Format("{0} ", board[row, col]));
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] CreateGameBoard()
        {
            int boardRows = 5;
            int boardColumns = 10;
            char[,] board = new char[boardRows, boardColumns];
            for (int i = 0; i < boardRows; i++)
            {
                for (int j = 0; j < boardColumns; j++)
                {
                    board[i, j] = '?';
                }
            }

            return board;
        }

        private static char[,] CreateMines()
        {
            int rows = 5;
            int cols = 10;
            char[,] gameBoard = new char[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    gameBoard[i, j] = '-';
                }
            }

            List<int> r3 = new List<int>();
            while (r3.Count < 15)
            {
                Random random = new Random();
                int asfd = random.Next(50);
                if (!r3.Contains(asfd))
                {
                    r3.Add(asfd);
                }
            }

            foreach (int i2 in r3)
            {
                int kol = i2 / cols;
                int red = i2 % cols;
                if (red == 0 && i2 != 0)
                {
                    kol--;
                    red = cols;
                }
                else
                {
                    red++;
                }

                gameBoard[kol, red - 1] = '*';
            }

            return gameBoard;
        }

        private static void GetNumberOfMinesAroundTheSelectedField(char[,] gameBoard)
        {
            int row = gameBoard.GetLength(0);
            int col = gameBoard.GetLength(1);

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (gameBoard[i, j] != '*')
                    {
                        char numberOfMines = CountMinesNeighbours(gameBoard, i, j);
                        gameBoard[i, j] = numberOfMines;
                    }
                }
            }
        }

        private static char CountMinesNeighbours(char[,] gameBoard, int row, int col)
        {
            int counter = 0;
            int rows = gameBoard.GetLength(0);
            int cols = gameBoard.GetLength(1);

            if (row - 1 >= 0)
            {
                if (gameBoard[row - 1, col] == '*')
                {
                    counter++;
                }
            }

            if (row + 1 < rows)
            {
                if (gameBoard[row + 1, col] == '*')
                {
                    counter++;
                }
            }

            if (col - 1 >= 0)
            {
                if (gameBoard[row, col - 1] == '*')
                {
                    counter++;
                }
            }

            if (col + 1 < cols)
            {
                if (gameBoard[row, col + 1] == '*')
                {
                    counter++;
                }
            }

            if ((row - 1 >= 0) && (col - 1 >= 0))
            {
                if (gameBoard[row - 1, col - 1] == '*')
                {
                    counter++;
                }
            }

            if ((row - 1 >= 0) && (col + 1 < cols))
            {
                if (gameBoard[row - 1, col + 1] == '*')
                {
                    counter++;
                }
            }

            if ((row + 1 < rows) && (col - 1 >= 0))
            {
                if (gameBoard[row + 1, col - 1] == '*')
                {
                    counter++;
                }
            }

            if ((row + 1 < rows) && (col + 1 < cols))
            {
                if (gameBoard[row + 1, col + 1] == '*')
                {
                    counter++;
                }
            }

            return char.Parse(counter.ToString());
        }
    }
}
