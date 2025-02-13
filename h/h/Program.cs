using System;

namespace h
{
	class Program
	{
		public static void Main(string[] args)
		{
			int[,] Matriz = new int[10, 10];
			Random numeros = new Random();
			
			for (int i = 0; i < 10; i++)
			{
				for (int j = 0; j < 10; j++)
				{
					Matriz[i, j] = numeros.Next(1, 101);
				}
			}
			
			for (int i = 0; i < 10; i++)
			{
				for (int j = 0; j < 10; j++)
				{
					Console.Write(Matriz[i, j] + " ");
				}
				Console.WriteLine();
			}
			
			// Calculando a soma e a média dos elementos da diagonal principal
			int somaDiagonalPrincipal = 0;
			for (int i = 0; i < 10; i++)
			{
				somaDiagonalPrincipal += Matriz[i, i];
			}
			double mediaDiagonalPrincipal = somaDiagonalPrincipal / (double)10;
			
			// Exibindo a soma e a média da diagonal principal
			Console.WriteLine("\nSoma da diagonal principal: {0}", somaDiagonalPrincipal);
			Console.WriteLine("Média da diagonal principal: {0}", mediaDiagonalPrincipal);
			
			// Calculando a soma e média dos elementos da diagonal secundária
			int somaDiagonalSecundaria = 0;
			for (int i = 0; i < 10; i++)
			{
				somaDiagonalSecundaria += Matriz[i, 10 - 1 - i];
			}
			double mediaDiagonalSecundaria = somaDiagonalSecundaria / (double)10;
			
			// Exibindo a soma e a média da diagonal secundária
			Console.WriteLine("\nSoma da diagonal secundária: {0}", somaDiagonalSecundaria);
			Console.WriteLine("Média da diagonal secundária: {0}", mediaDiagonalSecundaria);
			
			Console.ReadKey(true);
		}
	}
}