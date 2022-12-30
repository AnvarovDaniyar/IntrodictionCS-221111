//93. Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int n=6;
int m=5;
int[,] Random2DArray(int n,int m,int min=1,int max=5)
{
    int[,] a=new int[n,m];
    Random random=new Random();
    for(int i=0;i<n;i++)
         for(int j=0;j<m;j++)
                a[i,j]=random.Next(min,max+1);
    return a;
}

void Print2DArray(int[,] a)
{
    for(int i=0;i<a.GetLength(0);i++)
        {
     for(int j=0;j<a.GetLength(1);j++)
        System.Console.Write($"{a[i,j],4}");
           System.Console.WriteLine();
        }
}

void ArrSum(int[,] a,int[,] b,int[,] c)
{    
     for(int i=0;i<a.GetLength(0);i++)    
        for(int k=0;k<a.GetLength(1);k++)
            for(int j=0;j<a.GetLength(1)-1;j++)
                c[i,j] = a[i,j]*b[i,j];
}

int[,] a=Random2DArray(n,m);
int[,] b=Random2DArray(n,m);
int[,] c=Random2DArray(n,m);
Print2DArray(a);
System.Console.WriteLine();
Print2DArray(b);
System.Console.WriteLine();
ArrSum(a,b,c);
Print2DArray(c);