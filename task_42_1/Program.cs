// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// Например: 
// 45 -> 101101
// 3  -> 11
// 2  -> 10
// Решение данной задачи путем выведения остатка от деления на два в виде строки и последующий переворот этой строки


Console.WriteLine("Введите число для преобразования: ");
int number = int.Parse(Console.ReadLine()!);
Console.WriteLine($"{number} --> {ToBinary(number)}");

string ReverseString(string str)
{
    string result = String.Empty;
    for (int i = str.Length - 1; i >= 0; i--)
    {
        result += str[i];
    }
    return result;
}

string ToBinary(int num)
{
    string result = String.Empty;
    while(num > 0)
    {
        result += num % 2;
        num /= 2;
    }
    return ReverseString(result);
}

