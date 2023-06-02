// Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, 
// а первый - на последнем и т.д.)
// Например:
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]
// Решение данной задачи путём создания нового массива переписанием начального с конца

int[] CreateArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue);
    }
    return array;
}

void ReverseArray(int[] array)
{
    int[] result = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        result[i] = array[array.Length - 1 - i];
    }
    Console.Write($"[{String.Join(", ", result)}]");
}

int[] array = CreateArray(9, 1, 10);
Console.Write($"[{String.Join(", ", array)}] --> "); ReverseArray(array);
