// Задача 2. Напишите программу, которая на вход принимает два числа
// и выдаёт, какое число большее, а какое меньшее.
// a = 5, b = 7 -> max = 7
// a = 2, b = 10 -> max = 10
// a = -9, b = -3 -> max = -3

Console.WriteLine("Enter number a: ");
int aNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number b: ");
int bNumber = Convert.ToInt32(Console.ReadLine());

int max = aNumber;

if ( bNumber > aNumber)
{
    max = bNumber;
}
Console.WriteLine($"{"Max number: " +max}");
