﻿// Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

int N = 8;

int index = 1;

while (index <= N)
{
    if (index % 2 == 0)
    {
        Console.WriteLine(index);
    }
    index++;
}