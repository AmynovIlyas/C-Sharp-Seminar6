﻿// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Например:
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

int Prompt()
{
    Console.WriteLine("Введите число: ");
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

void Fibonachi(int num)
{
    if(num <= 0)
    {
        Console.Write("нет значений");
    }
    else if (num == 1)
    {
        Console.Write(0);
    }
    else
    {
    int[] array = new int[num];
    array[0] = 0;
    array[1] = 1;
    for(int i = 2; i < num; i++)
    {
        array[i] = array[i-1] + array[i-2];
    } 
    Console.Write($"{String.Join(" ", array)}");
    }
}

int number = Prompt();
Console.Write($"{number} --> "); Fibonachi(number);

