// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(-10, 11);
}

void ReleaseArray(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if( i % 2 == 1)
        sum = sum + array[i];
        i++;
                
    }
    
    Console.WriteLine($"Сумма = {sum}");
}    
   
   

Console.Clear();
int[] array = new int[7];
InputArray(array);
Console.WriteLine($"Начальный массив:[{string.Join(", ", array)}]");
ReleaseArray(array);
