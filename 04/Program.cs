// По заданному с клавиатуры номеру дня недели вывести его название

System.Console.WriteLine("Введите номер дня недели:");
int s=Convert.ToInt32(Console.ReadLine());
int a=1,b=2,c=3,d=4,e=5,f=6,g=7;

if (s==a)
{
    System.Console.WriteLine("Понедельник");
}
else if (s==b)
{
    System.Console.WriteLine("Вторник");
}
else if (s==c)
{
    System.Console.WriteLine("Среда");
}
else if (s==d)
{
    System.Console.WriteLine("Четверг");
}
else if (s==e)
{
    System.Console.WriteLine("Пятница");
}
else if (s==f)
{
    System.Console.WriteLine("Суббота");
}
else if (s==g)
{
    System.Console.WriteLine("Воскресенье");
}

