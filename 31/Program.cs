//31. Сгенерировать 10 случайных чисел. Показать кубы тех чисел, которые заканчиваются на четную цифру

Random random=new Random();
for(int i=0;i<10;i++)
{
    int a=random.Next(1,100);
    int b=(int)Math.Pow(a,3);
    if (b%10%2==0)
    System.Console.WriteLine($"{a},  {b}");
}