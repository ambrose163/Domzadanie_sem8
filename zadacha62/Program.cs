// Задача 62: Заполните спирально массив 4 на 4.
// работает только для квадратных матриц любого размера

using System;
Console.Clear();

int[,] matrix = new int [4, 4];

int row = 0;
int col = 0;
int count = 1;


while (count <= matrix.GetLength(0) * matrix.GetLength(1)) 
{
  matrix[row, col] = count;
  count ++;

  if (row <= col + 1 && row + col < matrix.GetLength(1) - 1)
    col ++;
  else if (row < col && row + col >= matrix.GetLength(0) - 1)
    row ++;
  else if (row >= col && row + col > matrix.GetLength(1) - 1)
    col --;
  else
    row --;
}

Fill2DArray(matrix);

void Fill2DArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i ++)
  {
    for (int j = 0; j < array.GetLength(1); j ++)
    {
      Console.Write($"{array[i, j], 3}");
    }
    Console.WriteLine();
  }
}