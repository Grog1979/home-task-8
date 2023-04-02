// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


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

int[] ArraySumRow(int[,] matrix)
{
  int[] arraysum = new int[matrix.GetLength(0)];
  int k = 0;
  int sum = 0;
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      sum += matrix[i,j];
    }
    arraysum[k] = sum;
    Console.Write($"{arraysum[k]} ");
    sum = 0;
    k++;
  }
  return arraysum;
}
int IndexMinSum(int[] array)
{
  int min = array[0];
  int index = 0;
  for (int i = 1; i < array.Length; i++)
  {
    if (min > array[i])
    {
      min = array[i];
      index = i;
    }
  }
  return index;
}

Console.Clear();
int[,] matrix = InputMatrix();
Console.WriteLine();
int[] array = ArraySumRow(matrix);
Console.WriteLine();
int index = IndexMinSum(array);
Console.Write($"номер строки с наименьшей суммой: {index}");
