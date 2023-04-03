// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

void ProductMatrix(int[,] matrix1, int[,] matrix2, int[,] matrix3)
{
  
  if (matrix1.GetLength(1) == matrix2.GetLength(0))
  {
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
      for (int j = 0; j < matrix1.GetLength(1); j++)
      {
        int sum = 0;
        for (int k = 0; k < matrix1.GetLength(1); k++)
        {
          sum += matrix1[i,k] * matrix2[k,j];
        }
      matrix3[i,j] = sum;
      }
    }
  }
  else Console.WriteLine("матрицы не перемножаются");
}

void PrintMatrix(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      Console.Write($"{matrix[i,j]} ");
    }
  Console.WriteLine();
  }
}

Console.Clear();
int [,] matrix1 = InputMatrix();
int [,] matrix2 = InputMatrix();
int [,] matrix3 = new int [matrix1.GetLength(0), matrix1.GetLength(1)];
ProductMatrix(matrix1, matrix2, matrix3);
Console.WriteLine();
PrintMatrix(matrix3);