// Вывести на экран числа от -N до N

System.Console.WriteLine("Ведите число N:");
int N=Convert.ToInt32(Console.ReadLine());
int i=-N;
//int s=N*2+1;
while (i<=N)
{
System.Console.WriteLine($"{i}");
i++;
}
