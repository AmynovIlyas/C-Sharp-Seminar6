// // Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// Например: 
// 45 -> 101101
// 3  -> 11
// 2  -> 10
// Решение данной задачи путем использования метода рекурсии

Console.WriteLine("Введите число для преобразования: ");
int number = int.Parse(Console.ReadLine()!);
Console.WriteLine($"{number} --> {ToBinary(number)}");

string ToBinary(int num)
{
    string result = String.Empty;
    while(num > 0)
    {
        result += (num % 2).ToString();
        num /= 2;
    }
    return result; 
}


