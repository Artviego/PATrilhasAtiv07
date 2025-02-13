using System;

namespace Matriz
{
	public class Program
	{
		public static void Main(string[] args)
		{
			int[,] Matriz = new int[3, 3]
			{
				{ 1, 2, 3},
				{ 4, 5, 6},
				{7, 8, 9}
			};
			
			// Exibição da matriz
			Console.WriteLine("Matrix 3x3");
			
			for (int i = 0; i < 3; i++)
			{
				for (int j = 0; j < 3; j++)
				{
					Console.Write(Matriz[j, i] + " ");
				}
				Console.WriteLine();
			}
			
			Console.ReadKey(true);
		}
	}
}