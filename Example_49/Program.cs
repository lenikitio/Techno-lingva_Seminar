//Задача 49: Задайте двумерный массив.
// Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты

int[,] GetBinaryArray(int m, int n, int min, int max)
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
    return result;
}

void GetSquareEven(int[,] array)
{
    int[,] SquarEven = new int[array.GetLength(0), array.GetLength(1)];
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if(i % 2 == 0 && j % 2 == 0) 
            SquarEven[i, j] = (int)Math.Pow(array[i, j], 2);
            else SquarEven[i, j] = array[i, j];
            Console.Write(SquarEven[i, j] + " "); 
        }
        Console.WriteLine("");
    }
}


int[,] BiArray = GetBinaryArray(5, 5, 0, 10);
Console.WriteLine("");
GetSquareEven(BiArray);