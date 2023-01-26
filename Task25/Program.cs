//Задача 25: Напишите цикл, который принимает на вход 
//два числа (A и B) и возводит число A в натуральную степень B.

Console.Clear();
Console.Write("Введите 1-ое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
int m = Convert.ToInt32(Console.ReadLine()), b = n;
for (int i = 1; i < m; i++)
{
    b = b * n;
}
Console.WriteLine($"{n} в степени {m} = {b}");
