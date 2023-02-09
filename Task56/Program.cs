// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.


void FillMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
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

void NumberRowMinSumElements(int[,] matrix)
{
    int minRow = 0;
    int minSumRow = 0;
    int sumRow = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {   
        minRow += matrix[i, 0];
    }
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        sumRow += matrix[i, j];
        Console.WriteLine($"Cумма строки {i + 1} = {sumRow}");
        if(sumRow < minRow)
        {
        minRow = sumRow;
        minSumRow = i;
        }
        sumRow = 0;
    }
    Console.WriteLine($"Минимальная сумма элементов на {minSumRow + 1} строке");

} 

int[,] matrix = new int [5, 3];
FillMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();
NumberRowMinSumElements(matrix);