// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int size = 0;
System.Console.WriteLine("Введите размерность массива");
size = int.Parse(Console.ReadLine()!);

int[] Numbers = new int[size];

Fillarray(Numbers);
Printarray(Numbers);
Parity(Numbers);

void Fillarray(int[] Numbers)
{
    for (int i = 0; i < size; i++)
        Numbers[i] = new Random().Next(-50, 100);
}

void Printarray(int[] Numbers)
{
    for (int i = 0; i < size; i++)
        Console.Write($"{Numbers[i]} ");
    System.Console.WriteLine();
}

void Parity(int[] Numbers)
{
    int sum = 0;
    for (int i = 1; i < Numbers.Length; i += 2)
        sum += Numbers[i];
    System.Console.WriteLine($"Сумма нечётных элементов = {sum}");
}