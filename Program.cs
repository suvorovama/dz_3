﻿/*Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом.

14212 -> нет
12821 -> да
23432 -> да

Console.Write ("Введите пятизначное число:");
string? number = Console.ReadLine();
if (number[0] == number[4] && number[1] == number[3])
{
    Console.Write ("да");
}
else
{
    Console.Write ("нет");
}

Напишите программу, которая принимает на вход координаты двух точек
 и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53

sqrt((x2-x1)^2)+ (y2-y1)^2+ (z2-z1)^2

Console.Write ("Введите координату х для точки А:");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите координату y для точки А:");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите координату z для точки А:");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите координату х для точки B:");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите координату y для точки B:");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите координату z для точки B:");
int z2 = Convert.ToInt32(Console.ReadLine());
double distance = Math.Sqrt(Math.Pow(x2-x1,2) + Math.Pow(y2-y1,2) + Math.Pow(z2-z1,2));
Console.WriteLine($"Расстояние между точками:{Math.Round(distance,2)}");

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

Console.Write("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
for (int result = 1; result <= number; result++)
{
    Console.Write(Math.Pow(result,3));
}