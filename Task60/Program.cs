// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.

void FillMatrix3D(int[,,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            for(int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = new Random().Next(1, 11);
            }
        }
    }
}

void PrintMatrix3D(int[,,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            for(int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i, j, k]}{(i, j, k)} \t ");
            }
        Console.WriteLine();    
        }
    }
}
Console.Clear();
Console.Write("Введите размеры массива: ");
int [] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int[,,] matrix = new int [size[0], size[1], size[2]];
FillMatrix3D(matrix);
PrintMatrix3D(matrix);
