// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Введите натуральное число N: ");
int n = int.Parse(Console.ReadLine()!);

Console.WriteLine(GetNaturalNumbersInReverse(n));

string GetNaturalNumbersInReverse(int n)
{
    if (n == 1)
        return "1";
    else
        return n + ", " + GetNaturalNumbersInReverse(n - 1);
}