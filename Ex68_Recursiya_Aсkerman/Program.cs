// Задача 68: Напишите программу вычисления функции Аккермана
// с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Enter a non-negative number M: ");
int numberM = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter a non-negative number N: ");
int numberN = Convert.ToInt32(Console.ReadLine());


double Ackerman(double numberM, double numberN)
{
    if (numberM == 0)
        return numberN + 1;
    else if (numberM > 0 && numberN == 0)
        return Ackerman(numberM - 1, 1);
    else return Ackerman(numberM - 1, Ackerman(numberM, numberN - 1));
}
Console.WriteLine($"Ackerman(M,N) = {Ackerman(numberM, numberN)}");
