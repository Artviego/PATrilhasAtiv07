using System;

class Program
{
    static void Main()
    {
        // Criação da matriz 10x10
        int[,] matriz = new int[10, 10];
        Random random = new Random();

        // Preenchendo a matriz com números aleatórios
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                matriz[i, j] = random.Next(1, 101); // Números aleatórios entre 1 e 100
            }
        }

        // Impressão da matriz (opcional, para visualização)
        Console.WriteLine("Matriz 10x10:");
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }

        // Impressão dos elementos da diagonal principal
        Console.WriteLine("\nElementos da diagonal principal:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write(matriz[i, i] + " ");
        }
    }
}