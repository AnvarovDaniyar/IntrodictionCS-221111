//25. Вывести на экран кубы чисел от 1 до N

int Cube(int Number)
{
    Number = Number*Number*Number;
    return Number;
}
int N=Convert.ToInt32(Console.ReadLine());
for (int i=1;i<N+1;i++)
System.Console.Write($"{(int)Cube(i)} ");