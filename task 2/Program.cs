// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        int[,] matrix = new int[8, 8];

        // Starting position of the queen
        int x = 3; // for example
        int y = 3; // for example

    
        for (int i = 0; i < 8; i++)
        {
           
            matrix[x, i] = 1;
            matrix[i, y] = 1;

            if (x + i < 8 && y + i < 8)
                matrix[x + i, y + i] = 1;

            if (x - i >= 0 && y - i >= 0)
                matrix[x - i, y - i] = 1;

            if (x + i < 8 && y - i >= 0)
                matrix[x + i, y - i] = 1;

            if (x - i >= 0 && y + i < 8)
                matrix[x - i, y + i] = 1;
        }

        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
