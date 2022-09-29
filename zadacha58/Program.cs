// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] matrix1 = new int[3, 4];
Print2DArray(Fill2DAraay(matrix1));
Console.WriteLine();
int[,] matrix2 = new int[matrix1.GetLength(1), 2];
Print2DArray(Fill2DAraay(matrix2));
Console.WriteLine();
int[,] matrixResult = MatrixMatrixMultiplication(matrix1, matrix2);
Print2DArray(matrixResult);


int[,] Fill2DAraay(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 3);
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


int[,] MatrixMatrixMultiplication(int[,] matrix1, int[,] matrix2)
{
    int[,] matrixResult = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrixResult.GetLength(0); i++)
    {
        for (int j = 0; j < matrixResult.GetLength(1); j++)
        {
            matrixResult[i, j] = 0;

            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                int mult = matrix1[i, k] * matrix2[k, j];
                matrixResult[i, j] = matrixResult[i, j] + mult;
            }
        }
    }
    return matrixResult;
}