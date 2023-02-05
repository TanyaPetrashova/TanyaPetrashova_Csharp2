// Задача 66. Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Enter a natural number M: ");
int numberM = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter a natural number greater than M: ");
int numberN = Convert.ToInt32(Console.ReadLine());

int sum (int numberM, int numberN)
{
    int valie = numberM;
    if (numberM == numberN)
    {
        return 0;
    }
    else
    {
       numberM ++;
       valie = numberM + sum(numberM, numberN);
       return valie;
    }
}

Console.WriteLine($"--> {sum(numberM-1, numberN)}");