using System;

namespace f
{
	class Program
	{
		public static void Main(string[] args)
		{
			int[,] Matriz = new int[3, 3];
			Random numeros = new Random();
			
			// Preenchendo o vetor com números aleatórios
			for (int i = 0; i < 3; i++)
			{
				for (int j = 0; j < 3; j++)
				{
					Matriz[i, j] = numeros.Next(1, 101); // Definindo entre 1 e 100
				}
			}
			
			// Matriz preenchida
			Console.WriteLine("Matriz 3x3:");
			for (int i = 0; i < 3; i++)
			{
				for (int j = 0; j < 3; j++)
				{
					Console.Write(Matriz[i, j] + "\t");
				}
				
				Console.WriteLine(); 
			}
			
			// Acha o maior valor da matriz
			int maior = 0;
			for (int i = 0; i < 3; i++)
			{
				for (int j = 0; j < 3; j++)
				{
					if (Matriz[i, j] > maior)
					{
						maior = Matriz[i, j];
					}
				}
			}
			
			Console.WriteLine("\nO maior valor da matriz é: {0}", maior);
			Console.ReadKey(true);
		}
	}
}