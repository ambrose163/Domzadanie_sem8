// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить 
// строку с наименьшей суммой элементов.

int[,] matrix = new int[4, 8];
Print2DArray(Fill2DAraay(matrix));
Console.WriteLine();
int[] sums = RowElementsSum(matrix);
PrintArray(sums);
Console.WriteLine();
Console.WriteLine($"Наименьшая сумма элементов в строке № {MinRowSumIndex(sums) + 1} (c индексом {MinRowSumIndex(sums)})");


int[,] Fill2DAraay(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
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


int[] RowElementsSum(int[,] matrix)
{
    int[] sums = new int[matrix.GetLength(0)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sums[i] = 0;

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sums[i] += matrix[i, j];
        }
    }
    return sums;
}


void PrintArray(int[] sums)
{
    foreach (int sum in sums)
        Console.Write($"{sum} ");
}


int MinRowSumIndex(int[] sums)
{
    int min = sums[0];
    int minIndex = 0;

    for (int i = 1; i < sums.Length; i++)
    {
        if (sums[i] < min)
        {
            min = sums[i];
            minIndex = i;
        }
    }
    return minIndex;
}