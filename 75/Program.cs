﻿//75. Написать программу вычисления функции Аккермана
static int A(int n, int m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return A(n - 1, 1);
    else
      return A(n - 1, A(n, m - 1));
}
int T=A(1,1);
System.Console.WriteLine(T);