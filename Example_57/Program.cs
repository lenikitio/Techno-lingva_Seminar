// Задача 57: Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

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

int[] SortArray (int[,] array)
{
    int index = 0;
    int[] result = new int[array.GetLength(0) * array.GetLength(1)];
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
        result[index] = array[i,j];
        index++;
        }
    }
    Array.Sort(result);
    return result;
}

void PrintLibrary(int[] array)
{
    int count = 1;
    int elem = array[0];
    for(int i = 1; i < array.Length; i++)
    {
        if(array[i] != elem)
        {
            Console.WriteLine($"В массиве элемент {elem} повторяется {count} раз");
            count = 1;
            elem = array[i];
        }
        else count++;
    }
    Console.WriteLine($"В массиве элемент {elem} повторяется {count} раз");
}


int[,] BiArray = GetBiArray(5, 8, 0, 9);
PrintBiArray(BiArray);

int[] UnoArray = SortArray(BiArray);
PrintLibrary(UnoArray);