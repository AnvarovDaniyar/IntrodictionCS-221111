// С клавиатуры вводятся три числа. Найти максимальное из трех чисел

System.Console.WriteLine("Введите число a:");
double a=Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите число b:");
double b=Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите число c:");
double c=Convert.ToDouble(Console.ReadLine());

if(a>b&&a>c)
{
    System.Console.WriteLine("Наибольшее число:"+a);
 }
else
 if (b>c)
{
    System.Console.WriteLine("Наибольшее число:"+b);
}
else
System.Console.WriteLine("Наибольшее число:"+c);