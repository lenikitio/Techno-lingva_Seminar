//Задача 53: Задайте двумерный массив. 
//Напишите программу, которая поменяет местами первую и последнюю строку массива.


Console.Clear();

int[,] GetBiArray(int strok, int stolb, int min, int max)
{
    Random rnd = new Random();
    int[,] result = new int[strok, stolb];
    for(int i = 0; i < strok; i++)
    {
        for(int j = 0; j < stolb; j++)
        {
            result[i, j] = rnd.Next(min, max + 1);
        }
    }
    return result;
}

void PrintBiArray(int[,] BiArray)
{
    for(int i = 0; i < BiArray.GetLength(0); i++)
    {
        for(int j = 0; j < BiArray.GetLength(1); j++)
        {
            Console.Write(BiArray[i, j] + " ");
        }
        Console.WriteLine("");
    }
    Console.WriteLine("");
}

int[,] ReverseArray(int[,] array)
{
    int SrtSize = array.GetLength(0);
    int StolbSize = array.GetLength(1);
    int[,] ReArray = (int[,])array.Clone();
    for(int i = 0; i < StolbSize; i++)
    {
        ReArray[0, i] = array[SrtSize - 1, i];
        ReArray[SrtSize - 1, i] = array[0, i];
    }
    return ReArray;
}

Console.Write("Введите Количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Количество столбиков массива: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение массива: ");
int mn = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение массива: ");
int mx = Convert.ToInt32(Console.ReadLine());

int[,] array = GetBiArray(m, n, mn, mx);
PrintBiArray(array);
int[,] ReArr = ReverseArray(array);
PrintBiArray(ReArr);
