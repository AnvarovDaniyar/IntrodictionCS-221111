//2. С клавиатуры вводятся два вещественных числа. Проверять является ли одно из них квадратом второго

/*
//полное условие
if ()
{
    //true
}
else
{
    //false
}
//не полное условие
if ()
{
    //true
}
else
{
    //false
} 
*/

System.Console.WriteLine("Введите число a:");
double a=Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите число b:");
double b=Convert.ToDouble(Console.ReadLine());

if(a*a==b) 
{
    System.Console.WriteLine($"{b} является корнем {a}");
}
if(b*b==a) 
{
    System.Console.WriteLine($"{a} является корнем {b}");
}