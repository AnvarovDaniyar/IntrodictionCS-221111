//27. Возведите число А в c B используя цикл

int Stepen(int x,int s)
{
    int result=x;
    for(int i=1;i<s;i++)
    result = result * x;
    return result;
}
int A=Convert.ToInt32(Console.ReadLine());
int B=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"{(int)Stepen(A,B)}");