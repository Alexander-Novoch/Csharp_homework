// Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

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
        Numbers[i] = new Random().Next(100, 1000);
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
    foreach (int number in Numbers)
        if (number % 2 == 0)
            sum++;
    System.Console.WriteLine($"Количество чётных элементов = {sum}");
}