//Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.

// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

Console.Clear();

void FillBinaryArray(int m, int n, int min, int max)
{
    Random rnd = new Random();
    int[,] result = new int[m, n];
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
        result[i, j] = rnd.Next(min, max + 1);
        Console.Write(result[i, j] + " ");
        }
        Console.WriteLine("");
    }
}

Console.Write("Введите количесство строк m: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количесство столбцов n: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение массива: ");
int mn = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение массива: ");
int mx = Convert.ToInt32(Console.ReadLine());

FillBinaryArray(a, b, mn, mx);