//Задача 21. Напишите программу, которая принимает на вход координаты двух точек и
// находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84   //  A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("1 вариант: ");
Console.WriteLine();
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



Console.WriteLine();
Console.Write("2 вариант: ");
double xa = 3;
double ya = 6;
double za = 8;

double xb = 2;
double yb = 1;
double zb = -7;

double S = ((xa - xb) * (xa - xb) + (ya - yb) * (ya - yb) + (za - zb) * (za - zb));
S = Math.Sqrt(S);
Console.WriteLine(S);



Console.WriteLine();
Console.Write("3 вариант: ");
Console.WriteLine();
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


/*
22. Найти расстояние между точками в пространстве 2D/3D

Console.Clear();
System.Console.WriteLine();

int numPlan = 3;            // количество осей координат
int min = -5;               // минимальное значение диапазона для выбора случайных чисел
int max = 6;                // максимальное значение диапазона ...

int[] PointCoords(int numPlan)                  
{
    int[] coords = new int[numPlan];
    for (int i = 0; i < numPlan; i++)
    {
        coords[i] = new Random().Next(min, max);
    }
    return coords;
}

void PrintCoords(int[] array)
{
    System.Console.Write($"({array[0]}, ");
    for (int i = 1; i < array.Length - 1; i++)
    {
        System.Console.Write($"{array[i]}, ");
    }
    System.Console.WriteLine($"{array[array.Length - 1]})");
}

double Distance(int[] arr1, int[] arr2)
{
    int sum = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
        sum = sum + (arr1[i] - arr2[i]) * (arr1[i] - arr2[i]);
    }
    double result = Math.Sqrt(sum);
    return result;
}

int[] PointA = PointCoords(numPlan);
int[] PointB = PointCoords(numPlan);

System.Console.Write($"Координаты точки А: ");
PrintCoords(PointA);
System.Console.Write($"Координаты точки B: ");
PrintCoords(PointB);

System.Console.WriteLine($"Расстояние между точками А и В: {Distance(PointA, PointB)}");
System.Console.WriteLine();
*