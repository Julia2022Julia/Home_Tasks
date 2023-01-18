// Задача 8
Console.Clear();
Console.Write("Введите число:");
int a = Convert.ToInt32(Console.ReadLine());
int b = a - (a - 1);
while (b <= a)
{
    if (b % 2 == 0)
        Console.Write($"{b}");
    b++;
}


//Вариант от преподавателя
// Console.Write("Введите число:");
// int a = Convert.ToInt32(Console.ReadLine()), count = 2;
// while (count <= a)
// {
//     Console.Write($"{count}");
//     count = count + 2;
// }

// Для отрицательных
// count;
// if( a < 0)
// {
//    count = -2;
//    while(count >= a)
//    {
//       Console.Write($"{count}");
//       count = count - 2;
//    }
// }
// else 
// {
//    count = 2;
//    while (count <= a)
//  {
//     Console.Write($"{count}");
//     count = count + 2;
//  }
// }

//Решение через for 

// Console.Write("Введите число:");
// int a = Convert.ToInt32(Console.ReadLine());

// for (int i = 2; i < a; i+=2)
//     Console.WriteLine($"{i} ");