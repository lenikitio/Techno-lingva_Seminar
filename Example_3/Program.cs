// Задача 26: Напишите программу, которая принимает на вход число и 
// выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.Clear();

int GetSumByNumber(int limit)
{
    int result = 0;
    for(int i = 1; i <= limit; i++)
    {
        result += i;
    }
    return result;
}

Console.WriteLine("Введите число A");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма чисел от 1 до {a} = {GetSumByNumber(a)}");
