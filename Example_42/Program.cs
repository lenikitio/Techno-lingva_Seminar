// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.

//41 -> 101001
// 3  -> 11
// 2  -> 10

Console.Clear();

Console.WriteLine("Введите число для преобразования");
int value = Convert.ToInt32(Console.ReadLine());
GetConversion(value);

void GetConversion(int number)
{
    string ost = String.Empty;
    while (number > 0)
    {
        ost = Convert.ToString(number % 2) + ost;
        number = number / 2;
    }
    Console.WriteLine(ost);
}
