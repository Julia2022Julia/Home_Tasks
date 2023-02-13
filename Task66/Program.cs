﻿// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

void SumFromMToN(int m, int n)
{
    Console.Write(Sum(m - 1, n));
}

int Sum(int m, int n)
{
    int res = m;
    if(m == n)
    return 0;
    else
    {
        m++;
        res = m + Sum(m, n);
        return res;
    }
}

Console.Clear();
Console.Write("Введите 1-ое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
int n = Convert.ToInt32(Console.ReadLine());
SumFromMToN(m, n);
