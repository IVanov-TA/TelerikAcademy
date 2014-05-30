using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace minesweepers
{
    public class StartGame
	{

        static void Main(string[] args)
		{
			string commandLine = string.Empty;
			char[,] maskGameField = MaskGameField();
			char[,] mines = GenrateMines();
			int counter = 0;
			bool isOnMine = false;
			List<Player> players = new List<Player>(6);
			int currentRow = 0;
			int currentCol = 0;
			bool isAlive = true;
			const int maks = 35;
			bool isAllOpen = false;

			do
			{
				if (isAlive)
				{
					Console.WriteLine("Hajde da igraem na “Mini4KI”. Probvaj si kasmeta da otkriesh poleteta bez mini4ki." +
					" Komanda 'top' pokazva klasiraneto, 'restart' po4va nova igra, 'exit' izliza i hajde 4ao!");
					DrawField(maskGameField);
					isAlive = false;
				}
				Console.Write("Daj red i kolona : ");
				commandLine = Console.ReadLine().Trim();
				if (commandLine.Length >= 3)
				{
					if (int.TryParse(commandLine[0].ToString(), out currentRow) &&
					int.TryParse(commandLine[2].ToString(), out currentCol) &&
						currentRow <= maskGameField.GetLength(0) && currentCol <= maskGameField.GetLength(1))
					{
						commandLine = "turn";
					}
				}
				switch (commandLine)
				{
					case "top":
						Rating(players);
						break;
					case "restart":
						maskGameField = MaskGameField();
						mines = GenrateMines();
						DrawField(maskGameField);
						isOnMine = false;
						isAlive = false;
						break;
					case "exit":
						Console.WriteLine("4a0, 4a0, 4a0!");
						break;
					case "turn":
						if (mines[currentRow, currentCol] != '*')
						{
							if (mines[currentRow, currentCol] == '-')
							{
								MakeMove(maskGameField, mines, currentRow, currentCol);
								counter++;
							}
							if (maks == counter)
							{
								isAllOpen = true;
							}
							else
							{
								DrawField(maskGameField);
							}
						}
						else
						{
							isOnMine = true;
						}
						break;
					default:
						Console.WriteLine("\nGreshka! nevalidna Komanda\n");
						break;
				}
				if (isOnMine)
				{
					DrawField(mines);
					Console.Write("\nHrrrrrr! Umria gerojski s {0} to4ki. " +
						"Daj si niknejm: ", counter);
					string name = Console.ReadLine();
					Player currentPlayer = new Player(name, counter);
					if (players.Count < 5)
					{
						players.Add(currentPlayer);
					}
					else
					{
						for (int i = 0; i < players.Count; i++)
						{
							if (players[i].PlayerPoints < currentPlayer.PlayerPoints)
							{
								players.Insert(i, currentPlayer);
								players.RemoveAt(players.Count - 1);
								break;
							}
						}
					}
					players.Sort((Player playerFirst, Player playerSecond) => playerSecond.PlayerName.CompareTo(playerFirst.PlayerName));
                    players.Sort((Player playerFirst, Player playerSecond) => playerSecond.PlayerPoints.CompareTo(playerFirst.PlayerName));
					Rating(players);

					maskGameField = MaskGameField();
					mines = GenrateMines();
					counter = 0;
					isOnMine = false;
					isAlive = true;
				}
				if (isAllOpen)
				{
					Console.WriteLine("\nBRAVOOOS! Otvri 35 kletki bez kapka kryv.");
					DrawField(mines);
					Console.WriteLine("Daj si imeto, batka: ");
					string name = Console.ReadLine();
					Player currentPlayer = new Player(name, counter);
					players.Add(currentPlayer);
					Rating(players);
					maskGameField = MaskGameField();
					mines = GenrateMines();
					counter = 0;
					isAllOpen = false;
					isAlive = true;
				}
			}
			while (commandLine != "exit");
			Console.WriteLine("Made in Bulgaria - Uauahahahahaha!");
			Console.WriteLine("AREEEEEEeeeeeee.");
			Console.Read();
		}

		private static void Rating(List<Player> points)
		{
			Console.WriteLine("\nTo4KI:");
			if (points.Count > 0)
			{
				for (int i = 0; i < points.Count; i++)
				{
					Console.WriteLine("{0}. {1} --> {2} kutii",
						i + 1, points[i].PlayerPoints, points[i].PlayerPoints);
				}
				Console.WriteLine();
			}
			else
			{
				Console.WriteLine("prazna klasaciq!\n");
			}
		}

		private static void MakeMove(char[,] gameField,
			char[,] mines, int row, int col)
		{
			char getNearestMineCount = GenerateValue(mines, row, col);
			mines[row, col] = getNearestMineCount;
			gameField[row, col] = getNearestMineCount;
		}

		private static void DrawField(char[,] board)
		{
			int rows = board.GetLength(0);
			int cols = board.GetLength(1);
			Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
			Console.WriteLine("   ---------------------");
			for (int i = 0; i < rows; i++)
			{
				Console.Write("{0} | ", i);
				for (int j = 0; j < cols; j++)
				{
					Console.Write(string.Format("{0} ", board[i, j]));
				}
				Console.Write("|");
				Console.WriteLine();
			}
			Console.WriteLine("   ---------------------\n");
		}

		private static char[,] MaskGameField()
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

		private static char[,] GenrateMines()
		{
			int rows = 5;
			int cols = 10;
			char[,] gameField = new char[rows, cols];

			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < cols; j++)
				{
					gameField[i, j] = '-';
				}
			}

			List<int> minesList = new List<int>();
			while (minesList.Count < 15)
			{
				Random random = new Random();
				int value = random.Next(50);
				if (!minesList.Contains(value))
				{
					minesList.Add(value);
				}
			}

			foreach (int value in minesList)
			{
				int col = (value / cols);
				int row = (value % cols);
				if (row == 0 && value != 0)
				{
					col--;
					row = cols;
				}
				else
				{
					row++;
				}
				gameField[col, row - 1] = '*';
			}

			return gameField;
		}

		private static void CalculateNearBombValue(char[,] gameField)
		{
			int row = gameField.GetLength(0);
			int col = gameField.GetLength(1);

			for (int i = 0; i < row; i++)
			{
				for (int j = 0; j < col; j++)
				{
					if (gameField[i, j] != '*')
					{
						char currentValue = GenerateValue(gameField, i, j);
						gameField[i, j] = currentValue;
					}
				}
			}
		}

		private static char GenerateValue(char[,] gameField, int row, int col)
		{
			int counter = 0;
			int rows = gameField.GetLength(0);
			int cols = gameField.GetLength(1);

			if (row - 1 >= 0)
			{
				if (gameField[row - 1, col] == '*')
				{ 
					counter++; 
				}
			}
			if (row + 1 < rows)
			{
				if (gameField[row + 1, col] == '*')
				{ 
					counter++; 
				}
			}
			if (col - 1 >= 0)
			{
				if (gameField[row, col - 1] == '*')
				{ 
					counter++;
				}
			}
			if (col + 1 < cols)
			{
				if (gameField[row, col + 1] == '*')
				{ 
					counter++;
				}
			}
			if ((row - 1 >= 0) && (col - 1 >= 0))
			{
				if (gameField[row - 1, col - 1] == '*')
				{ 
					counter++; 
				}
			}
			if ((row - 1 >= 0) && (col + 1 < cols))
			{
				if (gameField[row - 1, col + 1] == '*')
				{ 
					counter++; 
				}
			}
			if ((row + 1 < rows) && (col - 1 >= 0))
			{
				if (gameField[row + 1, col - 1] == '*')
				{ 
					counter++; 
				}
			}
			if ((row + 1 < rows) && (col + 1 < cols))
			{
				if (gameField[row + 1, col + 1] == '*')
				{ 
					counter++; 
				}
			}
			return char.Parse(counter.ToString());
		}
	}
}
