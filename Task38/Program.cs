// Задача 38: Задайте массив дробных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.57, 7.96, 22.47, 2.12, 78.73] -> 76.61

void InputArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    array[i] = new Random().NextDouble()*10.0;
    
}

void ReleaseArray(double[] array)
{
    double max=array[0];  double min=array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > max) max = array[i];
        else if(array[i] < min) min = array[i];
    }
     
    Console.WriteLine($"Минимальное: {min}");
    Console.WriteLine($"Максимальное: {max}");
    Console.WriteLine($"Разница: {max - min}");
}

Console.Clear();
double[] array = new double[7];
InputArray(array);
Console.WriteLine($"Начальный массив:[{string.Join(", ", array)}]");
ReleaseArray(array);