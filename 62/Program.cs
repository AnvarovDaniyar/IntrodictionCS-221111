//62.В двумерном массиве n×k заменить четные элементы на противоположные по значению (a[i,j]=-a[i,j]). 
//Написать отдельную подпрограмму на вход которой подается массив, а на выходе измененный массив.

int n=4;
int k=5;
int[,] Random2DArray(int n,int k,int min=0,int max=10)
{
    int[,] a=new int[n,k];
    Random random=new Random();
    for(int i=0;i<n;i++)
         for(int j=0;j<k;j++)
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
void EvenChange(int[,] a)
{
    for(int j=0;j<a.GetLength(1);j++)    
        for(int i=0;i<a.GetLength(0)-1;i++)
                if (a[i,j]%2==0)
                    a[i,j]=a[i,j]*(-1);
}
int[,] a=Random2DArray(n,k);
EvenChange(a);
Print2DArray(a);