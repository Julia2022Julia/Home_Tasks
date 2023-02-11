// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.

void FillMatrix(int[,] matrix)
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

void MultiplyMatrix(int[,] resultMatrix, int[,] matrix, int[,] matrix2)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {

            for (int k = 0; k < matrix.GetLength(1); k++)
            {
                resultMatrix[i, j] = matrix[i, j] * matrix2[i, j];
            }
            
        }
    }
}

Console.Clear();
int[,] matrix = new int[2, 2];
int[,] matrix2 = new int[2, 2];
int[,] resultMatrix = new int[2, 2];
Console.WriteLine("Первая матрица:");
FillMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();
Console.WriteLine("Вторая матрица:");
FillMatrix(matrix2);
PrintMatrix(matrix2);
Console.WriteLine();
Console.WriteLine("Произведение матриц:");
MultiplyMatrix(resultMatrix, matrix, matrix2);
PrintMatrix(resultMatrix);

