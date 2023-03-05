// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

Console.Clear();

int[] GetArray(int size, int min, int max)
{
    int[] result = new int[size];
    Random rnd = new Random();
    for(int i = 0; i < size; i++)
    {
        result[i] = rnd.Next(min, max + 1);
    }
    Console.WriteLine($" Ваш массив: [{string.Join(", ", result)}]");
    return result;
}


void CopyArray (int[] arr)
{
    int ArrSize = arr.Length;
    int[] CopyArr = new int[ArrSize];
    for(int i = 0; i < ArrSize; i++)
    {
        CopyArr[i] = arr[i];
    }
    Console.WriteLine($"Скопированный массив: [{string.Join(", ", CopyArr)}]");
}


int[] array = GetArray(12, -9, 100);
CopyArray(array);