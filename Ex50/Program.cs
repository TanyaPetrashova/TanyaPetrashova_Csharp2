// Задача 50. Напишите программу, которая на вход принимает позиции элемента
// в двумерном массиве, и возвращает значение этого элемента или же указание,
// что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

Console.Write("Enter number of rows: ");
int row = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter number of columns: ");
int column = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[row, column];
FillArray(matrix);
Console.WriteLine("Given an array:");
Pprint(matrix);

Console.WriteLine("Enter row number");
int newRow = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter column number");
int newColumn = Convert.ToInt32(Console.ReadLine());

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
if (newRow > matrix.GetLength(0) || newColumn > matrix.GetLength(1))
{
    Console.WriteLine("There is no the number in the array");
}
else
{
    Console.WriteLine($"Element value: {matrix[newRow - 1, newColumn - 1]}");
}
