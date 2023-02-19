//Задача 21. Напишите программу, которая принимает на вход координаты двух точек и
// находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84   //  A (7,-5, 0); B (1,-1,9) -> 11.53
/*
double Distance3D (int x1, int y1, int z1, int x2, int y2, int z2)
{
    double xpow = Math.Pow(Convert.ToDouble(x2 - x1), 2);
    double ypow = Math.Pow(Convert.ToDouble(y2 - y1), 2);
    double zpow = Math.Pow(Convert.ToDouble(z2 - z1), 2);
    double dist = Math.Sqrt(xpow + ypow + zpow);
    return Math.Round (dist, 2, MidpointRounding.ToEven);
}
Console.WriteLine($"Расстояние между точками: {Distance3D(3,6,8,2,1,-7)}");
Console.WriteLine($"Расстояние между точками: {Distance3D(7,-5,0,1,-1,9)}");
*/
/*
int numPlan = 3;
int[] PointCoords(int numPlan)                  
{
    int[] coords = new int[numPlan];
    for (int i = 0; i < numPlan; i++)
    {
        coords[i] = new Random().Next(-6, 5);
    }
    return coords;
}
*/
void PrintCoords(int[] array)
{
    System.Console.Write($"({array[0]}, ");
    for (int i = 1; i < array.Length - 1; i++)
    {
        System.Console.Write($"{array[i]}, ");
    }
    System.Console.WriteLine($"{array[array.Length - 1]})");
}

System.Console.Write($"Координаты точки А: ");
PrintCoords(PointA);
System.Console.Write($"Координаты точки B: ");
PrintCoords(PointB);

/*Console.Clear();
Console.Write($"для точки А введите значение x1: ");
double x1 = Convert.ToInt32(Console.ReadLine());
Console.Write($"для точки А введите значение y1: ");
double y1 = Convert.ToInt32(Console.ReadLine());
Console.Write($"для точки А введите значение z1: ");
double z1 = Convert.ToInt32(Console.ReadLine());

Console.Write($"для точки B введите значение x2: ");
double x2 = Convert.ToInt32(Console.ReadLine());
Console.Write($"для точки B введите значение y2: ");
double y2 = Convert.ToInt32(Console.ReadLine());
Console.Write($"для точки B введите значение z2: ");
double z2 = Convert.ToInt32(Console.ReadLine());

double AB = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
Console.WriteLine($"расстояние AB = {Math.Round(AB, 2, MidpointRounding.ToEven)}");
*/


