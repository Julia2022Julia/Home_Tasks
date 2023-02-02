// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}

int ReleaseArray(int[] array)
{
    int count = 0;
    foreach (int element in array)
    {
        if (element > 0)
        count ++;
    }
    return count;
}

Console.Clear();
Console.WriteLine("Введите количество чисел:");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int [n];
Console.WriteLine("Введите числа:");
PrintArray(array);
Console.WriteLine($"Массив:[{string.Join(", ", array)}]");
Console.WriteLine($"Количество чисел больше 0: {ReleaseArray(array)}");