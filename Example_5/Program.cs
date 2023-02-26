//Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива

//Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.


Console.Clear();
void GetRandomArraySum()
{
    Console.Write("Наш массив: [");
    int[] array = new int [12];
    int arrayLength = array.Length;
    int PlusSum = 0;
    int MinusSum = 0;
    for(int i = 0; i < arrayLength; i++)
    {
        array[i] = new Random().Next(-9, 9);
        Console.Write($"{array[i]}");
        Console.Write(i == arrayLength - 1 ? "]" : ", ");
        switch (array[i])
        {
            case > 0: PlusSum += array[i];
            break;
            case < 0: MinusSum += array[i];
            break;
        }
    }  
    Console.WriteLine("");
    Console.WriteLine($"Сумма отрицательных чисел равна: {MinusSum}");  
    Console.WriteLine($"Сумма положительных чисел равна: {PlusSum}");  
}

GetRandomArraySum();
