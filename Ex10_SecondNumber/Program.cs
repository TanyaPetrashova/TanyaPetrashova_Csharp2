// Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1


Console.WriteLine("Enter a three-digit number: ");

int number = Convert.ToInt32(Console.ReadLine());
int a = number / 10  % 10; // нахождение второй цифры трехзначного числа

Console.WriteLine(a);


