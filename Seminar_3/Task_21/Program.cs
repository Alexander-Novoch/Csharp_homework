// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
using System;

Console.WriteLine("Введите через пробел координаты первой точки: X Y Z");
string xyzA = Console.ReadLine()!;
string[] partsA = xyzA.Split(' ');
int xA = int.Parse(partsA[0]);
int yA = int.Parse(partsA[1]);
int zA = int.Parse(partsA[2]);

Console.WriteLine("Введите через пробел координаты второй точки: X Y Z");
string xyzB = Console.ReadLine()!;
string[] partsB = xyzB.Split(' ');
int xB = int.Parse(partsB[0]);
int yB = int.Parse(partsB[1]);
int zB = int.Parse(partsB[2]);

double distance = Math.Sqrt(Math.Pow(xA - xB,2) + Math.Pow(yA - yB,2) + Math.Pow(zA - zB,2));
Console.WriteLine($"расстояние между ними в 3D пространстве: {distance:F3}.");
