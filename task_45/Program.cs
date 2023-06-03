// Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

int[] CreateArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue);
    }
    return array;
}

void CopyArray(int[] array)
{
    int[] newArray = new int[array.Length];
    for(int i = 0; i < array.Length; i++)
    {
        newArray[i] = array[i];
    }
    Console.Write($"[{String.Join(", ", newArray)}]");
}

int[] array = CreateArray(12, 1, 11);
Console.Write($"[{String.Join(", ", array)}] --> "); CopyArray(array);
