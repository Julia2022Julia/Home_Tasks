// Задача 2
Console.Clear();
Console.Write("Введите 1-ое число:");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число:");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
    Console.WriteLine($"min = {b}, max = {a}");
else if (b > a)
    Console.WriteLine($"min = {a}, max = {b}");
else
    Console.WriteLine($"{a} = {b}");


//Вариант от преподователя
// if (a > b)
// Console.WriteLine(a);
// else
// Console.WriteLine(b);