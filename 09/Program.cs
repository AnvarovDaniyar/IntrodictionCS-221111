//9. Вывести на экран четные числа от 1 до N

System.Console.WriteLine("Введите число N:");
int N=Convert.ToInt32(Console.ReadLine());
int i=2;
while(i<=N)
{
    System.Console.Write($"{i} ");
    i=i+2;
}
System.Console.WriteLine();
for(int j=2;j<=N;j=j+2)
{
    System.Console.Write($"{j} ");
}