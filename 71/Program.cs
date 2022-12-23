// 71. Показать натуральные числа от N до 1, N задано
void Rutan(int N,int i=1)
{
    if (i<=N)
    {
        System.Console.Write($"{N} ");
        Rutan(N-1,i);
    }    
}


Rutan(10);

