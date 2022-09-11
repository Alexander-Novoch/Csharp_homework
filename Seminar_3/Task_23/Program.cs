// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

using System;

Console.WriteLine("Введите число N:");
int number = int.Parse(Console.ReadLine()!);
//Console.Write(number);

Cube(number);

void Cube(int number){
    for (int i = 1; i <= number; i++)
        Console.Write($"{Math.Pow(i,3)}, ");
    
}
