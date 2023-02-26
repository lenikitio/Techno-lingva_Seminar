//Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве.
Console.Clear();

Console.WriteLine("Введите размер массива");
int s = Convert.ToInt32(Console.ReadLine());
if (s <= 0)
{
    Console.WriteLine("Так нельзя");
    return;
}
Console.WriteLine("Введите минимальное значение элементов массива");
int mn = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение элементов массива");
int mx = Convert.ToInt32(Console.ReadLine());
if (mx <= mn)
{
    Console.WriteLine("Так нельзя");
    return;
}

int[] OurArray = GetArray(s, mn, mx);
Console.Write("Ваш массив: ");
Console.WriteLine(String.Join(", ", OurArray));

Console.WriteLine("Введите число, проверим есть ли оно в массиве");
int n = Convert.ToInt32(Console.ReadLine());

CheckArray(OurArray, n);


int[] GetArray(int size, int min, int max)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    Console.WriteLine("");
    return array;
}

int CheckArray(int[] arr, int num)
{
    int value = 0;
     for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] == num)
        {
        Console.WriteLine($"Ваше число найденно под номером {i+1} ");
        value = i;
        }
    }
    if(value == 0)
    Console.WriteLine("Вашего числа нет в массиве");
    return num;
}
