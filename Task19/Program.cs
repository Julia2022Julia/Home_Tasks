//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.Clear();
Console.Write("Введите пятизначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
int m = 0, num = n;
while (n < 10000 || n >= 100000)
{
    Console.WriteLine("Вы ошиблись!\nВведите пятизначное число: ");
    n = Convert.ToInt32(Console.ReadLine());
}
while(n > 0)
{
    m = m * 10 + n % 10;
    n = n / 10;
}
if(num == m)
Console.WriteLine("да");
else
Console.WriteLine("нет");

// // Task 19

// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int n1 = n / 10000;
// int n2 = (n / 1000) % 10;
// int n4 = (n % 100) / 10;
// int n5 = n % 10;
// if (n1 == n5 && n2 == n4)
//     Console.WriteLine("yes");
// else
//     Console.WriteLine("no");