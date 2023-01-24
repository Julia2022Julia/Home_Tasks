//Task 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Console.Clear();
Console.Write("Введите X1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите Y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите Z1: ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите X2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите Y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите Z2: ");
double z2 = Convert.ToDouble(Console.ReadLine());
double n = Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2)), 2);
Console.WriteLine(n);


// Task 21

// Console.Clear();
// Console.Write("Введите координату X: ");
// double x1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите координату Y: ");
// double y1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите координату Z: ");
// double z1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите координату X: ");
// double x2 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите координату Y: ");
// double y2 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите координату Z: ");
// double z2 = Convert.ToDouble(Console.ReadLine());
// double S = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));
// Console.WriteLine($"Результат: {Math.Round(S, 2)}");