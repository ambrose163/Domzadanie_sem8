// Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу,
//  которая будет построчно выводить массив, добавляя индексы каждого элемента.

using System;
Console.Clear();

int[,,] matrix = new int[2, 2, 2];
int[] array = CreateTempArray(matrix);
PrintArray(array);
Print3DArray(Fill3DAraay(matrix, array));


int[] CreateTempArray(int[,,] matrix)
{
    int[] array = new int[matrix.GetLength(0)
                        * matrix.GetLength(1)
                        * matrix.GetLength(2)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        array[i] = new Random().Next(10, 100);

        for (int j = 0; j < i; j++)
        {
            {
                if (array[i] == array[j]) i--;
            }
        }
    }
    return array;
}

void PrintArray(int[] array)
{
    foreach (int item in array)
        Console.Write($"{item} ");
    Console.WriteLine();
}


int[,,] Fill3DAraay(int[,,] matrix, int[] array)
{
    int index = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = array[index];
                index++;
            }
        }
    }
    return matrix;
}


void Print3DArray(int[,,] matrix)
{
    for (int k = 0; k < matrix.GetLength(2); k++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}