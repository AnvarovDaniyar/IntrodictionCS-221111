﻿// С клавиатуры вводится целое число. Вывести третью цифру числа или сообщить, что её нет (Вывести: NO).

System.Console.WriteLine("Введите число a:");
int a=Convert.ToInt32(Console.ReadLine());

if (a<=99)
{
    System.Console.WriteLine("NO");
}
else if (a<=999)
{
    System.Console.WriteLine(a%10);
}
else if (a<=9999)
{
    System.Console.WriteLine(a/10%10);
}
else if (a<=99999)
{
    System.Console.WriteLine(a/100%10);
}
else 
{
    System.Console.WriteLine("и т.д.");
}
