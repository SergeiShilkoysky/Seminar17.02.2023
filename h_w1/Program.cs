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
Console.Write("для проверки на ПОЛИНДРОМНОСТЬ введите ЧИСЛОВУЮ либо БУКВЕННУЮ последовательность: ");
string array = Console.ReadLine();
int count = array.Length;
int n = 0;
for (int i = 0; i < count / 2; i++)
{
    if (array[i] == array[count - 1 - i])  // с каждым увелич. i на 1 сдвигаемся с последнего элемента влево
    {
        n++; // буду считать к-во совпадений
    }
}
if (n == count / 2)
{
    Console.WriteLine($"ЭТО ПОЛИНДРОМ !!!");
}
else
    Console.WriteLine($"{array} - НЕ является полиндромом");
