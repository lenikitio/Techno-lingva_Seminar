//Напишите программу замена элементов массива:
// положительные элементы замените на соответствующие отрицательные, и наоборот.

Console.Clear();
int[] GetArray (int size, int MinValue, int MaxValue)
{
    Console.Write("Прошу ваш массив: [");
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(MinValue,MaxValue+1);
        Console.Write($"{array[i]}");
        Console.Write( i == size -  1 ? "]" : ", ");        
    }
    Console.WriteLine("");
    return array;
}

int[] InverseArray(int[] InvArray)
{
    Console.Write("Вот ваш инверсивный массив: [");
    for(int i = 0; i < InvArray.Length; i++)
    {
        InvArray[i] *= -1;
        Console.Write($"{InvArray[i]}");
        Console.Write( i == InvArray.Length -  1 ? "]" : ", ");      
    }
    return InvArray;
}

Console.WriteLine("Введите размер вашего массива");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Минимальное значение элементов массива");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("А теперь максимальное значение");
int max = Convert.ToInt32(Console.ReadLine());

if(max < min)
{
    Console.WriteLine("Так нельзя");
    return;
}

int[] BeginArray = GetArray(a, min, max);
InverseArray(BeginArray);
