// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// Например: 
// 45 -> 101101
// 3  -> 11
// 2  -> 10
// Решение данной задачи путем составления массива и записи его с конца

int Prompt()
{
    Console.WriteLine("Введите число для преобразования");
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

int[] BinaryFromDecimal(int num)
{
    int n = 0;
    int num1 = num;
    while (num > 0)
    {
        num /= 2;
        n++;
    }
    int[] array = new int[n];
    for(int i = 0; i < n; i++)
    {
        array[n - 1 - i] = num1 % 2;
        num1 /= 2;
    }
    return array;
}

int number = Prompt();
int[] array = BinaryFromDecimal(number);
Console.Write($"{String.Join("", array)}");
