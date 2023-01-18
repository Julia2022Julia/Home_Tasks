//Задача 4
Console.Clear();
Console.Write("Введите 1-ое число:");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число:");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 3-ое число:");
int c = Convert.ToInt32(Console.ReadLine());
if (a > b)
    Console.WriteLine(a);
else if (b > c)
    Console.WriteLine(b);
else if (c > a)
    Console.WriteLine(c);
else
    Console.WriteLine("=");

//Вариант от преподователя
// Console.Write("Введите 1-ое число:");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите 2-ое число:");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите 3-ое число:");
// int c = Convert.ToInt32(Console.ReadLine()), max = a;

// if (max < b) max = b;
// if (max < c) max = c;

// Console.WriteLine(max);