// Задача 39:  Напишите программу, которая перевернёт одномерный массив 
//(последний элемент будет на первом месте, а первый - на последнем и т.д.)

//[1 2 3 4 5] -> [5 4 3 2 1]
//[6 7 3 6] -> [6 3 7 6]

Console.Clear();

int[] GetArray (int size, int min, int max)
{
    int[] result = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        result[i] = rnd.Next(min, max + 1);
    }
    Console.WriteLine($"Ваш массив [{string.Join(", ", result)}]");
    return result;
}

void FlipArray(int[] arr)
{
    int ArrLength = arr.Length;
    int[] ReArr = new int[ArrLength];
    for (int i = 0; i < ArrLength; i++)
    {
        ReArr[i] = arr[ArrLength - i - 1];
    }
    Console.WriteLine($"Ваш перевёрнутый массив [{string.Join(", ", ReArr)}]");
}

int[] array = GetArray(10, -2, 20);
FlipArray(array);