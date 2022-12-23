// 70. Показать натуральные числа от 1 до N, N задано
void Natur(int N,int i=1)
{
    if (i<=N)
    {
        System.Console.Write($"{i} ");
        Natur(N,i+1);
    }    
}


Natur(6);

