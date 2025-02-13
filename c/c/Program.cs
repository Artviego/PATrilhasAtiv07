using System;

namespace c
{
	class Program
	{
		public static void Main(string[] args)
		{
			int[,] Matriz = new int[4, 2];
			Random numeros = new Random();
			int soma = 0;
			
			// Preenchendo os valores da matriz
			for (int i = 0; i < 4; i++)
			{
				for (int j = 0; j < 2; j++)
				{
					Matriz[i, j] = numeros.Next(1, 11); // Números aleatórios entre 1 e 100
				}
			}
			
			// Impressão da matriz
			Console.WriteLine("Matriz 4x2:");
			for (int i = 0; i < 4; i++)
			{
				for (int j = 0; j < 2; j++)
				{
					Console.Write(Matriz[i, j] + "\t");
				}
				Console.WriteLine();
			}
			
			// Calcula a soma de todos os valores da matriz
			for (int i = 0; i < 4; i++)
			{
				for (int j = 0; j < 2; j++)
				{
					soma += Matriz[i, j];
				}
			}
			
			// Exibe a soma
			Console.WriteLine("Soma de todos os valores da matriz: {0}", soma);
			Console.ReadKey(true);
		}
	}
}