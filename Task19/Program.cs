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