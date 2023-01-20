// Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.Write("Enter a number: ");
string Number = Console.ReadLine();

if(Number.Length > 2)
{
    Console.WriteLine("Third digit: " +Number[2]);
}

else
{
    Console.WriteLine("No third digit");
}

