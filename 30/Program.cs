//30. Написать программу вычисления произведения чисел от 1 до N

int result = 1;
int Mult(int Num)
{
    for(int i=1;i<Num+1;i++)
    result = result *i;
    return result;
}
int N = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"{(int)Mult(N)}");