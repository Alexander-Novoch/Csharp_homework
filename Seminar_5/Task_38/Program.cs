// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76


System.Console.WriteLine("Введите размерность массива");
int size = int.Parse(Console.ReadLine()!);

double[] Numbers = new double[size];

Fillarray(Numbers);
Printarray(Numbers);
double Max = Maximum(Numbers);
double Min = Minimum(Numbers);
System.Console.WriteLine($"Max {Max} - Min {Min} = {Max - Min}");


void Fillarray(double[] Numbers)
{
    for (int i = 0; i < size; i++)
        Numbers[i] = new Random().Next(1, 100);
}

void Printarray(double[] Numbers)
{
    for (int i = 0; i < size; i++)
        Console.Write($"{Numbers[i]} ");
    System.Console.WriteLine();
}

double Maximum(double[] Numbers)
{
    Max = Numbers[0];
    for (int i = 1; i < size; i++)
        if (Numbers[i] >= Max)
            Max = Numbers[i];
    return Max;
}

double Minimum(double[] Numbers)
{
    Min = Numbers[0];
    for (int i = 1; i < size; i++)
        if (Numbers[i] <= Min)
            Min = Numbers[i];
    return Min;
}