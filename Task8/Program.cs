// Задача 8
Console.Clear();
Console.Write("Введите число:");
int a = Convert.ToInt32(Console.ReadLine());
int b = a - (a - 1);
while(b <= a )
{
   if(b % 2 == 0)
      Console.Write($"{b}");
      b++;
}
