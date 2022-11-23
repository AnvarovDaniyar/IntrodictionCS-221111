// Программа проверяет пятизначное число на палиндромом.
int n;
do
{
    System.Console.WriteLine("Введите пятизначное число:");
    n=Convert.ToInt32(Console.ReadLine());
}
while (n<10000 || n>99999);
if (n%10==n/10000 && (n%100)/10==(n/1000)%10)
{
System.Console.WriteLine("Палиндромом");
}
else
{
    System.Console.WriteLine("Не палиндромом");
}