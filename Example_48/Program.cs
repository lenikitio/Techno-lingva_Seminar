//Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле:
// Aₘₙ = m+n. Выведите полученный массив на экран.

Console.Clear();

Console.Write("Введите количество строк m: ");
int strok = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов n: ");
int stolb = Convert.ToInt32(Console.ReadLine());

GetBinaryArray(strok, stolb);

void GetBinaryArray(int m, int n)
{
    int[,] result = new int[m, n];
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            result[i, j] = i + j + 2;
            Console.Write(result[i, j] + " ");
        }
    Console.WriteLine("");
    }
}
