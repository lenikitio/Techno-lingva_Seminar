//Задайте одномерный массив из 123 случайных чисел. 
//Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

Console.Clear();

int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    array[i] = new Random().Next(minValue,maxValue + 1);
    Console.WriteLine(String.Join(", ", array));
    return array;
}

void GetCount(int[] arr, int LeftBorder, int RightBorder)
{
    int count = 0;
    foreach(int elem in arr)
    if (elem >= LeftBorder && elem <= RightBorder)
    count ++;
    Console.WriteLine($"Количество элементов в массиве в вашем диапазоне: {count}");
}

Console.WriteLine("Введите количество элементов в массиве: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение элементов массива: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение элементов массива: ");
int c = Convert.ToInt32(Console.ReadLine());

int[] NewArray = GetRandomArray(a, b, c);

Console.WriteLine("Введите левую границу поиска: ");
int d = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите правую границу поиска: ");
int e = Convert.ToInt32(Console.ReadLine());

GetCount(NewArray, d, e);