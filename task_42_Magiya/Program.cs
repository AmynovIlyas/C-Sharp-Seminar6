// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// Например: 
// 45 -> 101101
// 3  -> 11
// 2  -> 10
// Решение данной задачи путем выведения остатка от деления на два в строку с использованием способа,
// освобождающего от необходимости переворачивать строку


Console.WriteLine("Введите число для преобразования: ");
int number = int.Parse(Console.ReadLine()!);
Console.WriteLine($"{number} --> {ToBinary(number)}");


string ToBinary(int num)
{
    string result = String.Empty;
    while(num > 0)
    {
        result = num % 2 + result; // заменяем действие "result += num % 2" на "result = num % 2 + result"
        num /= 2;
    }
    return result;
}


