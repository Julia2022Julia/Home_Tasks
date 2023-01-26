//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine()), count = 0;
while(n > 0){
     count = count + n % 10;
     n = n / 10;}
Console.WriteLine(count);