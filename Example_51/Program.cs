//Задача 51: Задайте двумерный массив.
//Найдите сумму элементов, находящихся на главной диагонали 
//(с индексами (0,0); (1;1) и т.д.

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
            Console.Write(result[i, j] + " ");
        }
        Console.WriteLine("");
    }
    Console.WriteLine("");
    return result;
}


void GetSumDiag(int[,] BiArray)
{
    int sum = 0;
    for(int i = 0; i < BiArray.GetLength(0); i++)
    {
        for(int j = 0; j < BiArray.GetLength(1); j++)
        {
            sum += i == j ? BiArray[i, j]: 0;
        }
    }
    Console.WriteLine($"Сумма значений по диагонали: {sum}");
}

Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение массива: ");
int mn = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение массива: ");
int mx = Convert.ToInt32(Console.ReadLine());

int[,] Array = GetBiArray(m, n, mn, mx);
GetSumDiag(Array);