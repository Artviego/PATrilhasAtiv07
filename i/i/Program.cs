using System;

namespace i
{
	class Program
	{
		public static void Main(string[] args)
		{
			int[,] Matriz = new int[10, 10];
			Random numeros = new Random();
			
			// Preenchendo os valores da matriz
			for (int i = 0; i < 10; i++)
			{
				for (int j = 0; j < 10; j++)
				{
					Matriz[i, j] = numeros.Next(1, 101);
				}
			}
			
			// Exibe a matriz
			Console.WriteLine("Matriz 10x10:\n");
			for (int i = 0; i < 10; i++)
			{
				for (int j = 0; j < 10; j++)
				{
					Console.Write(Matriz[i, j] + " ");
				}
				Console.WriteLine();
			}
			
			// Calcula a soma de todos os valores
			int soma = 0;
			for (int i = 0; i < 10; i++)
			{
				for (int j = 0; j < 10; j++)
				{
					soma += Matriz[i, j];
				}
			}
			
			Console.WriteLine("\nA soma de todos os valores da matriz é: {0}", soma);
			Console.ReadKey(true);
		}
	}
}