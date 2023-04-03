//Задача 59: Задайте двумерный массив из целых чисел. 
// Напишите программу, которая удалит строку 
// и столбец, на пересечении которых расположен наименьший элемент массива.


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


int[] FindMin(int[,] array)
{
    int minValue = array[0,0];
    int[] result = new int[2]{0,0};
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        if(array[i,j] <= minValue) 
        {
        minValue = array[i,j];
        result[0] = i;
        result[1] = j;
        }
    }
    return result;
}

int[,] DeleteCross(int[,] array)
{
    int[] MinId = FindMin(array);
    int[,] result = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    int row = 0;
    int column = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        if(i == MinId[0]) continue;
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if(j == MinId[1]) continue;
            result[row, column] = array[i,j];
            column++;
        }
        row++;
        column = 0;        
    }
    return result;
}

int[,] BiArray = GetBiArray(5, 6, 0, 9);
PrintBiArray(BiArray);
Console.WriteLine("");
Console.Write($"{String.Join(", ", FindMin(BiArray))}");
Console.WriteLine("");
int[,] NewArray = DeleteCross(BiArray);
PrintBiArray(NewArray);



