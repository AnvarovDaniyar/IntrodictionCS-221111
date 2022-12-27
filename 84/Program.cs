//84. Определить являются ли введенные с клавиатуры символы правильно записью целого числа. 
// Вычислить сумму цифр введенного числа


string s=Console.ReadLine();
int k=0;
 for(int i=0;i<s.Length;i++)
     if (char.IsDigit(s[i])) 
        k+=s[i];
        System.Console.WriteLine(k);
    // else 
    // System.Console.WriteLine("Не целое число");