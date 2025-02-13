using System;

class Program
{
    static void Main()
    {
    	int[,] Matriz = new int[4, 4]  // Preenche a Matriz
    	{
    		{ 1, 2, 3, 4 },
    		{ 5, 6, 7, 8 },
    		{ 9, 10, 11, 12},
    		{ 13, 14, 15, 16}
    	};
    	
    	Console.WriteLine("Números pares do vetor: ");
    	// Exibe a matriz normal
    	for (int i = 0; i < 4; i++)
    	{
    		for (int j = 0; j < 4; j++)
    		{
    			if (Matriz[i, j] % 2 == 0)
    			{
    				Console.WriteLine(Matriz[i, j] + " ");	
    			}
    		}
    	}
    	Console.WriteLine();
   		Console.ReadKey(true);
    }
}