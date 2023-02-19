//Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y),
//причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

Console.Clear();
Console.WriteLine("Введите X:");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Введите Y:");
int y = int.Parse(Console.ReadLine());

if (x > 0 && y > 0)
    Console.WriteLine("1 четверть");
else if (x < 0 && y > 0)
    Console.WriteLine("2 четверть");
else if (x < 0 && y < 0)
    Console.WriteLine("3 четверть");
else if (x > 0 && y < 0)
    Console.WriteLine("4 четверть");
else
    Console.WriteLine("четверть не определена");


/*
int GetRandPositivNumber()
{
    return new Random().Next(0, 1000);
}
int GetRandNegativNumber()
{
    return new Random().Next(-1000, 0);
}
Console.Write("Введите четверть: ");
int area = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" ");
switch (area)
{
    case 1:
        Console.WriteLine($" X : {GetRandPositivNumber()} Y : {GetRandPositivNumber()}");
        break;
    case 2:
        Console.WriteLine($" X : {GetRandPositivNumber()} Y : {GetRandNegativNumber()}");
        break;
    case 3:
        Console.WriteLine($" X : {GetRandNegativNumber()} Y : {GetRandNegativNumber()}");
        break;
    case 4:
        Console.WriteLine($" X -: {GetRandNegativNumber()} Y : {GetRandPositivNumber()}");
        break;
}
*/