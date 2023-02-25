// Задача 26: Напишите программу, которая принимает на вход число и 
// выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5
Console.Clear();

int CountingNum(int num)
{
      if( num == 0)
    {
        return 1;
    }
    int count = 0;
    for (int i = 0; num >= 1; i++)
    {
        num /= 10;
        count++;
    }
    return count;
}

Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Количество цифр в числе {n} равно {CountingNum(n)}");