//61. Показать двумерный массив размером m×n заполненный вещественными случайными числами
int m=4;
int n=6;

double[,] Random2DArray(int min=0,int max=10)
{
    double[,] a=new double[n,m];
    Random random=new Random();
    for(int i=0;i<n;i++)
         for(int j=0;j<m;j++)
                a[i,j]=random.Next(min,max+1);
    return a;
}

void Print2DArray(double[,] a)
{
    for(int i=0;i<a.GetLength(0);i++)
        {
     for(int j=0;j<a.GetLength(1);j++)
        System.Console.Write($"{a[i,j],4}");
           System.Console.WriteLine();
        }
}
double[,] a=Random2DArray(m,n);
Print2DArray(a);