// Задача 50. Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
      for (int j = 0; j < matrix.GetLength(1); j++)
      {
        matrix[i, j] = new Random().Next(1, 11);
      }
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
      for (int j = 0; j < matrix.GetLength(1); j++)
      {
        Console.Write($"{matrix[i, j]} \t");
      }
      Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите размеры массива: ");
int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
Console.WriteLine("Начальный массив:");
PrintMatrix(matrix);
Console.Write("Введите индекс сторки: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите индекс столбца: ");
int m = Convert.ToInt32(Console.ReadLine());
if(n < matrix.GetLength(0) && m < matrix.GetLength(1))
   Console.WriteLine(matrix[n, m]);
else
   Console.WriteLine("Tакой позиции в массиве нет");
