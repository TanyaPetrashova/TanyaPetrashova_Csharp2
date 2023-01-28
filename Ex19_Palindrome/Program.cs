// Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да
// НЕЛЬЗЯ ИСПОЛЬЗОВАТЬ СТРОКИ

Console.WriteLine("Enter five-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());

int firstDigit = number / 10000;
int secDigit = number / 1000  % 10;
int thirdDigit = number / 100  % 10;
int forthDigit = number / 10  % 10;
int fifDigit = number % 10;

if ( firstDigit == fifDigit && secDigit == forthDigit)
{       
    Console.WriteLine("It's a palindrome");
}
else
{
    Console.WriteLine("It's not a palindrome");
}



