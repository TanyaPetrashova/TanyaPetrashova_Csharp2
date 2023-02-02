// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и
// выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Write("Enter number of rows: ");
int row = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter number of columns: ");
int column = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[row, column];
FillArray(matrix);
Console.WriteLine("Given an array:");
Pprint(matrix);

int sum = SumAllRowElem(matrix, 0);
int minValie = 0;

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
            matr[i, j] = new Random().Next(1, 10);             
        }
    }
}
//Метод нахождения суммы элементов в каждой строке
int SumAllRowElem(int[,] matr, int i)
{
    int sum = matr[i, 0];
    for (int j = 1; j < matr.GetLength(1); j++)
    {
        sum += matr[i, j];
    }
    return sum;
}
// Находим строку с минимальной суммой элементов
for (int i = 1; i < matrix.GetLength(0); i++)                           
{
    int currentRow = SumAllRowElem(matrix, i);
    if (sum > currentRow)
    {
        sum = currentRow;
        minValie = i;
    }
}
Console.WriteLine($"Minimum sum of elements is in row: {minValie + 1}");
    
         