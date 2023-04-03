// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
int[,] f()
{
  int[] size = new int[2];
  Console.Write("введите размер матрицы: ");
  size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
  int[,] array = new int[size[0], size[1]];
  
  int number = 1;
  int i = 0;
  int j = 0;
  while (number < array.GetLength(0) * array.GetLength(1))
  {
  while (j < array.GetLength(1))
  {
    array[i,j] = number;
    number++;
    j++;
  }
    i = i + 1;
  while (i < array.GetLength(0))
  {
    array[i,j] = number;
    number++;
    i++;
  }
    j = j - 1;
  while (j >= 0)
  {
    array[i,j] = number;
    number++;
    j--;
  }
  i = i - 1;
  while (i > 0)
  {
    array[i,j] = number;
    number++;
    i--;
  }
  j = j + 1;
  } 
  return array;  
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
int[,] array = f();
PrintMatrix(array);
