// Напишите программу, которая принимает на вход цифру, обозначающую
// день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Enter a number of the day of the week: ");
int DayNumber = Convert.ToInt32(Console.ReadLine());

DayInfo(DayNumber);

void DayInfo (int DayNumber)
{
    if (DayNumber == 6 || DayNumber == 7)
    {
        Console.WriteLine("Yes");
    }
        else if (DayNumber < 1 || DayNumber > 7) 
        {
        Console.WriteLine("Not a day of the week");
        }
    else 
    {  
        Console.WriteLine("No");
    }
}