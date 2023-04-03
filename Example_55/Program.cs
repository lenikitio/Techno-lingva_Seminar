//Задача 55: Задайте двумерный массив. 
// Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

Console.Clear();

int[,] GetBiArray(int strok, int stolb, int min, int max)
{
    int[,] result = new int[strok, stolb];
    Random rnd = new Random();
    for(int i = 0; i < strok; i++)
    {
        for(int j = 0; j < stolb; j++)
        {
            result[i,j] = rnd.Next(min, max + 1);
        }
    }
    return result;
}

void PrintBiArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        Console.Write($"{array[i,j]} ");
        Console.WriteLine("");
    }
}

int[,] FlipArray(int[,] array)
{
    Console.WriteLine("");
    int[,] ReArray = new int[array.GetLength(0), array.GetLength(1)];
    if(array.GetLength(0) != array.GetLength(1))
    {
        Console.WriteLine("Невозможно поменять колонки с строками, их количество должно быть одинаковым");
        return array;
    }
    else
    {
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        ReArray[i,j] = array[j,i];
    }
    PrintBiArray(ReArray);
    return ReArray;
    }
}

int[,] BiArray = GetBiArray(4, 4, 0, 9);
PrintBiArray(BiArray);

int[,] result = FlipArray(BiArray);

