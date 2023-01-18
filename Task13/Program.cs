// Программа выводит третью цифру заданного числа
Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());   //не уверенна насчет Int32

if(n>1000)
{
         while(n > 1000)
         {
            n = n / 10;
         }
    Console.Write(n = n % 10);
}
   
else if (n > 99 && n < 1000)
        Console.Write(n = n % 10);
         
     
else
Console.Write("Цифры нет");


