// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы 
// каждой строки двумерного массива.

int[,] matrix = new int[4, 4];
Print2DArray(Fill2DAraay(matrix));
Console.WriteLine();
// SortRowElements(matrix);
Print2DArray(SortRowElements(matrix));

int[,] Fill2DAraay(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 100);
        }
    }
    return matrix;
}

void Print2DArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j], 3}");
        }
        Console.WriteLine();
    }
}


int[,] SortRowElements(int[,] matrix)
{    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {

        for (int j = 0; j < matrix.GetLength(1) - 1; j++)
        {
            int jMax = j;
            int max = matrix[i, jMax];
            
            for (int k = j + 1; k < matrix.GetLength(1); k++)
            {
                if (matrix[i, k] > max)
                {
                max = matrix[i, k];
                (matrix[i, j], matrix[i, k]) = (matrix[i, k], matrix[i, j]);
                }
            }
        }
    }
    return matrix;
}