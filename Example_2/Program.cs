Console.Clear();

Console.WriteLine("Введите номер четверти: ");
int n = int.Parse(Console.ReadLine());
if (n > 4 || n < 1)
{
    Console.WriteLine("Такой четверти не бывает");

}
else
{
    Console.WriteLine($"Ваша четверть: {n}");

}
if (n == 1)
{
    Console.WriteLine(" 0 < x < + бесконечности, 0 < y < + бесконечности");
}
if (n == 2)
{
    Console.WriteLine(" - бесконечности < x < 0, 0 < y < + бесконечности");
}
if (n == 3)
{
    Console.WriteLine(" - бесконечности < x < 0, - бесконнечности < y < 0");
}
if (n == 4)
{
    Console.WriteLine(" 0 < x < + бесконечности, - бесконнечности < y < 0");
}


