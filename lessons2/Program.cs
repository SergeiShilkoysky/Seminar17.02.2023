// Напишите программу, которая по заданному номеру четверти,
// показывает диапазон возможных координат точек в этой четверти (x и y).

/*Console.Clear();

Console.WriteLine("Введем номер четверти:");
int Chetv = int.Parse(Console.ReadLine());

if (Chetv == 1)
    Console.WriteLine("x>0 & y>0");
else if (Chetv == 2)
    Console.WriteLine("x<0 & y>0");
else if (Chetv == 3)
    Console.WriteLine("x<0 & y<0");
else if (Chetv == 4)
    Console.WriteLine("x>0 & y<0");
else
    Console.WriteLine("четверть не определена");
*/



Console.Clear();

Console.WriteLine("Введем номер четверти:");
int Chetv = int.Parse(Console.ReadLine());
switch (Chetv)
{
    case 1:
        Console.WriteLine("x>0 & y>0");
        break;
    case 2:
        Console.WriteLine("x<0 & y>0");
        break;
    case 3:
        Console.WriteLine("x<0 & y<0");
        break;
    case 4:
        Console.WriteLine("x>0 & y<0");
        break;
    default:
        Console.Write("четверть не определена");
        break;
}

