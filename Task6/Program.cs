//Задача 6
Console.Clear();
Console.Write("Введите число:");
int a = Convert.ToInt32(Console.ReadLine());
if(a % 2 == 0)  // (a % 2 == 1) - нечетное
   Console.WriteLine($"Число '{a}' чётное");
else
   Console.WriteLine($"Число '{a}' нечётное");
