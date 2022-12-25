﻿// Task_066
// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int Sum(int m, int n)
{
    if (m == n)
    {
        return m;
    }
    return (m + Sum(m + 1, n));
}

Console.Clear();
Console.Write("Введите первое число: ");
int startValue = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int finalValue = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Суммой элементов в промежутке от {startValue} до {finalValue} является число: {Sum(startValue, finalValue)}");