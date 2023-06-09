﻿// Задача 64: Задайте значение N. Напишите программу, которая выведет все
// натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
string InDegree(int N)
{
    if (N==1) return $"{N}"; //возвращаем строку, если значение только единица
    return +$"{N} "+ InDegree(N-1)+" "; //возвращаем строку, по возрвстанию значения станоятся в переди строки.
}
Console.Write("Введите Число: ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine(InDegree(N));