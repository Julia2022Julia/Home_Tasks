//Программа принимает 3-ехзначное число, на выходе - 2-ая цифра

Console.Clear();
Console.Write("Введите трехзначное число: ");
int n = Convert.ToInt32(Console.ReadLine()), m;
Console.WriteLine($"{m = n / 10 % 10}");
