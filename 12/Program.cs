// С клавиатуры вводится целое число из  диапазона  [10, 99]. Показать наибольшую цифру числа

System.Console.WriteLine("Введите число a:");
int a=Convert.ToInt32(Console.ReadLine());
if (a/10>a%10)
{
    System.Console.WriteLine(a/10);
}
else
{
    System.Console.WriteLine(a%10);
}