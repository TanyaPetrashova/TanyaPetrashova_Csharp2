// Задача 41. Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 4

Console.WriteLine("Enter numbers separated by spaces (for example: 5 -7 9 -3 44 -89): ");
// Конвертируем строку чисел, разделённых пробелом, в массив int:
int[] array = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);             
int M = 0;                                                                            
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        M++;
    }
}
 
Console.WriteLine($"Numbers greater than zero: {M}"); 