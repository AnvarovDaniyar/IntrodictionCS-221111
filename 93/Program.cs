//93. Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

//69. Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.
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

void LineSort(int[,] a,int[,] b)
{
     for(int i=0;i<a.GetLength(0);i++)    
        for(int k=0;k<a.GetLength(1);k++)
            for(int j=0;j<a.GetLength(1)-1;j++)
                if (a[i,j]>a[i,j+1])
                {
                    int t=a[i,j];
                    a[i,j]=a[i,j+1];
                    a[i,j+1]=t;                    
                }
}
int[,] a=Random2DArray(n,m);
int[,] b=Random2DArray(n,m);
int[,] c;
Print2DArray(a);
System.Console.WriteLine();
//LineSort(c);
Print2DArray(b);
//LineSort(a);