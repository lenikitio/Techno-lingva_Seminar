//Задача 60: Найти разницу между максимальным и минимальным значением элемента
// в двумерном массиве заполненном случайными числами

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

void GetDifMaxMin (int[,] array)
{
    int maxValue = array[0,0];
    int minValue = array[0,0];
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i,j] >= maxValue) maxValue = array[i,j];
            else if(array[i,j] <= minValue) minValue = array[i,j];
        }
    }
    int dif = maxValue - minValue;
    Console.WriteLine($"Максимальное значение равно {maxValue}, а минимальное значение равно {minValue} разница между ними равна {dif}");
}

int[,] BiArray = GetBiArray(5, 4, -5, 100);
PrintBiArray(BiArray);
GetDifMaxMin(BiArray);

