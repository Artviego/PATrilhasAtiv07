using System;

namespace j
{
	class Program
	{
		public static void Main(string[] args)
		{
			// a) Vetor de oito posições com os nomes das lojas
			string[] lojas = new string[8]
			{
				"Loja A",
				"Loja B",
				"Loja C", 
				"Loja D",
				"Loja E",
				"Loja F",
				"Loja G",
				"Loja H"
			};
			
			// b) Vetor de quatro posições com os nomes dos protudos
			string[] produtos = new string[4]
			{
				"Produto 1",
				"Produto 2",
				"Produto 3",
				"Produto 4"
			};
			
			decimal[,] precos = new decimal[8,4]
			{
				{ 100.00m, 120.00m, 130.00m, 110.00m }, // Preços na Loja 1
            	{ 90.00m, 80.00m, 150.00m, 95.00m },  // Preços na Loja 2
            	{ 110.00m, 115.00m, 100.00m, 90.00m }, // Preços na Loja 3
            	{ 125.00m, 130.00m, 95.00m, 105.00m }, // Preços na Loja 4
            	{ 115.00m, 110.00m, 98.00m, 108.00m }, // Preços na Loja 5
           		{ 105.00m, 125.00m, 119.00m, 102.00m }, // Preços na Loja 6
            	{ 99.00m, 92.00m, 140.00m, 120.00m },  // Preços na Loja 7
            	{ 112.00m, 122.00m, 130.00m, 118.00m }  // Preços na Loja 8
			};
			
			// Exibe os produtos com o preço abaixo de R$ 120, 00
			for (int i = 0; i < 8; i++)
			{
				for (int j = 0; j < 4; j++)
				{
					if (precos[i, j] <= 120.00m) 
					{
						Console.WriteLine("Produto: {0} | Loja: {1} | Preço: R$ {2}", produtos[j], lojas[i], precos[i, j]);
					}
				}
			}
			
			Console.ReadKey(true);
		}
	}
}