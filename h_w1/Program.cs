// Задача 19.  Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.  / 14212 -> нет / 12821 -> да / 23432 -> да


//int chislo = Convert.ToInt32(Console.ReadLine());
//int chislo = new Random().Next(10000, 100000);
//Console.WriteLine($"трехзначное число {chislo}");


/*
void CheckPolindrome ();
{
    Console.WriteLine("Введите пятичначное число: ");
int array [] = Convert.ToInt32(Console.ReadLine());
int count = array.Length;
{
   // for (int i = 0; i < count; i++) // проходим по всем элементам массива
    //{
    //    Console.Write($"{array[i]} "); // показываем на экране в строку чз пробел
    //}
    //Console.WriteLine();
}



    //Console.WriteLine($"число {} - полиндром");
//else
    //Console.WriteLine($"число {} не является полиндромом");



/*void PrintPolindr
 {
    int count = array.Length; // получение к-ва элементов массива
    for (int i = 0; i < count; i++) // проходим по всем элементам массива
    {
        Console.Write($"{array[i]} "); // показываем на экране в строку чз пробел
    }
    Console.WriteLine();
}


//PrintPolindr()
*/


Console.Clear();
Console.Write("Введите число: ");
string array = Console.ReadLine();
int d = 0;
for ( int i = 0; i < array.length(); i++)
{
    if (array[i] == array.length() - 1 - i)
       {
        d++;
       }
}
if (d == array.length())
{
    Console.WriteLine($"это полиндром");
}
else
    Console.WriteLine($"{array} - не является полиндромом");
