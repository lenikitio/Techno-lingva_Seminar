﻿Console.Clear();

Console.WriteLine("Введите x: ");
int x = int.Parse(Console.ReadLine());

Console.WriteLine("Введите y: ");
int y = int.Parse(Console.ReadLine());

if (x > 0 && y > 0)
{
    Console.WriteLine("1 четверть");
}
else if (x < 0 && y > 0)
{
    Console.WriteLine("2 четверть");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine("3 четверть");
}
else if (x > 0 && y < 0)
{
    Console.WriteLine("4 четверть");
}
else
{
    Console.WriteLine("четверть не определена");
}