using System;

namespace Tema6Ej1
{
	class Program
	{
		static void Main()
		{
			int[,] board = new int[3, 3];

			SetPlayer(board, 1, 1, 1);
			SetPlayer(board, 0, 1, 2);
			SetPlayer(board, 1, 0, 1);
			SetPlayer(board, 0, 2, 2);
			SetPlayer(board, 1, 2, 1);
		}

		public static void SetPlayer(int[,] board, int x, int y, int player)
		{
			board[x, y] = player;
			PrintBoard(board);
		}

		public static void PrintBoard(int[,] board)
		{
			for (int i = 0; i < board.GetLength(0); i++)
			{
				for (int j = 0; j < board.GetLength(1); j++)
				{
					char character;
					switch (board[i, j])
					{
						case 1:
							character = 'X';
							break;
						case 2:
							character = 'O';
							break;
						default:
							character = '-';
							break;
					}

					Console.Write(character + " ");
				}
				Console.WriteLine();
			}

			Console.WriteLine();
		}
	}
}