/*Задача 37 Найдите произведение пар чисел в одномерном массиве.
Парой считаем первый и последний элемент, второй и предпоследни  и т.д.
Результат в новом массиве.
*/

Console.Clear();

int[] GetArray (int size, int min, int max)
{
    int[] result = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < result.Length; i++)
    result[i] = rnd.Next(min, max + 1);
    Console.WriteLine($"Ваш массив: [{string.Join(", ", result)}]");
    return result;
}

int[] GetMultiArray (int[] array)
{
    int size = array.Length;
    if(size % 2 == 1) 
    size ++;
    size /= 2;
    int[] NewArray = new int[size];
    for(int i = 0; i < size; i++)
    {
        NewArray[i] = array[i] * array[array.Length - 1 - i];
    }
    Console.WriteLine($"Ваш перемноженный массив: [{string.Join(", ", NewArray)}]");
    return NewArray;
}

int[] WantArrey = GetArray(9, 0, 10);
GetMultiArray(WantArrey);
