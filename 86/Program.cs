//86. Подсчитать сколько раз определенный символ (например 'a') встречается в строке.

string? s=Console.ReadLine();
int k=0;
// for(int i=0;i<s.Length;i++)
//     if (char.IsDigit(s[i])) k++;
foreach(char c in s)
    if (c=='\x61') k++;
System.Console.WriteLine(k);   