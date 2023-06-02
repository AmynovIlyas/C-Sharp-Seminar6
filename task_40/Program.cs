// Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.
// (теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы 2 других сторон)

int Prompt(string msg)
{
    Console.WriteLine(msg);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

void CheckBeTriangle(int a, int b, int c)
{
    if (a + b > c && a + c > b && c + b > a)
    {
        Console.Write("Треугольник со сторонами такой длины СУЩЕСТВУЕТ");
    }
    else
    {
        Console.Write("Треугольник со сторонами такой длины НЕ существует");
    }
}

int a = Prompt("Введите число a: ");
int b = Prompt("Введите число b: ");
int c = Prompt("Введите число c: ");
CheckBeTriangle(a, b, c);


