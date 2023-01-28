// Напишите программу, которая принимает на вход цифру, обозначающую
// день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Enter a number of the day of the week: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

DayInfo(dayNumber);

void DayInfo (int dayNumber)
{
    if (dayNumber == 6 || dayNumber == 7)
    {
        Console.WriteLine("Yes");
    }
        else if (dayNumber < 1 || dayNumber > 7) 
        {
        Console.WriteLine("Not a day of the week");
        }
    else 
    {  
        Console.WriteLine("No");
    }
}