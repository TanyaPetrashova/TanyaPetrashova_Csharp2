// Задача 13. Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.Write("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());
string numberText = Convert.ToString(number);

if (number < -99 || number > 99)
{
    if (number > 0)
    {
        Console.WriteLine($"Third digit: {numberText[2]}");
    }
    else
    {
        Console.WriteLine($"Third digit: {numberText[3]}");
    }
}
else
{
    Console.WriteLine("No third digit");
}

