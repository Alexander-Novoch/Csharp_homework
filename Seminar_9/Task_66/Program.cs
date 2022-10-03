// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите натуральное число M: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите натуральное число N: ");
int n = int.Parse(Console.ReadLine()!);

if (m > n)
    Console.WriteLine("Вы неправильно поняли условие задачи! Перезапустите программу и попробуйте ещё раз)");
else
    Console.WriteLine($"{GetNaturalNumbersInReverse(m, n)}");



int GetNaturalNumbersInReverse(int m, int n)
{
    if (m == n)
        return m;
    else
        return n + GetNaturalNumbersInReverse(m, n - 1);
}