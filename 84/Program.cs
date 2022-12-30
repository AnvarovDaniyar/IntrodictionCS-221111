//84. Определить являются ли введенные с клавиатуры символы правильно записью целого числа. 
// Вычислить сумму цифр введенного числа
 string s=Console.ReadLine();
bool Inttest(string s)
{
    foreach(char c in s)
    if (char.IsLetter(c)) return false;
    return true;
}
System.Console.WriteLine(Inttest(s));

int? k=0;
if (Inttest(s)==true)
 {
    for(int i=0;i<s.Length;i++)
    
      if (char.IsDigit(s[i])) 
           k+= int.Parse($"{s[i]}");
               System.Console.WriteLine(k);
 }
 else System.Console.WriteLine("Введено не корректное число");