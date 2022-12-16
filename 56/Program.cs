//56. Написать программу копирования массива.

int[] RandomIntArray(int size,int min,int max)
{
    int[] a=new int[size];
    Random random=new Random();
    for(int i=0;i<size;i++)
        a[i]=random.Next(min,max+1);
    return a;
}
void Print(int[] a)
{
    for(int i=0;i<a.Length;i++)
        System.Console.Write($"{a[i],5}");
}
int[] ArrayCopy(int[] a)
{
    int[] c=new int[a.Length];
           for(int i=0;i<a.Length;i++)
            c[i]=a[i];
    return c;
}
int[] a= RandomIntArray(10,0,10);
int[] c= ArrayCopy(a);
System.Console.WriteLine();
Print(a);
Print(c);



