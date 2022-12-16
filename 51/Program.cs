//51. С клавиатуры вводится число N. Затем вводятся N чисел. 
//Определить сколько чисел больше 0 введено с клавиатуры.

System.Console.WriteLine("Enter a number N:");
int N=Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine($"Enter {N} numbers");

int[] NewNumbers(int N)
{
    int[] a=new int[N];
           for(int i=0;i<N;i++)
        a[i]=Convert.ToInt32(Console.ReadLine());
                return a;
}

void Print(int[] a)
{
    for(int i=0;i<a.Length;i++)
        System.Console.Write($"{a[i],5}");
}

int[] b= NewNumbers(N);
Print(b);

int PositivCounter(int[] b)
{
       int count=0;
    foreach(int el in b)
    {
        if (el>0)
            count++;       
    }
    return count;
}

System.Console.WriteLine($"\n{PositivCounter(b)}");