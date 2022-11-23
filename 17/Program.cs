//17. Дано число обозначающее день недели. Выяснить является номер дня недели выходным

int a;
do 
{
    System.Console.WriteLine("Введите номер дня недели:");
    a=Convert.ToInt32(Console.ReadLine());
}

while (a>7 || a<1);

if (a<6)
{
    System.Console.WriteLine("Будний");
} 
else
{
    System.Console.WriteLine("Выходний");
}