// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.  / 2 -> 1,4

/*
void PrintSqr(int num)
{
 int i = 1;
 while (i<num)
 {
    Console.Write($"{Math.Pow(i,2)}, ");
    i++;
 }    
    Console.Write($"{Math.Pow(i,2)}");
}
Console.Write("введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
PrintSqr(num);
*/



void WriteConsolePowTableN (int value)
{
    for (int i = 1; i <= value; i++)
    {
        Console.Write($"{Math.Pow(i, 2)}");
        Console.Write(i == value ? "." : ", ");
        /*
        if (i < value)
        {
            Console.Write($", ");
        }
        */
    }
    Console.WriteLine("");
}
WriteConsolePowTableN(5);
WriteConsolePowTableN(2);