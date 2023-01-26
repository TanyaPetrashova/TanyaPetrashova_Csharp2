// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Enter Point A coordinates: ");

double Ax = Convert.ToDouble(Console.ReadLine());
double Ay = Convert.ToDouble(Console.ReadLine());
double Az = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter Point B coordinates: ");

double Bx = Convert.ToDouble(Console.ReadLine());
double By = Convert.ToDouble(Console.ReadLine());
double Bz = Convert.ToDouble(Console.ReadLine());

double distanseAB = Math.Sqrt(Math.Pow((Bx - Ax), 2)
                  + Math.Pow((By - Ay), 2)
                  + Math.Pow((Bz - Az), 2));

Console.WriteLine("Distanse between A & B: " +distanseAB);



