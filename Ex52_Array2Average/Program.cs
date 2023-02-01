﻿// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Write("Enter number of rows: ");
int row = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter number of columns: ");
int column = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[row, column];
FillArray(matrix);
Console.WriteLine("Given an array:");
Pprint(matrix);

Console.WriteLine("Average of each column: ");

// Метод печати массива
void Pprint(int[,] matr)              
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}
// Метод заполнения массива случайными числами
void FillArray(int[,] matr)                      
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 15);             
        }
    }
}
// Метод нахождения среднего арифметического элементов в каждом столбце
for (int j = 0; j < matrix.GetLength(1); j++)
{
    double average = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        average = (average + matrix[i, j]);
    }
    average = average / row;
    
    Console.Write($"{Math.Round(average, 1)}; ");
}