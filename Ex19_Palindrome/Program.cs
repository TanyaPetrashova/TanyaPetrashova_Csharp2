// Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да
// НЕЛЬЗЯ ИСПОЛЬЗОВАТЬ СТРОКИ

Console.WriteLine("Enter five-digit number: ");
int Number = Convert.ToInt32(Console.ReadLine());

int a = Number / 10000;
int b = Number / 1000  % 10;
int c = Number / 100  % 10;
int d = Number / 10  % 10;
int e = Number % 10;

if (a == e || b == d)
{       
    Console.WriteLine("It's a palindrome");
}
else
{
    Console.WriteLine("It's not a palindrome");
}



