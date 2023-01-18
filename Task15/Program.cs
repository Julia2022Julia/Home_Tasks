// Программа принимает цифру дня недели и проверяет, является ли выходным

Console.Clear();
Console.Write("Введите цифру, обозначающую день недели: ");
int n = Convert.ToInt32(Console.ReadLine());
if(n == 6 || n == 7)
   Console.WriteLine("Yes");
else 
   Console.WriteLine("No");
