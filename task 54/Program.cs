// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] InputMatrix()
{
  int[] size = new int[2];
  Console.Write("введите размер матрицы: ");
  size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
  int[,] matrix = new int[size[0], size[1]];
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i,j] = new Random().Next(1,10);
      Console.Write($"{matrix[i,j]} ");
    }
    Console.WriteLine();
  }
  return matrix;
}

void SortMatrix(int[,] matrix)
{
  int temp = 0;
  
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      for (int k = 0; k < matrix.GetLength(1); k++)
      {
        if (matrix[i,j] > matrix[i,k])
        {
          temp = matrix[i,k];
          matrix[i,k] = matrix[i,j];
          matrix[i,j] = temp;
        }
      }
    }

  }
}

void PrintArray(int[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
  {
    for(int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}


Console.Clear();
int[,] matrix = InputMatrix();
Console.WriteLine();
SortMatrix(matrix);
PrintArray(matrix);
