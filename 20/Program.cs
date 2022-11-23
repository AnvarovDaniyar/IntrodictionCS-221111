//20. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

int x,y;
do
{
    System.Console.WriteLine("Введите координаты точки x:");
    x=Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine("Введите координаты точки y:");
    y=Convert.ToInt32(Console.ReadLine());
}
while (x==0 || y==0);
if (x>0 && y>0)
System.Console.WriteLine("Первая четверть плоскости");
    else if (x<0 && y>0)
    System.Console.WriteLine("Вторая четверть плоскости");
        else if (x<0 && y<0)
        System.Console.WriteLine("Третья четверть плоскости");
            else if (x>0 && y<0)
            System.Console.WriteLine("Четвертая четверть плоскости");
