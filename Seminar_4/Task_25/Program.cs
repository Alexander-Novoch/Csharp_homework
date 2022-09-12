// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
using System;

Console.WriteLine("Введите через пробел два числа: A B");
string numberAB = Console.ReadLine()!;
string[] partsA = numberAB.Split(' ');
int numberA = int.Parse(partsA[0]);
int numberB = int.Parse(partsA[1]);
int powA = numberA;

for (int i = 2; i <= numberB; i++)
    powA = powA * numberA; 
Console.WriteLine($"A в степени B = {powA}");