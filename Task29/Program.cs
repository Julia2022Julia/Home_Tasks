//Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
//и выводит их на экран(ввод пользователя с клавиатуры).

Console.Clear();
Console.WriteLine("Введите 8 чисел:");
int[] array = new int[8];
for (int i = 0; i < array.Length; i++)
    
    array[i] = Convert.ToInt32(Console.ReadLine());
    
Console.WriteLine($"Результат: [{string.Join(", ", array)}]");